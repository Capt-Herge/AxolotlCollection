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

        bool pause = false;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

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
                if (Ball.Top < 0 || Ball.Bounds.IntersectsWith(Player.Bounds))
                {
                    bally = -bally;
                }
                if (Ball.Top + Ball.Height > ClientSize.Height)
                {
                    gameOver();
                    MessageBox.Show("Sie haben verloren");
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
                    MessageBox.Show("Sie haben gewonnen");
                }
            }
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


    }
}





