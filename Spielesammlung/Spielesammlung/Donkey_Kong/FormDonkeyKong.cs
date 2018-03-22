using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Donkey_Kong
{
    public partial class FormDonkeyKong : Form
    {
        static int siegbedingung = 0;
        static int aktuellesLevel = 2;
        static bool neustart = false;

        static int score = 20000;
        static int scoreHilf = 0;

        static int affeHilf = 0;
        static int fassHilf1 = 0;
        static int fassHilf2 = 0;
        static int fassHilf3 = 0;
        static int fassHilf4 = 0;

        static KeyEventArgs Taste = new KeyEventArgs(new Keys());

        Highscore donkeykongHighscore = new Highscore();
        string spieler;
        string punktzahl;

        Timer timerSpiel = new Timer();

        public FormDonkeyKong()
        {
            #region timer Spiel
            timerSpiel.Tick += new EventHandler(UpdateSpiel);

            timerSpiel.Interval = 1;

            timerSpiel.Enabled = true;

            timerSpiel.Start();
            #endregion

            InitializeComponent();
        }


        private void UpdateSpiel(object sender, EventArgs e)
        {
            label2.Text = score.ToString();
            scoreHilf++;

            if(scoreHilf == 100)
            {
                score = score - 100;
                scoreHilf = 0;
            }

            affeHilf++;
            fassHilf1++;
            fassHilf2++;
            fassHilf3++;
            fassHilf4++;
            pictureBox1.Invalidate();            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Levelladen(aktuellesLevel, e);
        }

        private void FormDonkeyKong_KeyDown(object sender, KeyEventArgs e)
        {
            Taste = e;
        }

        private void FormDonkeyKong_KeyUp(object sender, KeyEventArgs e)
        {
            Taste = new KeyEventArgs(new Keys());
        }

        private void Levelladen(int altesLevel, PaintEventArgs e)
        {
            switch (altesLevel)
            {
                case 1:
                    Level2 level2 = new Level2(e, affeHilf, Taste);

                    if (affeHilf > 200)
                    {
                        affeHilf = 0;
                    }

                    if (neustart == true)
                    {
                        siegbedingung = -1;
                        level2.levelbeendedt = true;
                        neustart = false;
                    }

                    if (level2.levelbeendedt == true)
                    {
                        siegbedingung++;
                        level2.Neustart();
                        aktuellesLevel = 2;
                        affeHilf = 0;
                        level2.levelbeendedt = false;
                    }                  
                    break;
                case 2:
                    Level1 level1 = new Level1(e, affeHilf, fassHilf1, fassHilf2, fassHilf3, fassHilf4, Taste);

                    if (affeHilf > 200)
                    {
                        affeHilf = 0;
                    }

                    if (fassHilf1 > 23)
                    {
                        fassHilf1 = 0;
                    }
                    if (fassHilf2 > 23)
                    {
                        fassHilf2 = 0;
                    }
                    if (fassHilf3 > 23)
                    {
                        fassHilf3 = 0;
                    }
                    if (fassHilf4 > 23)
                    {
                        fassHilf4 = 0;
                    }

                    if (neustart == true)
                    {
                        siegbedingung = -1;
                        level1.levelbeendedt = true;
                    }

                    if (level1.levelbeendedt == true)
                    {
                        siegbedingung++;
                        level1.Neustart();
                        aktuellesLevel = 1;
                        affeHilf = 0;
                        fassHilf1 = 0;
                        fassHilf2 = 0;
                        fassHilf3 = 0;
                        fassHilf4 = 0;
                        level1.levelbeendedt = false;
                    }

                    if (neustart == true)
                    {
                        aktuellesLevel = 2;
                        neustart = false;
                    }
                    break;
            }

            if(siegbedingung == 2)
            {
                timerSpiel.Stop();
                HighscoreEintragen();
            }

            if (score <= -100)
            {
                GameOver();
            }
        }

        private void ProgrammBeenden(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Neustart(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Visible = false;

            label1.Visible = false;
            label1.Enabled = false;

            label3.Visible = false;
            label3.Enabled = false;

            button1.Visible = false;
            button1.Enabled = false;

            button2.Visible = false;
            button2.Enabled = false;

            aktuellesLevel = 2;

            score = 20000;
            scoreHilf = 0;

            affeHilf = 0;
            fassHilf1 = 0;
            fassHilf2 = 0;
            fassHilf3 = 0;
            fassHilf4 = 0;

            KeyEventArgs Taste = new KeyEventArgs(new Keys());

            neustart = true;
        }

        private void HighscoreAnzeigen(object sender, EventArgs e)
        {
            timerSpiel.Stop();

            label1.Text = donkeykongHighscore.EinträgeAnzeigenPunkte("DonkeyKong");

            label1.Visible = true;
            label1.Enabled = true;

            button1.Visible = true;
            button1.Enabled = true;
        }

        public void HighscoreEintragen()
        {
            textBox1.Enabled = true;
            textBox1.Visible = true;

            label1.Visible = true;
            label1.Enabled = true;

            button1.Visible = true;
            button1.Enabled = true;

            button2.Visible = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerSpiel.Start();

            textBox1.Enabled = false;
            textBox1.Visible = false;

            label1.Visible = false;
            label1.Enabled = false;

            label3.Visible = false;
            label3.Enabled = false;

            button1.Visible = false;
            button1.Enabled = false;

            button2.Visible = false;
            button2.Enabled = false;

            aktuellesLevel = 2;

            score = 20000;
            scoreHilf = 0;

            affeHilf = 0;
            fassHilf1 = 0;
            fassHilf2 = 0;
            fassHilf3 = 0;
            fassHilf4 = 0;

            KeyEventArgs Taste = new KeyEventArgs(new Keys());

            neustart = true;
        }

        private void Pause(object sender, EventArgs e)
        {
            if(pauseToolStripMenuItem.Text == "Pause")
            {
                pauseToolStripMenuItem.Text = "Fortsetzen";
                timerSpiel.Stop();
            }
            else if (pauseToolStripMenuItem.Text == "Fortsetzen")
            {
                pauseToolStripMenuItem.Text = "Pause";
                timerSpiel.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 3)
            {
                punktzahl = score.ToString();
                spieler = textBox1.Text;

                label1.Text = donkeykongHighscore.HighscoreEintragen("DonkeyKong", spieler, punktzahl);
            }
        }

        private void GameOver()
        {
            timerSpiel.Stop();

            button1.Visible = true;
            button1.Enabled = true;

            label3.Visible = true;
            label3.Enabled = true;
        }
    }
}
