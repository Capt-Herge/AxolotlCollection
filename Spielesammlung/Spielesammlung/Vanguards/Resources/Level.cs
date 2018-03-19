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
        public Level()
        {
            LevelPositionX = 0;
        }
        public void LoadLevel1(D2D.WindowRenderTarget renderTarget)
        {
            levelPositionX = 0;
            currentLevel = 1;
            //Objects
            background = backgroundlvl1;
            _objectList.Add(new LevelObject(400, 400, LoadBitmap(Resources.a10010,renderTarget), 150, 150));
            _objectList.Add(new LevelObject(1200, 200, LoadBitmap(Resources.a10012, renderTarget),150, 200));
            _objectList.Add(new LevelObject(1500, 550, LoadBitmap(Resources.a10010, renderTarget), 100, 120));
            _objectList.Add(new LevelObject(2000, 420, LoadBitmap(Resources.a10015, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(2500, 300, LoadBitmap(Resources.a10012, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(3000, 400, LoadBitmap(Resources.a10010, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(3400, 200, LoadBitmap(Resources.a10012, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(3900, 550, LoadBitmap(Resources.a10010, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(4400, 420, LoadBitmap(Resources.a10015, renderTarget), 150, 150));
            _objectList.Add(new LevelObject(5500, 300, LoadBitmap(Resources.a10012, renderTarget), 150, 150));

            //enemies
            _enemyShipList.Add(new EnemyShip(1500, 400));
            _enemyShipList.Add(new EnemyShip(2000, 100));
            _enemyShipList.Add(new EnemyShip(2700, 350));
            _enemyShipList.Add(new EnemyShip(3500, 150));
            _enemyShipList.Add(new EnemyShip(4800, 550));
            _enemyShipList.Add(new EnemyShip(5500, 300));
            _enemyShipList.Add(new EnemyShip(6000, 500));
            _enemyShipList.Add(new EnemyShip(7000, 200));

        }

        public void LoadLevel2(D2D.WindowRenderTarget renderTarget)
        {
            levelPositionX = 0;
            background = backgroundlvl2;
            currentLevel = 2;
            //Objects
            backgroundgdi = Resources.SpaceBackground1;
            
            _objectList.Add(new LevelObject(1, 1, LoadBitmap(Resources.a10012, renderTarget), 20, 6000));
            _objectList.Add(new LevelObject(1, 740, LoadBitmap(Resources.a10012, renderTarget), 30, 6000));

            //enemies
            _enemyShipList.Add(new EnemyShip(1500, 400));
            _enemyShipList.Add(new EnemyShip(2000, 100));
            _enemyShipList.Add(new EnemyShip(2150, 500));
            _enemyShipList.Add(new EnemyShip(2300, 450));
            _enemyShipList.Add(new EnemyShip(2400, 400));
            _enemyShipList.Add(new EnemyShip(2550, 600));
            _enemyShipList.Add(new EnemyShip(2700, 350));
            _enemyShipList.Add(new EnemyShip(3500, 150));
            _enemyShipList.Add(new EnemyShip(3660, 550));
            _enemyShipList.Add(new EnemyShip(3800, 350));
            _enemyShipList.Add(new EnemyShip(3900, 450));
            _enemyShipList.Add(new EnemyShip(4800, 550));
            _enemyShipList.Add(new EnemyShip(4950, 200));
            _enemyShipList.Add(new EnemyShip(5200, 450));
            _enemyShipList.Add(new EnemyShip(5300, 400));
            _enemyShipList.Add(new EnemyShip(5500, 239));
            _enemyShipList.Add(new EnemyShip(5650, 600));
            _enemyShipList.Add(new EnemyShip(5790, 400));
            _enemyShipList.Add(new EnemyShip(6000, 100));
            _enemyShipList.Add(new EnemyShip(6150, 400));
            _enemyShipList.Add(new EnemyShip(6230, 600));
            _enemyShipList.Add(new EnemyShip(6400, 300));
            _enemyShipList.Add(new EnemyShip(6520, 400));
            _enemyShipList.Add(new EnemyShip(6650, 200));
            _enemyShipList.Add(new EnemyShip(6800, 600));
            _enemyShipList.Add(new EnemyShip(7000, 499));
            _enemyShipList.Add(new EnemyShip(7200, 240));
            _enemyShipList.Add(new EnemyShip(7340, 520));
            _enemyShipList.Add(new EnemyShip(7420, 140));
            _enemyShipList.Add(new EnemyShip(7600, 640));
            _enemyShipList.Add(new EnemyShip(7700, 520));
            _enemyShipList.Add(new EnemyShip(7850, 380));
            _enemyShipList.Add(new EnemyShip(7980, 190));
            _enemyShipList.Add(new EnemyShip(8300, 400));
            _enemyShipList.Add(new EnemyShip(6460, 590));
            _enemyShipList.Add(new EnemyShip(8690, 240));


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
            backgroundgdi = Resources.GameOver;
            _enemyShipList=null;
            _enemyShipList = new List<EnemyShip>();
            _objectList = null;
            _objectList = new List<LevelObject>();
        }
        public void LoadLevelNextLevel()
        {
            backgroundgdi = Resources.NextLevel;
            _enemyShipList = null;
            _enemyShipList = new List<EnemyShip>();
            _objectList = null;
            _objectList = new List<LevelObject>();
        }
        public void NextLevel(D2D.WindowRenderTarget renderTarget)
        {
            if(currentLevel==1)
            {

                LoadLevel2(renderTarget);
            }else if(currentLevel==2)
            {
 
                LoadLevel1(renderTarget);
            }
        }

        public D2D.Bitmap Background { get => background; set => background = value; }
        public Bitmap Backgroundgdi { get => backgroundgdi; set => backgroundgdi = value; }
        public int LevelPositionX { get => LevelPositionX1; set => LevelPositionX1 = value; }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        internal List<LevelObject> ObjectList { get => _objectList;}
        internal List<EnemyShip> EnemyShipList { get => _enemyShipList;}
        public int ScoreCount { get => scoreCount; set => scoreCount = value; }
        public D2D.Bitmap Backgroundlvl1 { get => backgroundlvl1; set => backgroundlvl1 = value; }
        public D2D.Bitmap Backgroundlvl2 { get => backgroundlvl2; set => backgroundlvl2 = value; }
        public D2D.Bitmap Backgroundlvl3 { get => backgroundlvl3; set => backgroundlvl3 = value; }
        public D2D.Bitmap BackgroundGameOver { get => backgroundGameOver; set => backgroundGameOver = value; }
        public D2D.Bitmap BackgroundNextLevel { get => backgroundNextLevel; set => backgroundNextLevel = value; }
        public int LevelPositionX1 { get => levelPositionX; set => levelPositionX = value; }
    }
}
