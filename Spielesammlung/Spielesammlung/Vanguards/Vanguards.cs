using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SlimDX;
using D2D = SlimDX.Direct2D;
using DXGI = SlimDX.DXGI;
using System.Threading;
using System.Windows.Input;
using SlimDX.XAudio2;
using System.Timers;

namespace Spielesammlung.Vanguards
{
    public partial class Vanguards : Form
    {
        #region Variablen
        //Visual Ressources
        private D2D.Factory m_factory;
        private D2D.WindowRenderTarget m_renderTarget;
        private D2D.LinearGradientBrush m_backBrushEx;
        private D2D.GradientStopCollection m_backBrushGradient;
        private D2D.Bitmap spaceShipBitmap;
        private Bitmap spaceshipBitmapGDI;
        private Brush m_backBrushGdi;
        private bool m_initialized;
        private bool m_debugMode;

        //Player Ressources
        private bool destroyed = false;
        private int score = 0;
        private int lives = 0;
        private PlayerShip _Player;
        private bool _KeyUp = false;
        private bool _KeyDown = false;
        private bool _KeyLeft = false;
        private bool _KeyRight = false;
        private System.Windows.Forms.Timer _enemyFireTimer = new System.Windows.Forms.Timer { Interval = 50 };
        private List<Resources.Projektile> _projektilListe = new List<Resources.Projektile>();
        private D2D.Bitmap projektileBitmap;
        private Bitmap projektileBitmapGdi;
        private D2D.Bitmap projektileHostileBitmap;
        private D2D.Bitmap enenyShipBitmap;
        private Bitmap projektileHostileBitmapGdi;
        private Bitmap continueScreenGDI = Resources.Resources._continue;
        private bool gameOver = false;
        private System.Timers.Timer levelTicker = new System.Timers.Timer();
        private System.Timers.Timer projectileTicker = new System.Timers.Timer();
        private System.Timers.Timer movementTicker = new System.Timers.Timer();
        private static bool[] keys_down;
        private static Keys[] key_props;
        private Resources.Level level = new Resources.Level();
        private bool pause = false;
        private bool nextLevel = false;
        private bool invincible = true;
        private int invincibleCount = 0;
        Highscore VanguardsHighScore = new Highscore();
        private bool firstTimeStarted=true;
        private string playerName = "";
        #endregion 
        public Vanguards()
        {
            InitializeComponent();
            keys_down = new bool[4];
            key_props = new[] { Keys.A, Keys.D, Keys.W, Keys.S };
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            m_backBrushGdi = new SolidBrush(this.BackColor);

            InitializeGraphics();
            _enemyFireTimer.Tick += EnemyFireTick;
            _enemyFireTimer.Start();
            level.LoadLevel1(m_renderTarget);
            levelTicker.Elapsed += new ElapsedEventHandler(LevelTick);
            levelTicker.Interval = 15;
            movementTicker.Elapsed += new ElapsedEventHandler(tick);
            movementTicker.Interval = 1;
            movementTicker.Enabled = true;
            projectileTicker.Elapsed += new ElapsedEventHandler(ProjektilTicK);
            projectileTicker.Interval = 3;
            projectileTicker.Enabled = true;

            levelTicker.Enabled = true;
            lives = 3;
            label1.Text = "Leben:" + lives;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Vanguards_KeyDown);
            this.KeyUp += new KeyEventHandler(Vanguards_KeyUp);
            continueScreenGDI.MakeTransparent(Color.White);
            if(firstTimeStarted)
            {
                groupHelp.Parent = this;
                
                pause = true;
                groupHelp.Visible = true;
            }
        }

        //Prüfen ob Zwei Objekte sich überschneiden
        static bool IntersectPixels(Rectangle rectangleA, Bitmap bmpA,
                            Rectangle rectangleB, Bitmap bmpB)
        {
            
            return rectangleA.IntersectsWith(rectangleB);

        }

        //Timer für Bewegung der Spieler
        private void tick(Object source, EventArgs e)
        {

            if (!pause)
            {
                _DoMovement();


            }


        }
        //Timer für bewegungen der Projektile
        private void ProjektilTicK(Object source, EventArgs e)
        {
            if (!pause)
            {
                for (int i = _projektilListe.Count - 1; i >= 0; i--)
                {
                    if (_projektilListe[i].PosX < this.Width && _projektilListe[i].PosX > 0)
                    {
                        if (_projektilListe[i].Hostile)
                        {
                            _projektilListe[i].PosX -= 15;
                            _projektilListe[i].FlightTime += 1;
                            if ((IntersectPixels(new Rectangle(_Player.PosX, _Player.PosY, _Player.ShipHitboxX, _Player.ShipHitboxY), _Player.SpaceshipBitmapGDI, new Rectangle(_projektilListe[i].PosX, _projektilListe[i].PosY, 30, 5), _projektilListe[i].ProjectileBit))&&(!invincible))
                            {
                                destroyed = true;
                            }

                        }
                        else
                        {
                            _projektilListe[i].PosX += 15;
                            _projektilListe[i].FlightTime += 1;
                        }
                    }
                    else if(_projektilListe[i].PosX>this.Width|| _projektilListe[i].PosX<0)
                    {
                        //_projektilListe.RemoveAt(i);
                    }
                }
                this.Invalidate();

            }
        }
        //Timer für gegnerisches Feuer
        private void EnemyFireTick(Object source, EventArgs e)
        {
              foreach(Resources.EnemyShip enemy in level.EnemyShipList)
            {
               if (enemy.PosX < this.Width&&enemy.PosX>0)
               {
                enemy.WeaponCooldonw += 10;
                if (enemy.WeaponCooldonw == 100&&!enemy.Destroyed)
              {
                _projektilListe.Add(new Resources.Projektile(true, true, enemy.PosX, enemy.PosY + 50, 5));
                enemy.WeaponCooldonw = 0;
             }
             }
             }
        }
        //Timer für Bewegungen des Levels
        private void LevelTick(Object source, EventArgs e)
        {
            if (!pause)
            {

                if (invincible)
                {
                    invincibleCount++;
                    if (invincibleCount == 100)
                    {
                        invincible = false;
                        invincibleCount = 0;
                    }
                }
                level.LevelPositionX = level.LevelPositionX - 1;
                if(level.LevelPositionX==-1465)
                {
                    score += 50;
                    nextLevel = true;
                    
                   
                    
                }
                level.ScoreCount += 10;
                if (level.ScoreCount >= 100)
                {
                    score += 1;
                    level.ScoreCount = 0;
                }

                foreach (Resources.EnemyShip ships in level.EnemyShipList)
                {
                    if ((ships.PosX + ships.ShipHitboxX) > 0)
                    {
                        ships.PosX -= 6;
                        for (int i = _projektilListe.Count - 1; i >= 0; i--)
                        {
                            if ((ships.Destroyed == false) && (_projektilListe[i].Visible == true) && (!_projektilListe[i].Hostile))
                                if (IntersectPixels(new Rectangle(ships.PosX, ships.PosY, ships.ShipHitboxX, ships.ShipHitboxY), ships.SpaceshipBitmapGDI, new Rectangle(_projektilListe[i].PosX, _projektilListe[i].PosY, 30, 5), _projektilListe[i].ProjectileBit))
                                {
                                    ships.Destroyed = true;
                                    _projektilListe[i].Visible = false;
                                    score += 10;

                                }
                        }
                    }
                    if ((IntersectPixels(new Rectangle(_Player.PosX, _Player.PosY, _Player.ShipHitboxX, _Player.ShipHitboxY), _Player.SpaceshipBitmapGDI, new Rectangle(ships.PosX, ships.PosY, ships.ShipHitboxX, ships.ShipHitboxY), ships.SpaceshipBitmapGDI)&&!ships.Destroyed)&&(!invincible))
                    {
                        destroyed = true; 
                    }
                }
                foreach (Resources.LevelObject objects in level.ObjectList)
                {
                    objects.PosX -= 3;
                }
            }
        }

        //Führt Positionsveränderung ders spielers durch
        private void _DoMovement()
        {
            if (_KeyDown&&((_Player.PosY+_Player.ShipHitboxY)<this.Height)) { _Player.PosY = _Player.PosY + 3; }
            if (_KeyUp&&_Player.PosY>0) { _Player.PosY = _Player.PosY - 3; }
            if (_KeyLeft&&_Player.PosX>0) { _Player.PosX = _Player.PosX - 3; }
            if (_KeyRight&& ((_Player.PosX + _Player.ShipHitboxX) < this.Width)) { _Player.PosX = _Player.PosX + 3; }

            this.Invalidate();
        }
        //Sezt die bewegungsvariablen zurück wen die tasten loßgelassen werden
        private void Vanguards_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.S:


                    _KeyDown = false;


                    break;

                case Keys.Down:

                    _KeyDown = false;

                    break;
                case Keys.W:

                    _KeyUp = false;

                    break;

                case Keys.Up:

                    _KeyUp = false;

                    break;
                case Keys.Right:
                case Keys.D:

                    _KeyRight = false;
                    break;

                case Keys.A:

                    _KeyLeft = false;
                    break;

                case Keys.Left:
                    _KeyLeft = false;
                    break;

            }
            _DoMovement();

            this.Invalidate();
            if (!_KeyDown && !_KeyLeft && !_KeyRight && !_KeyUp)
            {
                // _movementTimer.Stop();
            }

        }

        // Ladet eine Bitmap als d2d von einer datei
        public D2D.Bitmap LoadBitmap(string file)
        {
            D2D.Bitmap result = null;

            //Create Gdi Bitmap 
            Bitmap drawingBitmap = Bitmap.FromFile(file) as Bitmap;

            //Load the Direct2D resource from the gdi resource
            result = LoadBitmap(drawingBitmap);

            //Dispose the gdi bitmap after loading
            drawingBitmap.Dispose();

            return result;
        }


        // ladet eine d2d bitmap aus einer gdi bitmap
        public D2D.Bitmap LoadBitmap(Bitmap drawingBitmap)
        {
            D2D.Bitmap result = null;

            //Lock the gdi resource
            BitmapData drawingBitmapData = drawingBitmap.LockBits(
            new Rectangle(0, 0, drawingBitmap.Width, drawingBitmap.Height),
            ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);

            //Prepare loading the image from gdi resource
            DataStream dataStream = new DataStream(
                drawingBitmapData.Scan0,
                drawingBitmapData.Stride * drawingBitmapData.Height,
                true, false);
            D2D.BitmapProperties properties = new D2D.BitmapProperties();
            properties.PixelFormat = new D2D.PixelFormat(
                DXGI.Format.B8G8R8A8_UNorm,
                D2D.AlphaMode.Premultiplied);

            //Load the image from the gdi resource
            result = new D2D.Bitmap(
                m_renderTarget,
                new Size(drawingBitmap.Width, drawingBitmap.Height),
                dataStream, drawingBitmapData.Stride,
                properties);

            //Unlock the gdi resource
            drawingBitmap.UnlockBits(drawingBitmapData);

            return result;
        }


        // Ladet alle Graphischen ressoursen
        private void InitializeGraphics()
        {
            //Get requested debug level
            D2D.DebugLevel debugLevel = D2D.DebugLevel.None;
            if (m_debugMode) { debugLevel = D2D.DebugLevel.Error; }

            //Create factory object
            m_factory = new D2D.Factory(D2D.FactoryType.SingleThreaded, debugLevel);

            //Create the render target
            m_renderTarget = new D2D.WindowRenderTarget(m_factory, new D2D.WindowRenderTargetProperties()
            {
                Handle = this.Handle,
                PixelSize = this.Size,
                PresentOptions = D2D.PresentOptions.Immediately
            });

            //Create linear gradient brush
            D2D.GradientStop[] gradientStops = new D2D.GradientStop[]
            {
                new D2D.GradientStop(){ Position = 0f, Color = new Color4(Color.LightGray) },
                new D2D.GradientStop(){ Position = 1f, Color = new Color4(Color.Black) }
            };
            m_backBrushGradient = new D2D.GradientStopCollection(m_renderTarget, gradientStops);
            m_backBrushEx = new D2D.LinearGradientBrush(
                m_renderTarget,
                m_backBrushGradient,
                new D2D.LinearGradientBrushProperties()
                {
                    StartPoint = new PointF(0, this.Height),
                    EndPoint = new PointF(0, 0)
                });

            //Create gdi backbrush
            if (m_backBrushGdi != null) { m_backBrushGdi.Dispose(); }
            m_backBrushGdi = new LinearGradientBrush(
                new Point(0, this.Height),
                new Point(0, 0),
                Color.LightGray,
                Color.LightSteelBlue);

            //Load the bitmap
            level.Backgroundgdi = Resources.Resources.SpaceBackground1;
            level.Background = LoadBitmap(level.Backgroundgdi);

            spaceshipBitmapGDI = Resources.Resources.GreenSpaceShip;
            spaceShipBitmap = LoadBitmap(spaceshipBitmapGDI);
            _Player = new PlayerShip(spaceShipBitmap);
            projektileBitmapGdi = Resources.Resources.greenProjectile;
            projektileBitmap = LoadBitmap(projektileBitmapGdi);
            projektileHostileBitmapGdi = Resources.Resources.greenprojectile1;
            projektileHostileBitmap = LoadBitmap(projektileHostileBitmapGdi);
            level.Backgroundlvl1 = LoadBitmap(Resources.Resources.SpaceBackground1);
            level.Backgroundlvl2 = LoadBitmap(Resources.Resources.sewer);
            level.BackgroundGameOver= LoadBitmap(Resources.Resources.GameOver);
            level.BackgroundNextLevel = LoadBitmap(Resources.Resources.NextLevel);
            enenyShipBitmap = LoadBitmap(Resources.Resources.cartoonship_red);
            //Update initialization flag
            m_initialized = true;
        }
       //Entlädt graphicen
        private void UnloadGraphics()
        {
            if (m_backBrushEx != null) { m_backBrushEx.Dispose(); }
            if (m_backBrushGradient != null) { m_backBrushGradient.Dispose(); }
            if (m_renderTarget != null) { m_renderTarget.Dispose(); }
            if (m_factory != null) { m_factory.Dispose(); }

            m_backBrushEx = null;
            m_backBrushGradient = null;
            m_renderTarget = null;
            m_factory = null;
        }

     
        // Called when window opens.
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if ((!m_initialized) || (!this.DesignMode))
            {
                InitializeGraphics();
            }
        }


        // Called when window closes.
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            if (m_initialized)
            {
                UnloadGraphics();
            }
        }

        // Called when background color has changed.
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            //Update back brush
            if (m_backBrushGdi != null) { m_backBrushGdi.Dispose(); }
            m_backBrushGdi = new SolidBrush(this.BackColor);
        }


        // Called when user changes a parameter.
        private void OnChkParameterCheckedChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        //Sezt die Bewegungsvariablen, und schreibt in das Namen label rein usw
        private void Vanguards_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (!pause)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:


                        _KeyDown = true;


                        break;

                    case Keys.Down:

                        _KeyDown = true;

                        break;
                    case Keys.W:

                        _KeyUp = true;

                        break;

                    
                    case Keys.Up:

                        _KeyUp = true;

                        break;
                    case Keys.Right:
                    case Keys.D:

                        _KeyRight = true;
                        break;

                    case Keys.A:

                        _KeyLeft = true;
                        break;

                    case Keys.Left:
                        _KeyLeft = true;
                        break;
                    case Keys.P:
                        pause = !pause;
                        break;

                    case Keys.Space:
                        _projektilListe.Add(new Resources.Projektile(false, true, _Player.PosX + 100, _Player.PosY + 33, 5));

                        break;

                }
                _DoMovement();
                //_movementTimer.Start();
            }
            else
            {
                if (destroyed)
                {
                    if (e.KeyCode == Keys.Space&&!gameOver)
                    {
                        invincible = true;
                        destroyed = false;
                        _Player.PosX = 20;
                        _Player.PosY = 300;
                        pause = false;
                        lives--;
                    }
                }
                #region tasteneingabe
                if (gameOver)
                {
                    if ((e.Modifiers == Keys.Shift) && gameOver)
                    {
                        if ((playerName.Length < 3))
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.A:
                                    playerName += "A";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.B:
                                    playerName += "B";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.C:
                                    playerName += "C";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D:
                                    playerName += "D";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.E:
                                    playerName += "E";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.F:
                                    playerName += "F";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.G:
                                    playerName += "G";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.H:
                                    playerName += "H";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.I:
                                    playerName += "I";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.J:
                                    playerName += "J";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.K:
                                    playerName += "K";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.L:
                                    playerName += "L";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.M:
                                    playerName += "M";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.N:
                                    playerName += "N";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.O:
                                    playerName += "O";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.P:
                                    playerName += "P";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Q:
                                    playerName += "Q";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.R:
                                    playerName += "R";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.S:
                                    playerName += "S";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.T:
                                    playerName += "T";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.U:
                                    playerName += "U";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.V:
                                    playerName += "V";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.W:
                                    playerName += "W";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.X:
                                    playerName += "X";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Y:
                                    playerName += "Y";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Z:
                                    playerName += "Z";
                                    labelPlayerName.Text = playerName;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if ((playerName.Length < 3))
                        {
                            switch (e.KeyCode)
                            {
                                case Keys.A:
                                    playerName += "a";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.B:
                                    playerName += "b";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.C:
                                    playerName += "c";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D:
                                    playerName += "d";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.E:
                                    playerName += "e";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.F:
                                    playerName += "f";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.G:
                                    playerName += "g";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.H:
                                    playerName += "h";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.I:
                                    playerName += "i";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.J:
                                    playerName += "j";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.K:
                                    playerName += "k";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.L:
                                    playerName += "l";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.M:
                                    playerName += "m";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.N:
                                    playerName += "n";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.O:
                                    playerName += "o";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.P:
                                    playerName += "p";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Q:
                                    playerName += "q";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.R:
                                    playerName += "r";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.S:
                                    playerName += "s";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.T:
                                    playerName += "t";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.U:
                                    playerName += "u";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.V:
                                    playerName += "v";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.W:
                                    playerName += "w";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.X:
                                    playerName += "x";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Y:
                                    playerName += "y";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.Z:
                                    playerName += "z";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D0:
                                    playerName += "0";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D1:
                                    playerName += "1";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D2:
                                    playerName += "2";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D3:
                                    playerName += "3";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D4:
                                    playerName += "4";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D5:
                                    playerName += "5";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D6:
                                    playerName += "6";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D7:
                                    playerName += "7";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D8:
                                    playerName += "8";
                                    labelPlayerName.Text = playerName;
                                    break;
                                case Keys.D9:
                                    playerName += "9";
                                    labelPlayerName.Text = playerName;
                                    break;
                            }
                        }
                        if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && (playerName.Length > 0))
                        {
                            playerName = playerName.Remove(playerName.Length - 1);
                            labelPlayerName.Text = playerName;
                        }
                    }
                }
                #endregion tasteneingabe
                if (nextLevel)
                {
                    if(e.KeyCode==Keys.Space)
                    {
                        level.NextLevel(m_renderTarget);
                        
                        nextLevel = false;
                        pause = false;
                        FinalScoreLabel.Visible = false;
                    }
                }
                if (e.KeyCode == Keys.P)
                {
                    labelHighScores.Visible = false;
                    labelText1.Visible = false;
                    labelText2.Visible = false;
                    labelPlayerName.Visible = false;
                    labelFinalScore.Visible = false;
                    applyScore.Visible = false;
                    groupSubmitScore.Visible = false;
                    groupBestOfTen.Visible = false;
                    pause = false;
                }

                _DoMovement();
                //_movementTimer.Start();
            }


        }
        //Zeichnet alle Objekte
        protected override void OnPaint(PaintEventArgs e)
        {

            label1.Text = "Leben:" + lives;
            labelScore.Text = "Score:" + score;
            base.OnPaint(e);
            if (m_initialized)
            {
                m_renderTarget.BeginDraw();
                try
                {
                    m_renderTarget.Clear(new Color4(this.BackColor));

                    //Perform all Direct2D rendering here
                    m_renderTarget.FillRectangle(
                        m_backBrushEx,
                        new Rectangle(new Point(), this.Size));

                    //Apply quality
                    D2D.InterpolationMode interpolationMode = D2D.InterpolationMode.NearestNeighbor;
                    interpolationMode = D2D.InterpolationMode.Linear;

                    //Draw all images

                    if (gameOver||nextLevel)
                    {
                        
                        m_renderTarget.DrawBitmap(level.Background, new Rectangle(0, 0, this.Width, this.Height), 1f, interpolationMode);
                    }
                    else
                    {
                
                        m_renderTarget.DrawBitmap(level.Background, new Rectangle(level.LevelPositionX, 0, 8352, 5300), 1f, interpolationMode);
                    }
                    

                    foreach (Resources.EnemyShip ships in level.EnemyShipList)
                    {
                        if (ships.Destroyed == false)
                        {
                        
                            m_renderTarget.DrawBitmap(enenyShipBitmap, new Rectangle(ships.PosX, ships.PosY, ships.ShipHitboxX, ships.ShipHitboxY), 1f, interpolationMode);
                        }
                    }

                    foreach (Resources.LevelObject levelObject in level.ObjectList)
                    {
                       
                        m_renderTarget.DrawBitmap(levelObject.ObjectBitmap, new Rectangle(levelObject.PosX, levelObject.PosY, levelObject.RectangleBreite, levelObject.RectangleHoehe), 1f, interpolationMode);
                        if ((IntersectPixels(new Rectangle(_Player.PosX, _Player.PosY, _Player.ShipHitboxX, _Player.ShipHitboxY), spaceshipBitmapGDI, new Rectangle(levelObject.PosX, levelObject.PosY, levelObject.RectangleBreite, levelObject.RectangleHoehe), levelObject.ObjectBitmapGDI))&&(!invincible))
                        {
                            destroyed = true;
                        }
                    }

                    for (int i = _projektilListe.Count - 1; i >= 0; i--)
                    {
                        {
                            if ((_projektilListe[i].Visible == true) && (_projektilListe[i].PosX < this.Width) && (_projektilListe[i].PosX > 0)&&(!gameOver))
                            {
                                if (_projektilListe[i].Hostile)
                                {
                                    m_renderTarget.DrawBitmap(projektileHostileBitmap, new Rectangle(_projektilListe[i].PosX, _projektilListe[i].PosY, 30, 5), 1f, interpolationMode);
                                }
                                else
                                {
                                    m_renderTarget.DrawBitmap(projektileBitmap, new Rectangle(_projektilListe[i].PosX, _projektilListe[i].PosY, 30, 5), 1f, interpolationMode);
                                }
                            }
                        }

                    }
                    if (destroyed)
                    {
                        if (lives > 0)
                        {
                            D2D.Bitmap continueScreen = LoadBitmap(continueScreenGDI);
                            pause = true;
                            m_renderTarget.DrawBitmap(continueScreen, new Rectangle(10, 200, 1052, 222), 1f, interpolationMode);
                        }
                        else
                        {
                            gameOver = true;
                            level.LoadLevelGameOver();
                            level.Background = LoadBitmap(level.Backgroundgdi);
                            FinalScoreLabel.Visible = false;
                            FinalScoreLabel.Text = "Score: " + score;                     
                            pause =true;
                            if (!groupBestOfTen.Visible)
                            {

                                labelHighScores.Text = VanguardsHighScore.EinträgeAnzeigenPunkte("Flappy_Bird");
                                labelHighScores.Visible = true;
                                labelText1.Visible = true;
                                labelText2.Visible = true;
                                labelPlayerName.Visible = true;
                                labelFinalScore.Visible = true;
                                applyScore.Visible = true;
                                labelScore.Visible = false;
                                labelFinalScore.Text = score.ToString();
                                groupSubmitScore.Visible = true;
                            }

                        }
                    }
                    else if(nextLevel)
                    {
                        level.LoadLevelNextLevel();
                        level.Background = LoadBitmap(level.Backgroundgdi);
                        FinalScoreLabel.Visible = true;
                        FinalScoreLabel.Text = "Score: " + score;
                        pause = true;
                    }
                    else 
                    {
                        m_renderTarget.DrawBitmap(_Player.getShipBitmap(), new Rectangle(_Player.PosX, _Player.PosY, _Player.ShipHitboxX, _Player.ShipHitboxY), 1f, interpolationMode);

                    }


                }
                finally
                {
                    m_renderTarget.EndDraw();
                }

            }

        }


        //Is debug mode enabled?
        public bool IsDebugEnabled
        {
            get { return m_debugMode; }
            set { m_debugMode = value; }
        }
        //Event für highscorebutton in der Menüleiste
        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBestOfTen.Visible == false)
            {
                VanguardsHighScore = new Highscore();
                labelHighScores.Text = VanguardsHighScore.EinträgeAnzeigenPunkte("Vanguards");
                labelHighScores.Visible = true;
                groupBestOfTen.Visible = true;
                pause = true;
            }
            else
            {

                labelHighScores.Visible = false;
                groupBestOfTen.Visible = false;
                pause = false;

            }
        }
        //Übernimmt den Highscore
        private void applyScore_Click(object sender, EventArgs e)
        {
            labelWarnTextLenght.Visible = false;
            if ((playerName.Length == 3) && pause)
            {
                groupSubmitScore.Visible = false;
                groupBestOfTen.Visible = true;

                labelText1.Visible = false;
                labelText2.Visible = false;
                labelPlayerName.Visible = false;
                labelFinalScore.Visible = false;
                applyScore.Visible = false;
                groupSubmitScore.Visible = false;
                groupBestOfTen.Visible = true;
                VanguardsHighScore = new Highscore();
                labelHighScores.Text = VanguardsHighScore.HighscoreEintragen("Vanguards", playerName, score.ToString());
            }
            else if (playerName.Length != 3)
            {
                labelWarnTextLenght.Visible = true;
            }
        }
        //Pausiert das spiel
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!gameOver)
            {
                pause = !pause;
            }
        }
        //macht ein neues spiel
        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _projektilListe = null;
            _projektilListe = new List<Resources.Projektile>();
            score = 0;
            lives = 3;
            _Player.PosX = 20;
            _Player.PosY = 300;
            level.LoadLevel1(m_renderTarget);

        }
        //beendet das spiel
        private void zumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Menue.spielGestartet = false;
            this.Close();
        }
      
        private void Vanguards_Load(object sender, EventArgs e)
        {

        }
        //wen das spiel geschlossen wird wird die variable zurückgesezt damit andere spiele gestartet werden können
        private void Vanguards_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Menue.spielGestartet = false;
        }
        //schließt die hilfe
        private void helpGetButton_Click(object sender, EventArgs e)
        {
            pause = false;
            groupHelp.Visible = false;
            firstTimeStarted = false;
        }
        //ruft die hilfe auf
        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(groupHelp.Visible==true)
            {
                pause = false;
                groupHelp.Visible = false;
            }
            else
            {
                pause = true;
                groupHelp.Visible = true;
            }
        }
    }
}
