using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Snake
{
    class Element
    {
        // getter und setter
        public int X { get; set; }

        public int Y { get; set; }

        // Konstruktor
        public Element()
        {
            X = 0;
            Y = 0;
        }
    }
}
