using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung
{
    class Spielfeld_Snake

    {
        // getter und setter
        public static int Breite
        {
            get; set;
        }
        public static int Höhe
        {
            get; set;
        }
        public static int Geschwindigkeit
        {
            get; set;
        }
        public static int Score
        {
            get; set;
        }
        public static int Punkte
        {
            get; set;
        }
        public static bool GameOver
        {
            get; set;
        }
        public static int Richtung
        {
            get; set;
        }

        // Konsturktor
        public Spielfeld_Snake()
        {
            Höhe = 22;
            Breite = 22;
            Geschwindigkeit = 10;
            Score = 0;
            Punkte = 10;
            GameOver = false;
            Richtung = 4;
        }
    }
}
