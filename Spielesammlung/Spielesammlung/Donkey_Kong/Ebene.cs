using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    abstract class Ebene
    {
        public int nummer { get; set; } = 0;
        public int xPosition { get; set; } = 1;
        public int yPosition { get; set; } = 1;
        public int laenge { get; set; } = 1;
    }
}
