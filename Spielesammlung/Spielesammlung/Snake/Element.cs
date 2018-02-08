using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Snake
{
    class Element
    {
        int x;
        int y;

        // getter und setter
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        // Konstruktor
        public Element()
        {
            x = 0;
            y = 0;
        }

    }
}
