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

namespace Spielesammlung.Vanguards
{
    class PlayerShip
    {
        private int _posX = 0;
        private int _posY = 0;
        private D2D.Bitmap spaceshipBitmap;
        private Bitmap spaceshipBitmapGDI;
        private int shipHitboxX = 100;
        private int shipHitboxY = 100;

        public int PosX
        {
            get
            {
                return _posX;
            }

            set
            {
                _posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _posY;
            }

            set
            {
                _posY = value;
            }
        }

        public D2D.Bitmap SpaceshipBitmap
        {
            get
            {
                return spaceshipBitmap;
            }

            set
            {
                spaceshipBitmap = value;
            }
        }

        public Bitmap SpaceshipBitmapGDI
        {
            get
            {
                return spaceshipBitmapGDI;
            }

            set
            {
                spaceshipBitmapGDI = value;
            }
        }

        public int ShipHitboxX
        {
            get
            {
                return shipHitboxX;
            }

            set
            {
                shipHitboxX = value;
            }
        }

        public int ShipHitboxY
        {
            get
            {
                return shipHitboxY;
            }

            set
            {
                shipHitboxY = value;
            }
        }

        public PlayerShip(D2D.Bitmap spaceshipBitmap)
        {
            this.SpaceshipBitmap = spaceshipBitmap;
        }



        public D2D.Bitmap getShipBitmap()
        {
            return SpaceshipBitmap;
        }


    }
}
