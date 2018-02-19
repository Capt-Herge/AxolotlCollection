using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlimDX;
using D2D = SlimDX.Direct2D;
using DXGI = SlimDX.DXGI;

namespace Spielesammlung.Vanguards.Resources
{
    class Level
    {
        private D2D.Bitmap background;
        private Bitmap backgroundgdi;
        private int levelPositionX;
        private int currentLevel;
        private List<LevelObject> _objectList = new List<LevelObject>();
        private List<EnemyShip> _enemyShipList = new List<EnemyShip>();
        private int scoreCount = 0;
        public Level()
        {
            LevelPositionX = 0;
        }
        public void LoadLevel1()
        {
            //Objects
            backgroundgdi = Resources.SpaceBackground1;
            _objectList.Add(new LevelObject(400, 400, Resources.a10010, 150, 150));
            _objectList.Add(new LevelObject(1200, 200, Resources.a10012, 150, 200));
            _objectList.Add(new LevelObject(1500, 550, Resources.a10010, 100, 120));
            _objectList.Add(new LevelObject(2000, 420, Resources.a10015, 150, 150));
            _objectList.Add(new LevelObject(2500, 300, Resources.a10012, 150, 150));
            _objectList.Add(new LevelObject(3000, 400, Resources.a10010, 150, 150));
            _objectList.Add(new LevelObject(3400, 200, Resources.a10012, 150, 150));
            _objectList.Add(new LevelObject(3900, 550, Resources.a10010, 150, 150));
            _objectList.Add(new LevelObject(4400, 420, Resources.a10015, 150, 150));
            _objectList.Add(new LevelObject(5500, 300, Resources.a10012, 150, 150));

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
        public void NextLevel()
        {
            LoadLevelNextLevel();
        }

        public D2D.Bitmap Background { get => background; set => background = value; }
        public Bitmap Backgroundgdi { get => backgroundgdi; set => backgroundgdi = value; }
        public int LevelPositionX { get => levelPositionX; set => levelPositionX = value; }
        public int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        internal List<LevelObject> ObjectList { get => _objectList;}
        internal List<EnemyShip> EnemyShipList { get => _enemyShipList;}
        public int ScoreCount { get => scoreCount; set => scoreCount = value; }
    }
}
