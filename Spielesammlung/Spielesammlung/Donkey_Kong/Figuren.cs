using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    abstract class Figuren
    {
        public int xPosition { get; set; } = 0;
        public int yPosition { get; set; } = 0;
        public Pixel[,] model { get; set; }

        public void Leben()
        {

        }

        public void Sterben()
        {

        }
    }
}
