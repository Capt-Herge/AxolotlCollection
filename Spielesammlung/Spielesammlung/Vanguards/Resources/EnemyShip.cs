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

namespace Spielesammlung.Vanguards.Resources
{
    class EnemyShip
    {
        private int _posX = 0;
        private int _posY = 0;
        private D2D.Bitmap spaceshipBitmap;
        private Bitmap spaceshipBitmapGDI=Resources.cartoonship_red;
        private int shipHitboxX = 100;
        private int shipHitboxY = 100;
        private bool destroyed = false;
        private int weaponCooldonw = 0;

        public EnemyShip(int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
        }

        public int PosX { get => _posX; set => _posX = value; }
        public int PosY { get => _posY; set => _posY = value; }
        public D2D.Bitmap SpaceshipBitmap { get => spaceshipBitmap; set => spaceshipBitmap = value; }
        public Bitmap SpaceshipBitmapGDI { get => spaceshipBitmapGDI; set => spaceshipBitmapGDI = value; }
        public int ShipHitboxX { get => shipHitboxX; set => shipHitboxX = value; }
        public int ShipHitboxY { get => shipHitboxY; set => shipHitboxY = value; }
        public bool Destroyed { get => destroyed; set => destroyed = value; }
        public int WeaponCooldonw { get => weaponCooldonw; set => weaponCooldonw = value; }
    }
}
