using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    abstract class Leitern
    {
        public int xPosition { get; set; } = 1;
        public int yPosotion { get; set; } = 1;
        public Pixel[,] model { get; set; }
        public int[,] form { get; set; }

        public void Leben()
        {

        }

        public void Sterben()
        {

        }
    }
}
