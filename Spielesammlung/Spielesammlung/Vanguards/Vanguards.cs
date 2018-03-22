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
        public Vanguards()
        {
            InitializeComponent();
            keys_down = new bool[4];
            key_props = new[] { Keys.A, Keys.D, Keys.W, Keys.S };
            //Update control styles
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //Update back brush
            m_backBrushGdi = new SolidBrush(this.BackColor);

            InitializeGraphics();
            _enemyFireTimer.Tick += EnemyFireTick;
            _enemyFireTimer.Start();
            level.LoadLevel2(m_renderTarget);
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
        }

        static bool IntersectPixels(Rectangle rectangleA, Bitmap bmpA,
                            Rectangle rectangleB, Bitmap bmpB)
        {
            
            return rectangleA.IntersectsWith(rectangleB);

        }

        private void tick(Object source, EventArgs e)
        {

            // Do this every timing interval.
            if (!pause)
            {
                _DoMovement();


            }


        }
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

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            _DoMovement();
            this.Invalidate();
        }

        private void _DoMovement()
        {
            if (_KeyDown&&((_Player.PosY+_Player.ShipHitboxY)<this.Height)) { _Player.PosY = _Player.PosY + 3; }
            if (_KeyUp&&_Player.PosY>0) { _Player.PosY = _Player.PosY - 3; }
            if (_KeyLeft&&_Player.PosX>0) { _Player.PosX = _Player.PosX - 3; }
            if (_KeyRight&& ((_Player.PosX + _Player.ShipHitboxX) < this.Width)) { _Player.PosX = _Player.PosX + 3; }

            this.Invalidate();
        }

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

        // Loads a Direct2D bitmap from the given file.
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


        // Load a Direct2D bitmap from the given gdi resource.
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


        // Loads all graphics resources.
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

        /// <summary>
        /// Called when window closes.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            if (m_initialized)
            {
                UnloadGraphics();
            }
        }

        /// <summary>
        /// Called when background color has changed.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            //Update back brush
            if (m_backBrushGdi != null) { m_backBrushGdi.Dispose(); }
            m_backBrushGdi = new SolidBrush(this.BackColor);
        }

        /// <summary>
        /// Called when user changes a parameter.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnChkParameterCheckedChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

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
                if(nextLevel)
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
                    pause = false;
                }

                _DoMovement();
                //_movementTimer.Start();
            }


        }

        private void ShipDown()
        {
            _Player.PosY = _Player.PosY + 1;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            label1.Text = "Leben:" + lives;
            label2.Text = "Score:" + score;
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
                            FinalScoreLabel.Visible = true;
                            FinalScoreLabel.Text = "Score: " + score;
                            pause =true;
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

        /// <summary>
        /// Is debug mode enabled?
        /// </summary>
        [Category("Direct2D")]
        public bool IsDebugEnabled
        {
            get { return m_debugMode; }
            set { m_debugMode = value; }
        }

    }
}
