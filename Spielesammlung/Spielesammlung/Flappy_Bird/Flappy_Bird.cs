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
using SlimDX.DirectWrite;

namespace Spielesammlung.Flappy_Bird
{
    public partial class Flappy_Bird : Form
    {
        #region variablen
        //Visual Ressources
        private D2D.Factory m_factory;
        //private SlimDX.DirectWrite.Factory m_factoryText;
        private D2D.WindowRenderTarget m_renderTarget;
        private D2D.LinearGradientBrush m_backBrushEx;
        private D2D.GradientStopCollection m_backBrushGradient;
        private Brush m_backBrushGdi;
        private bool m_initialized;
        private bool m_debugMode;
        private System.Timers.Timer movementTicker = new System.Timers.Timer();
        private System.Timers.Timer jumpTicker = new System.Timers.Timer();
        private System.Timers.Timer altitudeTicker = new System.Timers.Timer();
        private List<Resources.Pipe_Pair> pipePairList = new List<Resources.Pipe_Pair>();
        private List<Resources.Ground> groundList = new List<Resources.Ground>();
        private D2D.Bitmap backGroundBitmap;
        private D2D.Bitmap groundBitmap;
        private D2D.Bitmap pipeLowerBitmap;
        private D2D.Bitmap pipeUperBitmap;
        private D2D.Bitmap birdBitmap;
        private int altitudeValue=0;
        private bool pause=true;
        private bool gameOver = false;
        private bool hold = false;
        private Resources.Bird player;
        private int score = 0;
        Highscore flappyBirdHighScore = new Highscore();
        private string playerName="";
        private bool firstTimeStarted=true;
        #endregion

        public Flappy_Bird()
        {
            InitializeComponent();
            //Update control styles
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            m_backBrushGdi = new SolidBrush(this.BackColor);

            InitializeGraphics();
            movementTicker.Elapsed += new ElapsedEventHandler(Tick);
            movementTicker.Interval = 1;
            movementTicker.Enabled = true;
            jumpTicker.Elapsed += new ElapsedEventHandler(JumpTicker);
            jumpTicker.Interval = 35;
            jumpTicker.Enabled = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Flappy_Bird_KeyDown);
            this.KeyUp += new KeyEventHandler(Flappy_Bird_KeyUp);
            CreateLevel();
            player = new Resources.Bird(300);
            if(firstTimeStarted)
            {
                groupHelp.Visible = true;

            }
        }
        //erstellt das Level 
        private void CreateLevel()
        {
            Random rnd = new Random();
            
            for (int i=0;i<600;i++)
            {
                groundList.Add(new Resources.Ground(i*720));
            }
            for(int i=0;i<1000;i++)
            {
                pipePairList.Add(new Resources.Pipe_Pair((i * 364)+ 1060,rnd.Next(-600, -238)));  //1060
            }
        }
        //erstellt neue Hindernisse
        private void AddPipes()
        {
            Random rnd = new Random();

            for (int i = 0; i < 12; i++)
            {
                groundList.Add(new Resources.Ground((i * 720) + groundList.Last().GroundPosX1+720));
            }
            for (int i = 0; i < 20; i++)
            {
                pipePairList.Add(new Resources.Pipe_Pair((i * 364) + 1060+pipePairList.Last().PipePairPosx, rnd.Next(-600, -238)));  //1060
            }
        }
        //Timer für den spielablauf
        private void Tick(Object source, EventArgs e)
        {
              if(!pause)
            {
                foreach(Resources.Ground ground in groundList)
                {
                    ground.GroundPosX1 -= 4;
                }
                foreach (Resources.Pipe_Pair pipes in pipePairList)
                {
                    pipes.PipePairPosx -= 4;
                }
                if (player.BirdPosy >= -1)
                {
                    player.BirdPosy += altitudeValue;
                    if (player.BirdPosy <= 0) player.BirdPosy = 1;
                }
                if (groundList.Last().GroundPosX1 <= 4000)
                {
                    AddPipes();
                }
            }
            this.Invalidate();
        }
        //Sezt die variable für das halten der leertaste zurück
        private void Flappy_Bird_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                hold = false;
            }
        }

 
        //Reagiert auf tasteneingaben
        private void Flappy_Bird_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if(!pause&&!hold)
            {
                if (e.KeyCode == Keys.Space) 
                {
                    if (!hold)
                    {
                        altitudeValue = -8;
                        hold = true;
                    }
                }
            }
            else if(pause)
            {
                if ((e.KeyCode == Keys.Space )&&gameOver)
                {
                    groundList = null;
                    pipePairList = null;
                    pipePairList = new List<Resources.Pipe_Pair>();
                    groundList = new List<Resources.Ground>();
                    CreateLevel();
                    score = 0;
                    altitudeValue = -8;
                    player.BirdPosy = 300;
                    labelHighScores.Visible = false;
                    labelText1.Visible = false;
                    labelText2.Visible = false;
                    labelPlayerName.Visible = false;
                    labelFinalScore.Visible = false;
                    applyScore.Visible = false;
                    groupSubmitScore.Visible = false;
                    groupBestOfTen.Visible = false;
                    Score.Visible = true;
                    pause = false;
                    gameOver = false;
                }
                if ((e.KeyCode == Keys.Space))
                {

                    altitudeValue = -8;
                    labelHighScores.Visible = false;
                    labelText1.Visible = false;
                    labelText2.Visible = false;
                    labelPlayerName.Visible = false;
                    labelFinalScore.Visible = false;
                    applyScore.Visible = false;
                    groupSubmitScore.Visible = false;
                    groupBestOfTen.Visible = false;
                    Score.Visible = true;
                    pause = false;
                    gameOver = false;
                }
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

        }
        //Timer für die sprungphysik
        private void JumpTicker(Object source, EventArgs e)
        {
            if (!pause)
            {
                if (altitudeValue <= 15)
                {
                    altitudeValue++;
                }
            }
            Highscore flappyBirdHighScore = new Highscore();

            
        }
        
        //Ladet alle graphicken
        private void InitializeGraphics()
        {
            //Get requested debug level
            D2D.DebugLevel debugLevel = D2D.DebugLevel.None;
            if (m_debugMode) { debugLevel = D2D.DebugLevel.Error; }

            //Create factory object
            m_factory = new D2D.Factory(D2D.FactoryType.SingleThreaded, debugLevel);
          //  m_factoryText = new SlimDX.DirectWrite.Factory();
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

            backGroundBitmap = LoadBitmap(Resources.Resource.skyline);
            groundBitmap = LoadBitmap(Resources.Resource.ground);
            pipeLowerBitmap = LoadBitmap(Resources.Resource.pipe_up);
            pipeUperBitmap=LoadBitmap(Resources.Resource.pipe_down);
            birdBitmap=LoadBitmap(Resources.Resource.bird_one);
        //Update initialization flag
        m_initialized = true;
        }
        // Entlädt alle graphicken
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
        //Zeichnet alle Graphiken
        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (m_initialized)
            {
                m_renderTarget.BeginDraw();
                try
                {
                    m_renderTarget.Clear(new Color4(this.BackColor));
                    Rectangle birdRecktangle = new Rectangle(player.BirdPosx, player.BirdPosy, 68, 48);
                    SlimDX.Matrix3x2 rotationMatrix = new SlimDX.Matrix3x2();
                    SlimDX.Matrix3x2 standartMatrix = new SlimDX.Matrix3x2();
                    //Perform all Direct2D rendering here
                    m_renderTarget.FillRectangle(
                        m_backBrushEx,
                        new Rectangle(new Point(), this.Size));

                    //Apply quality
                    D2D.InterpolationMode interpolationMode = D2D.InterpolationMode.NearestNeighbor;
                    interpolationMode = D2D.InterpolationMode.Linear;

                    //Draw all images
                     m_renderTarget.DrawBitmap(backGroundBitmap, new Rectangle(0, 0, 1276, 720), 1f, interpolationMode);
                    foreach (Resources.Pipe_Pair pipes in pipePairList)
                    {
                        Rectangle upperRectangle = new Rectangle(pipes.PipePairPosx, pipes.PipePairPosy, 104, 640);
                        Rectangle lowerRectangle = new Rectangle(pipes.PipePairPosx, pipes.PipePairPosy + 640 + 200, 104, 640);
                        m_renderTarget.DrawBitmap(pipeUperBitmap, upperRectangle, 1f, interpolationMode);
                        m_renderTarget.DrawBitmap(pipeLowerBitmap, lowerRectangle, 1f, interpolationMode);
                        if ((player.BirdPosx >= (pipes.PipePairPosx)) &&(pipes.Scored==false))
                        {
                            score += 1;
                            pipes.Scored = true;
                        } 
                        if(upperRectangle.IntersectsWith(birdRecktangle)||lowerRectangle.IntersectsWith(birdRecktangle))
                        {
                            pause = true;
                            gameOver = true;
                            if (!groupBestOfTen.Visible)
                            {
                                labelHighScores.Visible = true;
                                labelText1.Visible = true;
                                labelText2.Visible = true;
                                labelPlayerName.Visible = true;
                                labelFinalScore.Visible = true;
                                applyScore.Visible = true;
                                Score.Visible = false;
                                labelFinalScore.Text = score.ToString();
                                groupSubmitScore.Visible = true;
                            }
                        }
                    }
                    foreach (Resources.Ground ground in groundList)
                    {
                        Rectangle groundRectangle = new Rectangle(ground.GroundPosX1, this.Height - 120, 720, 120);
                        m_renderTarget.DrawBitmap(groundBitmap, groundRectangle, 1f, interpolationMode);
                        if(groundRectangle.IntersectsWith(birdRecktangle))
                        {
                            if (!groupBestOfTen.Visible)
                            {
                                
                                labelHighScores.Text = flappyBirdHighScore.EinträgeAnzeigenPunkte("Flappybird");
                                labelHighScores.Visible = true;
                                labelText1.Visible = true;
                                labelText2.Visible = true;
                                labelPlayerName.Visible = true;
                                labelFinalScore.Visible = true;
                                applyScore.Visible = true;
                                Score.Visible = false;
                                labelFinalScore.Text = score.ToString();
                                pause = true;
                                gameOver = true;
                                groupSubmitScore.Visible = true;
                            }
                        }
                    }
                    
                    PointF rotationPoint = new PointF(player.BirdPosx+ (birdRecktangle.Width / 2), player.BirdPosy + (birdRecktangle.Height / 2));
                     rotationMatrix = Matrix3x2.Rotation(altitudeValue*6, rotationPoint);
                    m_renderTarget.Transform = rotationMatrix;

                

                    
                    m_renderTarget.DrawBitmap(birdBitmap, birdRecktangle, 1f, interpolationMode);
                    Matrix3x2.Translation(0, 0,out rotationMatrix);
                    
                    
                    rotationMatrix = Matrix3x2.Rotation(0);
                    m_renderTarget.Transform =rotationMatrix;
                    Score.Parent = this;
                    Score.Text = score.ToString();
                }
                finally
                {
                        m_renderTarget.EndDraw();
                }

            }

        }
        //Schaut nach ob zwei objekte sich überlappen
        static bool IntersectPixels(Rectangle rectangleA, Bitmap bmpA,
                     Rectangle rectangleB, Bitmap bmpB)
        {
            return rectangleA.IntersectsWith(rectangleB);

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

        //gibt den debug mode an
        public bool IsDebugEnabled
        {
            get { return m_debugMode; }
            set { m_debugMode = value; }
        }

        private void asdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void finalScore_Click(object sender, EventArgs e)
        {

        }
        //speichert den Highscore
        private void applyScore_Click(object sender, EventArgs e)
        {
            labelWarnTextLenght.Visible = false;
            if ((playerName.Length==3)&&pause)
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
                flappyBirdHighScore = new Highscore();
                labelHighScores.Text= flappyBirdHighScore.HighscoreEintragen("Flappybird", playerName, score.ToString());
            }
            else if(playerName.Length!=3)
            {
                labelWarnTextLenght.Visible = true;
            }
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Zeigt den highscore an
        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flappyBirdHighScore = new Highscore();
            labelHighScores.Text = flappyBirdHighScore.EinträgeAnzeigenPunkte("Flappybird");
            labelHighScores.Visible = true;
            labelText1.Visible = false;
            labelText2.Visible = false;
            labelPlayerName.Visible = false;
            labelFinalScore.Visible = false;
            applyScore.Visible = false;
            groupSubmitScore.Visible = false;
            groupBestOfTen.Visible = true;
            Score.Visible = true;
            pause = true;
            gameOver = false;
        }
        //beendet das spiel
        private void zumHauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Menue.spielGestartet = false;
            this.Close();
        }
        //sezt die variable zurück damit andere spiele gestartet werden können
        private void Flappy_Bird_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Menue.spielGestartet = false;
        }
        //schließt die hilfe
        private void helpGetButton_Click(object sender, EventArgs e)
        {
            if (firstTimeStarted)
            {
                firstTimeStarted = false;
                groupHelp.Visible = false;
            }
            else
            {
                groupHelp.Visible = false;
                pause = false;
            }
        }
        //ruft hilfe auf
        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(groupHelp.Visible==true)
            {
                groupHelp.Visible = false;
                pause = false;
            }
            else
            {
                groupHelp.Visible = true;
                pause = true;
            }
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {

        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {

        }
    }
}
