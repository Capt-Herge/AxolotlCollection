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
using SlimDX.XAudio2;
using System.Timers;

namespace Spielesammlung.Vanguards.Resources
{
    class Level
    {
        private D2D.Bitmap background;
        private Bitmap backgroundgdi;
        private D2D.Bitmap backgroundlvl1;
        private D2D.Bitmap backgroundlvl2;
        private D2D.Bitmap backgroundlvl3;
        private D2D.Bitmap backgroundGameOver;
        private D2D.Bitmap backgroundNextLevel;
        private int levelPositionX;
        private int currentLevel;
        private List<LevelObject> _objectList = new List<LevelObject>();
        private List<EnemyShip> _enemyShipList = new List<EnemyShip>();
        private int scoreCount = 0;

        public D2D.Bitmap Background
        {
            get
            {
                return background;
            }

            set
            {
                background = value;
            }
        }

        public Bitmap Backgroundgdi
        {
            get
            {
                return backgroundgdi;
            }

            set
            {
                backgroundgdi = value;
            }
        }

        public D2D.Bitmap Backgroundlvl1
        {
            get
            {
                return backgroundlvl1;
            }

            set
            {
                backgroundlvl1 = value;
            }
        }

        public D2D.Bitmap Backgroundlvl2
        {
            get
            {
                return backgroundlvl2;
            }

            set
            {
                backgroundlvl2 = value;
            }
        }

        public D2D.Bitmap Backgroundlvl3
        {
            get
            {
                return backgroundlvl3;
            }

            set
            {
                backgroundlvl3 = value;
            }
        }

        public D2D.Bitmap BackgroundGameOver
        {
            get
            {
                return backgroundGameOver;
            }

            set
            {
                backgroundGameOver = value;
            }
        }

        public D2D.Bitmap BackgroundNextLevel
        {
            get
            {
                return backgroundNextLevel;
            }

            set
            {
                backgroundNextLevel = value;
            }
        }

        public int LevelPositionX
        {
            get
            {
                return levelPositionX;
            }

            set
            {
                levelPositionX = value;
            }
        }

        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }

            set
            {
                currentLevel = value;
            }
        }

        internal List<LevelObject> ObjectList
        {
            get
            {
                return _objectList;
            }

            set
            {
                _objectList = value;
            }
        }

        internal List<EnemyShip> EnemyShipList
        {
            get
            {
                return _enemyShipList;
            }

            set
            {
                _enemyShipList = value;
            }
        }

        public int ScoreCount
        {
            get
            {
                return scoreCount;
            }

            set
            {
                scoreCount = value;
            }
        }

        public Level()
        {
            LevelPositionX = 0;
           
        }
        public void LoadLevel1(D2D.WindowRenderTarget renderTarget)
        {
            LevelPositionX = 0;
            CurrentLevel = 1;
            //Objects
            Background = Backgroundlvl1;
            ObjectList.Add(new LevelObject(400, 400, LoadBitmap(Resources.a10010,renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(1200, 200, LoadBitmap(Resources.a10012, renderTarget),150, 200));
            ObjectList.Add(new LevelObject(1500, 550, LoadBitmap(Resources.a10010, renderTarget), 100, 120));
            ObjectList.Add(new LevelObject(2000, 420, LoadBitmap(Resources.a10015, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(2500, 300, LoadBitmap(Resources.a10012, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(3000, 400, LoadBitmap(Resources.a10010, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(3400, 200, LoadBitmap(Resources.a10012, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(3900, 550, LoadBitmap(Resources.a10010, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(4400, 420, LoadBitmap(Resources.a10015, renderTarget), 150, 150));
            ObjectList.Add(new LevelObject(5500, 300, LoadBitmap(Resources.a10012, renderTarget), 150, 150));

            //enemies
            EnemyShipList.Add(new EnemyShip(1500, 400));
            EnemyShipList.Add(new EnemyShip(2000, 100));
            EnemyShipList.Add(new EnemyShip(2700, 350));
            EnemyShipList.Add(new EnemyShip(3500, 150));
            EnemyShipList.Add(new EnemyShip(4800, 550));
            EnemyShipList.Add(new EnemyShip(5500, 300));
            EnemyShipList.Add(new EnemyShip(6000, 500));
            EnemyShipList.Add(new EnemyShip(7000, 200));

        }

        public void LoadLevel2(D2D.WindowRenderTarget renderTarget)
        {
            LevelPositionX = 0;
            Background = Backgroundlvl2;
            CurrentLevel = 2;
            //Objects
            Backgroundgdi = Resources.SpaceBackground1;
            
            ObjectList.Add(new LevelObject(1, 1, LoadBitmap(Resources.a10012, renderTarget), 20, 6000));
            ObjectList.Add(new LevelObject(1, 740, LoadBitmap(Resources.a10012, renderTarget), 30, 6000));

            //enemies
            EnemyShipList.Add(new EnemyShip(1500, 400));
            EnemyShipList.Add(new EnemyShip(2000, 100));
            EnemyShipList.Add(new EnemyShip(2150, 500));
            EnemyShipList.Add(new EnemyShip(2300, 450));
            EnemyShipList.Add(new EnemyShip(2400, 400));
            EnemyShipList.Add(new EnemyShip(2550, 600));
            EnemyShipList.Add(new EnemyShip(2700, 350));
            EnemyShipList.Add(new EnemyShip(3500, 150));
            EnemyShipList.Add(new EnemyShip(3660, 550));
            EnemyShipList.Add(new EnemyShip(3800, 350));
            EnemyShipList.Add(new EnemyShip(3900, 450));
            EnemyShipList.Add(new EnemyShip(4800, 550));
            EnemyShipList.Add(new EnemyShip(4950, 200));
            EnemyShipList.Add(new EnemyShip(5200, 450));
            EnemyShipList.Add(new EnemyShip(5300, 400));
            EnemyShipList.Add(new EnemyShip(5500, 239));
            EnemyShipList.Add(new EnemyShip(5650, 600));
            EnemyShipList.Add(new EnemyShip(5790, 400));
            EnemyShipList.Add(new EnemyShip(6000, 100));
            EnemyShipList.Add(new EnemyShip(6150, 400));
            EnemyShipList.Add(new EnemyShip(6230, 600));
            EnemyShipList.Add(new EnemyShip(6400, 300));
            EnemyShipList.Add(new EnemyShip(6520, 400));
            EnemyShipList.Add(new EnemyShip(6650, 200));
            EnemyShipList.Add(new EnemyShip(6800, 600));
            EnemyShipList.Add(new EnemyShip(7000, 499));
            EnemyShipList.Add(new EnemyShip(7200, 240));
            EnemyShipList.Add(new EnemyShip(7340, 520));
            EnemyShipList.Add(new EnemyShip(7420, 140));
            EnemyShipList.Add(new EnemyShip(7600, 640));
            EnemyShipList.Add(new EnemyShip(7700, 520));
            EnemyShipList.Add(new EnemyShip(7850, 380));
            EnemyShipList.Add(new EnemyShip(7980, 190));
            EnemyShipList.Add(new EnemyShip(8300, 400));
            EnemyShipList.Add(new EnemyShip(6460, 590));
            EnemyShipList.Add(new EnemyShip(8690, 240));


        }
        public D2D.Bitmap LoadBitmap(Bitmap drawingBitmap, D2D.WindowRenderTarget m_renderTarget)
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
        public void LoadLevelGameOver()
        {
            Backgroundgdi = Resources.GameOver;
            EnemyShipList=null;
            EnemyShipList = new List<EnemyShip>();
            ObjectList = null;
            ObjectList = new List<LevelObject>();
        }
        public void LoadLevelNextLevel()
        {
            Backgroundgdi = Resources.NextLevel;
            EnemyShipList = null;
            EnemyShipList = new List<EnemyShip>();
            ObjectList = null;
            ObjectList = new List<LevelObject>();
        }
        public void NextLevel(D2D.WindowRenderTarget renderTarget)
        {
            if(CurrentLevel==1)
            {
                EnemyShipList = null;
                EnemyShipList = new List<EnemyShip>();
                ObjectList = null;
                ObjectList = new List<LevelObject>();
                LoadLevel2(renderTarget);
            }else if(CurrentLevel==2)
            {
                EnemyShipList = null;
                EnemyShipList = new List<EnemyShip>();
                ObjectList = null;
                ObjectList = new List<LevelObject>();
                LoadLevel1(renderTarget);
            }
        }


    }
}
