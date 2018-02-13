using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Minesweeper
{
    class Spielfeld
    {
        // Getter und Setter
        public static int Höhe { set; get; }

        public static int Breite { set; get; }

        public static bool GameOver { set; get; }

        public static bool Gewonnen { set; get; }

        public static int Minen { set; get; }

        public static int FelderRest { set; get; }

        public static int Stunde { set; get; }

        public static int Minute { set; get; }

        public static int Sekunde { set; get; }

        // Konstruktor
        public Spielfeld()
        {
            Höhe = 20;
            Breite = 20;
            GameOver = false;
            Gewonnen = false;
            Minen = 6;
            FelderRest = Höhe * Breite - Minen;
            Sekunde = 0;
            Minute = 0;
            Stunde = 0;
        }
    }
}
