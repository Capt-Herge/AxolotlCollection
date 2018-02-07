using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Falltuer
    {
        public int ebene { get; set; } = 0;
        public int xPosition { get; set; } = 1;
        public int yPosition { get; set; } = 1;
        public bool offen { get; set; } = false;

        public Falltuer()
        {

        }
    }
}
