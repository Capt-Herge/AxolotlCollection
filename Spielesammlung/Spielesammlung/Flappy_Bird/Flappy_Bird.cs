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
        private int altitudeValue=-8;
        private bool pause=true;
        private bool hold = false;
        private Resources.Bird player;
        private int score = 0;
        
        public Flappy_Bird()
        {
            InitializeComponent();
            //Update control styles
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            //Update back brush
            m_backBrushGdi = new SolidBrush(this.BackColor);

            InitializeGraphics();
            movementTicker.Elapsed += new ElapsedEventHandler(Tick);
            movementTicker.Interval = 1;
            movementTicker.Enabled = true;
            jumpTicker.Elapsed += new ElapsedEventHandler(JumpTicker);
            jumpTicker.Interval = 30;
            jumpTicker.Enabled = true;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Flappy_Bird_KeyDown);
            this.KeyUp += new KeyEventHandler(Flappy_Bird_KeyUp);
            CreateLevel();
            player = new Resources.Bird(300);
        }

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

        private void Flappy_Bird_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                hold = false;
            }
        }

        

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
                if (e.KeyCode == Keys.Space)
                {
                    groundList = null;
                    pipePairList = null;
                    pipePairList = new List<Resources.Pipe_Pair>();
                    groundList = new List<Resources.Ground>();
                    CreateLevel();
                    score = 0;
                    altitudeValue = -15;
                    player.BirdPosy = 300;
                    pause = false;
                }
            }

        }

        private void JumpTicker(Object source, EventArgs e)
        {
            if(altitudeValue<=12)
            {
                altitudeValue++;
            }
        }


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


        /// Called when background color has changed.
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

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            if (m_initialized)
            {
                m_renderTarget.BeginDraw();
                try
                {
                    m_renderTarget.Clear(new Color4(this.BackColor));
                    Rectangle birdRecktangle = new Rectangle(240, player.BirdPosy, 68, 48);
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
                        if ((player.BirdPosx >= (pipes.PipePairPosx-300)) &&(pipes.Scored==false))
                        {
                            score += 1;
                            pipes.Scored = true;
                        } 
                        if(upperRectangle.IntersectsWith(birdRecktangle)||lowerRectangle.IntersectsWith(birdRecktangle))
                        {
                            pause = true;
                        }
                    }
                    foreach (Resources.Ground ground in groundList)
                    {
                        Rectangle groundRectangle = new Rectangle(ground.GroundPosX1, this.Height - 120, 720, 120);
                        m_renderTarget.DrawBitmap(groundBitmap, groundRectangle, 1f, interpolationMode);
                        if(groundRectangle.IntersectsWith(birdRecktangle))
                        {
                            pause = true;
                        }
                    }
                    //TextFormat textFormat = new TextFormat(m_factoryText, "Arial", FontWeight.Normal, SlimDX.DirectWrite.FontStyle.Normal, FontStretch.Normal, 46.0f, "en-us");
                     //  m_renderTarget.DrawText(score.ToString(),textFormat, new Rectangle(433, 81, 149, 104),new D2D.Brush());
                  // TextLayout textLayout1 = new TextLayout(m_factoryText, score.ToString(), textFormat, 500, 20);
                    m_renderTarget.DrawBitmap(birdBitmap, birdRecktangle, 1f, interpolationMode);
                    Score.Parent = this;
                    Score.Text = score.ToString();
                }
                finally
                {
                    m_renderTarget.EndDraw();
                }

            }

        }

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













        public bool IsDebugEnabled
        {
            get { return m_debugMode; }
            set { m_debugMode = value; }
        }

    }
}
