using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Snake
{
    class Spielfeld

    {
        // getter und setter
        public static int Breite { get; set; }

        public static int Höhe { get; set; }

        public static int Geschwindigkeit { get; set; }

        public static int Score { get; set; }

        public static int Punkte { get; set; }

        public static bool GameOver { get; set; }

        public static int Richtung { get; set; }

        // Konsturktor
        public Spielfeld()
        {
            Höhe = 25;
            Breite = 25;
            Geschwindigkeit = 10;
            Score = 0;
            Punkte = 10;
            GameOver = false;
            Richtung = 4;
        }
    }
}

