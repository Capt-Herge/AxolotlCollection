using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Breakout
{
    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 10;

        int ballx = 8;
        int bally = 8;

        int score = 0;

        bool pause;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            pause = true;
            string anleitung = " Steuere die Platte mit Pfeil-Links, Pfeil-Rechts \n Versuche mithilfe des Balls alle Platten zu entfernen in dem du den Ball auf sie schießt. \n Pro Platte erhälst du einen Punkt. \n Entferne alle Platten um zu gewinnen!";
            labelAnleitung.Text = anleitung;
            labelAnleitung.Visible = true;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    x.BackColor = randomColor;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!pause)
            {

                Ball.Left += ballx;
                Ball.Top += bally;

                PScore.Text = "" + score;

                if (goLeft)
                {
                    Player.Left -= speed;
                }
                if (goRight)
                {
                    Player.Left += speed;
                }
                if (Player.Left < 1)
                {
                    goLeft = false;
                }
                else if (Player.Left + Player.Width > this.Width)
                {
                    goRight = false;
                }
                if (Ball.Left + Ball.Width > ClientSize.Width || Ball.Left < 0)
                {
                    ballx = -ballx;
                }
                if (Ball.Top < 20 || Ball.Bounds.IntersectsWith(Player.Bounds))
                {
                    bally = -bally;
                }
                if (Ball.Top + Ball.Height > ClientSize.Height)
                {
                    gameOver();
                    EndLabel.Visible = true;
                    buttonWeiter.Visible = true;
                    EndLabel.Text = ("Sie haben verloren!\nBitte gib deinen Spielernamen ein.\n (genau 3 Zeichen)");
                    textBoxSpieler.Visible = true;

                    Ball.Location = new Point(this.Height / 2, this.Width / 2);
                    bally = -8;
                    Player.Location = new Point(376, 687);
                    score = 0;
                    timer1.Start();
                    pause = !pause;
                    this.Focus();
                    return;
                }
                //löschen der Blöcke und Punkte hochzählen
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "block")
                    {
                        if (Ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            bally = -bally;
                            score++;
                        }
                    }
                }
                if (score > 53)
                {
                    gameOver();
                    EndLabel.Visible = true;
                    textBoxSpieler.Enabled = true;
                    textBoxSpieler.Visible = true;
                    buttonWeiter.Visible = true;
                    EndLabel.Text = ("Sie haben gewonnen!\nBitte gib deinen Spielernamen ein.\n (genau 3 Zeichen)");

                    

                    Ball.Location = new Point(this.Height / 2, this.Width / 2);
                    bally = -8;
                    Player.Location = new Point(376, 687);
                    score = 0;
                    timer1.Start();
                    pause = !pause;
                    this.Focus();
                    return;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            pause = !pause;
            labelAnleitung.Visible = false;
            this.Focus();

        }
        private void gameOver()
        {
            timer1.Stop();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Player.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Player.Left + Player.Width < this.Width)
            {
                goRight = true;
            }
            else if (e.KeyCode == Keys.P)
            {
                if (!pause)
                {
                    pause = true;
                }
                else if (pause)
                {
                    pause = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause = !pause;
        }

        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlockRefresh();

            Ball.Location = new Point(this.Height / 2, this.Width / 2);
            bally = -8;
            Player.Location = new Point(376, 687);
            score = 0;
            timer1.Start();
            pause = !pause;
            this.Focus();
            return;
        }
        private void BlockRefresh()
        {
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(pictureBox4);
            this.Controls.Add(pictureBox5);
            this.Controls.Add(pictureBox6);
            this.Controls.Add(pictureBox7);
            this.Controls.Add(pictureBox8);
            this.Controls.Add(pictureBox9);
            this.Controls.Add(pictureBox10);
            this.Controls.Add(pictureBox11);
            this.Controls.Add(pictureBox12);
            this.Controls.Add(pictureBox13);
            this.Controls.Add(pictureBox14);
            this.Controls.Add(pictureBox15);
            this.Controls.Add(pictureBox16);
            this.Controls.Add(pictureBox17);
            this.Controls.Add(pictureBox18);
            this.Controls.Add(pictureBox19);
            this.Controls.Add(pictureBox20);
            this.Controls.Add(pictureBox21);
            this.Controls.Add(pictureBox22);
            this.Controls.Add(pictureBox23);
            this.Controls.Add(pictureBox24);
            this.Controls.Add(pictureBox25);
            this.Controls.Add(pictureBox26);
            this.Controls.Add(pictureBox27);
            this.Controls.Add(pictureBox28);
            this.Controls.Add(pictureBox29);
            this.Controls.Add(pictureBox30);
            this.Controls.Add(pictureBox31);
            this.Controls.Add(pictureBox32);
            this.Controls.Add(pictureBox33);
            this.Controls.Add(pictureBox34);
            this.Controls.Add(pictureBox35);
            this.Controls.Add(pictureBox36);
            this.Controls.Add(pictureBox37);
            this.Controls.Add(pictureBox38);
            this.Controls.Add(pictureBox38);
            this.Controls.Add(pictureBox39);
            this.Controls.Add(pictureBox40);
            this.Controls.Add(pictureBox41);
            this.Controls.Add(pictureBox42);
            this.Controls.Add(pictureBox43);
            this.Controls.Add(pictureBox44);
            this.Controls.Add(pictureBox45);
            this.Controls.Add(pictureBox46);
            this.Controls.Add(pictureBox47);
            this.Controls.Add(pictureBox48);
            this.Controls.Add(pictureBox49);
            this.Controls.Add(pictureBox50);
            this.Controls.Add(pictureBox51);
            this.Controls.Add(pictureBox52);
            this.Controls.Add(pictureBox53);
            this.Controls.Add(pictureBox54);
            this.Controls.Add(pictureBox55);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //        form_Menue.spielGestartet = false;
        }

        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //       form_Menue.spielGestartet = false;
        }

        private void WinButton_Click(object sender, EventArgs e)
        {
            BlockRefresh();
            labelHighscore.Visible = false;
            Ball.Location = new Point(this.Height / 2, this.Width / 2);
            bally = -8;
            Player.Location = new Point(376, 687);
            score = 0;
            EndLabel.Visible = false;
            EndButton.Visible = false;
            closeButton.Visible = false;
            timer1.Start();
            pause = !pause;
            this.Focus();
            return;
        }

        //Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            
            //      form_Menue.spielGestartet = false;
            this.Close();
        }

        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore breakoutHighscore = new Highscore();

            timer1.Stop();

            labelHighscore.Text = breakoutHighscore.EinträgeAnzeigenPunkte("Breakout");
            labelHighscore.Visible = true;

        }
        // Weiter Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Eintragen in die HighscoreListe
            Highscore breakoutHighscore = new Highscore();

            string spieler = textBoxSpieler.Text;

            string punktzahl = PScore.Text;

            labelHighscore.Text = breakoutHighscore.HighscoreEintragen("Breakout", spieler, punktzahl);

            textBoxSpieler.Visible = false;
            buttonWeiter.Visible = false;
            EndButton.Visible = true;
            EndLabel.Visible = true;
            closeButton.Visible = true;
            labelHighscore.Visible = true;

        }
    }
}






