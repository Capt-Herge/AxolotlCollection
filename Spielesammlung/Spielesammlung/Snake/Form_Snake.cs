using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Snake
{
    public partial class Form_Snake : Form
    {
        private List<Element> Schlange = new List<Element>();
        private Element Nahrung = new Element();

        private void Update(object sender, EventArgs e)
        {
            pictureBoxSnake.Invalidate();
        }

        public Form_Snake()
        {
            InitializeComponent();
            // Standartwerte für das Spiel übernehmen, wenn erstellt
            new Spielfeld();

            // Timer 
            timerSnake.Interval = 1000 / Spielfeld.Geschwindigkeit;
            timerSnake.Tick += UpdateSpiel;
            timerSnake.Start();

            StarteNeuesSpiel();

        }

        private void StarteNeuesSpiel()
        {
            labelGameOver.Visible = false;

            // Standardwerte übernehmen, wenn Spiel neu gestartet wird
            new Spielfeld();

            Schlange.Clear();
            Element KopfSchlange = new Element();
            KopfSchlange.X = 10;
            KopfSchlange.Y = 5;
            Schlange.Add(KopfSchlange);

            labelScoreWert.Text = Spielfeld.Score.ToString();

            SetzeNahrung();

        }

        public void SetzeNahrung()
        {
            int xMax = pictureBoxSnake.Size.Width / Spielfeld.Breite;
            int yMax = pictureBoxSnake.Size.Height / Spielfeld.Höhe;

            Random zufall = new Random();
            Nahrung = new Element();
            Nahrung.X = zufall.Next(0, xMax);
            Nahrung.Y = zufall.Next(0, yMax);

        }

        public void UpdateSpiel(object sender, EventArgs e)
        {
            if (Spielfeld.GameOver == true)
            {
                if (Steuerung.TasteGedrückt(Keys.Enter))
                {
                    StarteNeuesSpiel();
                }
            }
            else
            {
                if (Steuerung.TasteGedrückt(Keys.W) && Spielfeld.Richtung != 3)
                {
                    Spielfeld.Richtung = 1;
                }
                if (Steuerung.TasteGedrückt(Keys.A) && Spielfeld.Richtung != 4)
                {
                    Spielfeld.Richtung = 2;
                }
                if (Steuerung.TasteGedrückt(Keys.S) && Spielfeld.Richtung != 1)
                {
                    Spielfeld.Richtung = 3;
                }
                if (Steuerung.TasteGedrückt(Keys.D) && Spielfeld.Richtung != 2)
                {
                    Spielfeld.Richtung = 4;
                }

                UpdateSnake();
            }

            pictureBoxSnake.Invalidate();
        }


        private void pictureBoxSnake_Paint(object sender, PaintEventArgs e)
        {
            Graphics feld = e.Graphics;

            if (Spielfeld.GameOver != false)
            {
                Brush farbeSchlange;

                for (int i = 0; i < Schlange.Count; i++)
                {
                    if (i == 0)
                    {
                        farbeSchlange = Brushes.Black;
                    }
                    else
                    {
                        farbeSchlange = Brushes.DarkOrange;
                    }

                    feld.FillEllipse(farbeSchlange, 
                                    new Rectangle(Schlange[i].X*Spielfeld.Breite, Schlange[i].Y*Spielfeld.Höhe,
                                                  Spielfeld.Breite, Spielfeld.Höhe));

                    feld.FillEllipse(Brushes.Red,
                                    new Rectangle(Nahrung.X * Spielfeld.Breite, Nahrung.Y * Spielfeld.Höhe,
                                                  Spielfeld.Breite, Spielfeld.Höhe));
                }
            }

            else
            {
                string gameOver = "Game Over! \n Score: " + Spielfeld.Score;
                labelGameOver.Text = gameOver;
                labelGameOver.Visible = true;
            }
        }

        public void UpdateSnake()
        {
            for (int i = Schlange.Count; i > 0; i--)
            {
                if (i == 1)
                {
                    switch (Spielfeld.Richtung)
                    {
                        case 1:
                            Schlange[i].Y++;
                            break;
                        case 2:
                            Schlange[i].X--;
                            break;
                        case 3:
                            Schlange[i].Y--;
                            break;
                        case 4:
                            Schlange[i].X++;
                            break;
                    }   
                }
                else
                {
                    Schlange[i].X = Schlange[i - 1].X;
                    Schlange[i].Y = Schlange[i - 1].Y;
                }
            }
        }


    }
}