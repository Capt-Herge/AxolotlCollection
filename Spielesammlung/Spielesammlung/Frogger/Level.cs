using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    abstract class Level
    {
        public int nummer { get; set; } = 0;
        public int xPosition { get; set; } = 1;
        public int yPosition { get; set; } = 1;
        public int laenge { get; set; } = 1;
        public int[,] form { get; set; }
        public Pixel[,] model { get; set; }

        public void Leben()
        {

        }

        public void Sterben()
        {

        }
    }
}
