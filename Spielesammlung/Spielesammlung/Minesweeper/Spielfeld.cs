using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Minesweeper
{
    class Spielfeld
    {
        public static bool GameOver { set; get; }

        public static int Minen { set; get; }

        public Spielfeld()
        {
            GameOver = false;
            Minen = 60;
        }

    }
}
