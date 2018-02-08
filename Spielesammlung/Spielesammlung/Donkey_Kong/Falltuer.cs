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
        public Pixel[,] model { get; set; } = new Pixel[1, 9];
        public int[,] form { get; set; } = new int[1, 9];

        public Falltuer()
        {
            #region form
            form[0, 0] = 11;
            form[0, 1] = 11;
            form[0, 2] = 11;
            form[0, 3] = 11;
            form[0, 4] = 11;
            form[0, 5] = 11;
            form[0, 6] = 11;
            form[0, 7] = 11;
            form[0, 8] = 11;
            #endregion
        }
    }
}
