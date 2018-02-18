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
        // globale Variable
        static bool logScore = false;

        // Liste für die Elemente der Schlange
        private List<Element> Schlange = new List<Element>();
        // Element für die Nahrung
        private Element Nahrung = new Element();

        public Form_Snake()
        {
            InitializeComponent();

            // Objekt Spielfeld erzeugen
            new Spielfeld();

            // Festlegen des Intervalls für den Timer
            timerSnake.Interval = 1000 / Spielfeld.Geschwindigkeit;
            // Startet des Timer
            timerSnake.Start();
            // Nach Ablauf des Intervalls wird das Spiel aktualisiert
            timerSnake.Tick += UpdateSpiel;

            string anleitung = "     Steuere die Schlange mit W,A,S,D.\nSammel so viel Nahrung wie möglich und\n    erhalte einen möglichst hohen Score.\nDoch triff nicht den Rand oder dich selbst\n          denn dann ist das Spiel vorbei.";
            labelAnleitung.Text = anleitung;

            labelSnake.Visible = true;
            labelAnleitung.Visible = true;
            buttonStart.Visible = true;
            buttonStart.Enabled = true;

        }

        private void StarteNeuesSpiel()
        {
            // Objekt Spielfeld erzeugen 
            new Spielfeld();

            // Schlange wird gelöscht
            Schlange.Clear();
            // Element für den Kopf der Schlange erstellen
            Element KopfSchlange = new Element();
            // Startposition der Schlange
            KopfSchlange.X = 20;
            KopfSchlange.Y = 20;
            // Kopf zur Hashtabelle für die Schlange hinzufügen
            Schlange.Add(KopfSchlange);

            // Startwert für den Score 
            labelScoreWert.Text = Spielfeld.Score.ToString();

            // Platzieren der Nahrung auf dem Spielfeld
            SetzeNahrung();
        }

        public void UpdateSpiel(object sender, EventArgs e)
        {
            // Wenn das Spiel vorbei ist, wird mit Enter das neue Spiel gestartet
            if (Spielfeld.GameOver == true)
            {
                if (logScore == true)
                {
                    logScore = false;

                    string leer = "            ";

                    string gameOver = leer + "     Game Over!\n" + leer + "        Score: " + Spielfeld.Score + "\nBitte gib deinen Spielernamen ein\n" + leer + "(genau 3 Zeichen)";
                    labelGameOver.Text = gameOver;
                    labelGameOver.Visible = true;
                    textBoxSpieler.Visible = true;
                    textBoxSpieler.Enabled = true;
                    buttonWeiter.Visible = true;
                    buttonWeiter.Enabled = true;
                }
            }

            // Während des Spiels ist die entgegengesetzte Richtungen nicht erlaubt, damit die Schlange sich nicht selbst trifft
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

                // Position der Schlange wird aktualisiert
                UpdateSnake();
            }

            // Spielfeld(PictureBox) wird neu gezeichnet
            pictureBoxSnake.Invalidate();
        }

        public void SetzeNahrung()
        {
            // Maximale Werte für X und Y bestimmen
            int xMax = pictureBoxSnake.Size.Width / Spielfeld.Breite;
            int yMax = pictureBoxSnake.Size.Height / Spielfeld.Höhe;

            // aktuelle Position für Nahrung wird zufällig bestimmt
            Random zufall = new Random();
            Nahrung = new Element();
            Nahrung.X = zufall.Next(0, xMax);
            Nahrung.Y = zufall.Next(0, yMax);

        }

        private void pictureBoxSnake_Paint(object sender, PaintEventArgs e)
        {
            // Teile der Schlange werden gefärbt
            Graphics feld = e.Graphics;

            if (Spielfeld.GameOver == false)
            {
                Brush farbeSchlange;

                for (int i = 0; i < Schlange.Count; i++)
                {
                    // Kopf der Schlange ist schwarz
                    if (i == 0)
                    {
                        farbeSchlange = Brushes.Black;
                    }
                    // Körper der Schlange ist orange
                    else
                    {
                        farbeSchlange = Brushes.DarkOrange;
                    }

                    // Malt die Teile der Schlange aus
                    feld.FillRectangle(farbeSchlange,
                                    new Rectangle(Schlange[i].X * Spielfeld.Breite, Schlange[i].Y * Spielfeld.Höhe,
                                                  Spielfeld.Breite, Spielfeld.Höhe));

                    // Malt die Nahrung aus
                    feld.FillEllipse(Brushes.Red,
                                    new Rectangle(Nahrung.X * Spielfeld.Breite, Nahrung.Y * Spielfeld.Höhe,
                                                  Spielfeld.Breite, Spielfeld.Höhe));
                }
            }
        }

        public void UpdateSnake()
        {
            for (int i = Schlange.Count - 1; i >= 0; i--)
            {
                //Kopf der Schlange wird je nach Richtung bewegt
                if (i == 0)
                {
                    switch (Spielfeld.Richtung)
                    {
                        // Oben
                        case 1:
                            Schlange[i].Y--;
                            break;
                        // Links
                        case 2:
                            Schlange[i].X--;
                            break;
                        // Unten
                        case 3:
                            Schlange[i].Y++;
                            break;
                        // Rechts
                        case 4:
                            Schlange[i].X++;
                            break;
                    }

                    // Maximale Werte für X und Y bestimmen
                    int xMax = pictureBoxSnake.Size.Width / Spielfeld.Breite;
                    int yMax = pictureBoxSnake.Size.Height / Spielfeld.Höhe;

                    // Kollision mit den Rändern
                    if (Schlange[i].X < 0 || Schlange[i].Y < 0 || Schlange[i].X >= xMax || Schlange[i].Y >= yMax)
                    {
                        SchlangeTot();
                    }

                    // Kollision mit sich selbst
                    for (int j = 1; j < Schlange.Count; j++)
                    {
                        if (Schlange[i].X == Schlange[j].X && Schlange[i].Y == Schlange[j].Y)
                        {
                            SchlangeTot();
                        }
                    }

                    // Kollision mit der Nahrung
                    if (Schlange[0].X == Nahrung.X && Schlange[0].Y == Nahrung.Y)
                    {
                        NahrungEssen();
                    }
                }

                // Jedes Element des Körpers der Schlange bekommt die Position des Vorgängers
                else
                {
                    Schlange[i].X = Schlange[i - 1].X;
                    Schlange[i].Y = Schlange[i - 1].Y;
                }
            }
        }

        private void SchlangeTot()
        {
            // GameOver wird auf true gesetzt
            Spielfeld.GameOver = true;

            logScore = true;
        }

        private void NahrungEssen()
        {
            // Position mit Nahrung wird zur Position des neuen Elements des Körpers der Schlange
            Element Nahrung = new Element();
            Nahrung.X = Schlange[Schlange.Count - 1].X;
            Nahrung.Y = Schlange[Schlange.Count - 1].Y;

            // Nahrung zur Hashtabelle der Schlange hinzufügen
            Schlange.Add(Nahrung);

            // Score erhöhen
            Spielfeld.Score = Spielfeld.Score + Spielfeld.Punkte;
            labelScoreWert.Text = Spielfeld.Score.ToString();

            // Neue Nahrung erstellen
            SetzeNahrung();
        }

        // Event Taste kommt hoch ändert den Status
        private void Form_Snake_KeyUp(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, false);
        }

        // Event Taste ist gedrückt ändert den Status
        private void Form_Snake_KeyDown(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, true);
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            labelGameOver.Visible = false;
            textBoxSpieler.Visible = false;
            textBoxSpieler.Enabled = false;
            buttonWeiter.Visible = false;
            buttonWeiter.Enabled = false;

            string spieler = textBoxSpieler.Text;
            string punktzahl = Spielfeld.Score.ToString();

            Highscore snakeHighscore = new Highscore();

            labelHighscore.Text = snakeHighscore.HighscoreEintragen("Snake", spieler, punktzahl);

            labelHighscore.Visible = true;

            buttonNeustart.Visible = true;
            buttonNeustart.Enabled = true;
        }

        private void buttonNeustart_Click(object sender, EventArgs e)
        {
            // Label für den Highscore soll nicht sichtbar sein zu Beginn des Spiels
            labelHighscore.Visible = false;
            buttonNeustart.Visible = false;
            buttonNeustart.Enabled = false;
            StarteNeuesSpiel();
            this.Focus();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelSnake.Visible = false;
            labelAnleitung.Visible = false;
            buttonStart.Visible = false;
            buttonStart.Enabled = false;
            StarteNeuesSpiel();
            this.Focus();
        }
    }
}