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
    class LevelObject
    {
        private int _posX = 0;
        private int _posY = 0;
        private D2D.Bitmap _objectBitmap;
        private Bitmap _objectBitmapGDI;
        private int rectangleHoehe=0;
        private int rectangleBreite = 0;

        public LevelObject(int posX, int posY, Bitmap objectBitmapGDI, int rectangleHoehe, int rectangleBreite)
        {
            PosX = posX;
            PosY = posY;
            ObjectBitmapGDI = objectBitmapGDI;
            this.RectangleHoehe = rectangleHoehe;
            this.RectangleBreite = rectangleBreite;
        }

        public int PosX { get => _posX; set => _posX = value; }
        public int PosY { get => _posY; set => _posY = value; }
        public D2D.Bitmap ObjectBitmap { get => _objectBitmap; set => _objectBitmap = value; }
        public Bitmap ObjectBitmapGDI { get => _objectBitmapGDI; set => _objectBitmapGDI = value; }
        public int RectangleHoehe { get => rectangleHoehe; set => rectangleHoehe = value; }
        public int RectangleBreite { get => rectangleBreite; set => rectangleBreite = value; }
    }
}
