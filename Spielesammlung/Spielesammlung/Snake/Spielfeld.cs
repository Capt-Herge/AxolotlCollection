using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Snake
{
    class Spielfeld
    {

        int breite;
        int höhe;
        int geschwindigkeit;
        int score;
        int punkte;
        bool gameOver;
        int richtung;


        // getter und setter
        public static int Breite
        {
            get
            {
                return Spielfeld.Breite;
            }
            set
            {
                Spielfeld.Breite = value;
            }
        }
        public static int Höhe
        {
            get
            {
                return Spielfeld.Höhe;
            }
            set
            {
                Spielfeld.Höhe = value;
            }
        }
        public static int Geschwindigkeit
        {
            get
            {
                return Spielfeld.Geschwindigkeit;
            }
            set
            {
                Spielfeld.Geschwindigkeit = value;
            }
        }
        public static int Score
        {
            get
            {
                return Spielfeld.Score;
            }
            set
            {
                Spielfeld.Score = value;
            }
        }
        public static int Punkte
        {
            get
            {
                return Spielfeld.Punkte;
            }
            set
            {
                Spielfeld.Punkte = value;
            }
        }
        public static bool GameOver
        {
            get
            {
                return Spielfeld.GameOver;
            }
            set
            {
                Spielfeld.GameOver = value;
            }
        }
        public static int Richtung
        {
            get
            {
                return Spielfeld.Richtung;
            }
            set
            {
                Spielfeld.Richtung = value;
            }
        }

        // Konsturktor
        public Spielfeld()
        {
            Höhe = 16;
            Breite = 16;
            Geschwindigkeit = 16;
            Score = 0;
            Punkte = 10;
            GameOver = false;
            Richtung = 4;
        }
    }
}
