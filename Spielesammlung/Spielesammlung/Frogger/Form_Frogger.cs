using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Frogger
{
    public partial class Form_Frogger : Form
    {
        static int score = 50000;
        static int scoreHilf = 0;
        static bool neustart = false;

        Highscore donkeykongHighscore = new Highscore();
        string spieler;
        string punktzahl;

        Timer timerSpiel = new Timer();
        static KeyEventArgs Taste = new KeyEventArgs(new Keys());

        public Form_Frogger()
        {
            #region timer Spiel        
            timerSpiel.Tick += new EventHandler(UpdateSpiel);

            timerSpiel.Interval = 1;     
            #endregion

            InitializeComponent();

            button3.Enabled = true;
            button3.Visible = true;

            label4.Visible = true;
        }


        private void UpdateSpiel(object sender, EventArgs e)
        {
            label2.Text = score.ToString();
            scoreHilf++;

            if (scoreHilf == 100)
            {
                score = score - 100;
                scoreHilf = 0;
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Levelladen(e);
        }

        private void FormDonkeyKong_KeyDown(object sender, KeyEventArgs e)
        {
            Taste = e;                
        }

        private void FormDonkeyKong_KeyUp(object sender, KeyEventArgs e)
        {
            Taste = new KeyEventArgs(Keys.P);
        }

        private void Levelladen(PaintEventArgs e)
        {
            Level1 level1 = new Level1(e, Taste);

            if (level1.levelGeschafft)
            {
                level1.LevelBeendedt();
                timerSpiel.Stop();
                HighscoreEintragen();
            }

            if(score <= -100)
            {
                GameOver();
            }
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

            score = 50000;
            scoreHilf = 0;

            KeyEventArgs Taste = new KeyEventArgs(new Keys());

            neustart= true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 3)
            {
                punktzahl = score.ToString();
                spieler = textBox1.Text;

                label1.Text = donkeykongHighscore.HighscoreEintragen("Frogger", spieler, punktzahl);
            }
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

            KeyEventArgs Taste = new KeyEventArgs(new Keys());
            score = 50000;
            scoreHilf = 0;
        }

        private void Pause(object sender, EventArgs e)
        {
            if (programmBeendenToolStripMenuItem.Text == "Pause")
            {
                programmBeendenToolStripMenuItem.Text = "Fortsetzen";
                timerSpiel.Stop();
            }
            else if (programmBeendenToolStripMenuItem.Text == "Fortsetzen")
            {
                programmBeendenToolStripMenuItem.Text = "Pause";
                timerSpiel.Start();
            }
        }

        private void HighscoreAnzeigen(object sender, EventArgs e)
        {
            timerSpiel.Stop();

            label1.Text = donkeykongHighscore.EinträgeAnzeigenPunkte("Frogger");

            label1.Visible = true;
            label1.Enabled = true;

            button1.Visible = true;
            button1.Enabled = true;
        }

        private void GameOver()
        {
            timerSpiel.Stop();

            button1.Visible = true;
            button1.Enabled = true;

            label3.Visible = true;
            label3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.Visible = false;

            label4.Visible = false;

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

            timerSpiel.Start();
            score = 50000;
            scoreHilf = 0;

            KeyEventArgs Taste = new KeyEventArgs(new Keys());

            neustart = true;
        }
    }
}