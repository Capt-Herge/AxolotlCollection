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

//Some namespace mappings
using D2D = SlimDX.Direct2D;
using DXGI = SlimDX.DXGI;
using System.Threading;
using System.Windows.Input;

namespace Spielesammlung.Vanguards
{
    public partial class Vanguards : Form
    {
        //Resources for Direct2D rendering
        private D2D.Factory m_factory;
        private D2D.WindowRenderTarget m_renderTarget;
        private D2D.LinearGradientBrush m_backBrushEx;
        private D2D.GradientStopCollection m_backBrushGradient;
        private D2D.Bitmap m_puzzleBitmap;
        private D2D.Bitmap spaceShipBitmap;
        //Some generic members
        private Bitmap m_puzzleBitmapGdi;
        private Bitmap spaceshipBitmapGDI;
        private Brush m_backBrushGdi;
        private bool m_initialized;
        private bool m_debugMode;
        private PlayerShip _Player;
        private Thread _PlayerControll;
        private bool _KeyPressed = false ;
        private String _Taste;
        private System.Windows.Forms.Timer _movementTimer = new System.Windows.Forms.Timer { Interval = 15 };

        private static bool[] keys_down;
        private static Keys[] key_props;
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
            _movementTimer.Tick += tick;
            _movementTimer.Start();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Vanguards_KeyDown);
            this.KeyUp += new KeyEventHandler(Vanguards_KeyUp);

        }

        private void tick(Object source, EventArgs e)
        {
            // Do this every timing interval.
            _DoMovement();
            byte n = 0;
            foreach (var v in keys_down)
            {
                if (n == 3 && v)
                // If the "s" key is being held down, no key delay issues. :)
            n++;
            }
        
    }

        private void movementTimer_Tick(object sender, EventArgs e)
        {
            _DoMovement();
        }

        private void _DoMovement()
        {
            if (_KeyPressed)
            {
                _Player.PosY = _Player.PosY+1;
                this.Invalidate();

            }

            

        }

        private void Vanguards_KeyUp(object sender, KeyEventArgs e)
        {

            _KeyPressed = false;
            _movementTimer.Stop();
            
        }

        /// <summary>
        /// Loads a Direct2D bitmap from the given file.
        /// </summary>
        /// <param name="file">Source file name.</param>
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

        /// <summary>
        /// Load a Direct2D bitmap from the given gdi resource.
        /// </summary>
        /// <param name="drawingBitmap">The gdi resource.</param>
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

        /// <summary>
        /// Loads all graphics resources.
        /// </summary>
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
                new D2D.GradientStop(){ Position = 1f, Color = new Color4(Color.LightSteelBlue) }
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
            m_puzzleBitmapGdi = Properties.Resources.Puzzle;
            m_puzzleBitmap = LoadBitmap(m_puzzleBitmapGdi);
            spaceshipBitmapGDI = Properties.Resources.GreenSpaceShip;
            spaceShipBitmap = LoadBitmap(spaceshipBitmapGDI);
            _Player = new PlayerShip(spaceShipBitmap);
            

            //Update initialization flag
            m_initialized = true;
        }

        private void UnloadGraphics()
        {
            if (m_puzzleBitmap != null) { m_puzzleBitmap.Dispose(); }
            if (m_backBrushEx != null) { m_backBrushEx.Dispose(); }
            if (m_backBrushGradient != null) { m_backBrushGradient.Dispose(); }
            if (m_renderTarget != null) { m_renderTarget.Dispose(); }
            if (m_factory != null) { m_factory.Dispose(); }

            m_backBrushEx = null;
            m_backBrushGradient = null;
            m_renderTarget = null;
            m_factory = null;
        }

        /// <summary>
        /// Called when window opens.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
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


                switch (e.KeyCode)
            {
              case Keys.S:

                    //    _Player.PosY=_Player.PosY+1;
                    //     this.Invalidate();
                    _KeyPressed = true;
                    //_PlayerControll = new Thread(ShipDown);
                    //_PlayerControll.Start();
                    
              break;

                case Keys.Down:
                    _Player.PosY = _Player.PosY + 1;
                    this.Invalidate();
              break;
                case Keys.W:

                    _Player.PosY = _Player.PosY - 1;
                    this.Invalidate();
                    break;

                case Keys.Up:
                    _Player.PosY = _Player.PosY - 1;
                    this.Invalidate();
                    break;
                case Keys.D:
                    _KeyPressed = true;
                    _Player.PosX = _Player.PosX + 1;
                    this.Invalidate();
                    break;

                case Keys.A:

                    _Player.PosY = _Player.PosX - 1;
                    this.Invalidate();
                    break;

                case Keys.Left:
                    _Player.PosY = _Player.PosX - 1;
                    this.Invalidate();
                    break;

            }
            _DoMovement();
            _movementTimer.Start();
        }
        
        private void ShipDown()
        {
            
            _Player.PosY = _Player.PosY + 1;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if(m_initialized)
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
                    int imageCount = 0;
 
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    m_renderTarget.DrawBitmap(m_puzzleBitmap);
                    m_renderTarget.DrawBitmap(_Player.getShipBitmap(), new RectangleF(_Player.PosX, _Player.PosY, _Player.ShipHitboxX, _Player.ShipHitboxY), 1f, interpolationMode);
                    stopwatch.Stop();

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
