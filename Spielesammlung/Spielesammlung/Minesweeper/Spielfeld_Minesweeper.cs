using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung
{
    class Spielfeld_Minesweeper
    {
        public static bool GameOver { set; get; }

        public static int Minen { set; get; }

        public Spielfeld_Minesweeper()
        {
            GameOver = false;
            Minen = 60;
        }

    }
}
