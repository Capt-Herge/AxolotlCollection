using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {

        int playerSpeed = 5;
        int ballSpeed;

        int ballVelocityX = 3;
        int ballVelocityY = 3;

        int p1Velocity;
        int P2Velocity;

        int p1Score;
        int p2Score;

        bool pause = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                Ball.Location = new Point(Ball.Location.X + ballVelocityX, Ball.Location.Y + ballVelocityY);
                Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + p1Velocity);
                Player2.Location = new Point(Player2.Location.X, Player2.Location.Y + P2Velocity);


                if (Ball.Location.X < 0)
                {
                    p2Score++;
                    Ball.Location = new Point(this.Height / 2, this.Width / 2);

                }
                if (Ball.Location.X > this.Width)
                {
                    p1Score++;
                    Ball.Location = new Point(this.Height / 2, this.Width / 2);
                }

                if (Ball.Bounds.IntersectsWith(Player1.Bounds))
                {
                    ballVelocityX *= -1;
                }

                if (Ball.Bounds.IntersectsWith(Player2.Bounds))
                {
                    ballVelocityX *= -1;
                }


                if (Ball.Location.Y + Ball.Height * 3 < this.Height)
                {
                    ballVelocityY *= -1;
                }
                if (Ball.Location.Y > 0)
                {
                    ballVelocityY *= -1;
                }

                Player1Score.Text = p1Score.ToString();
                Player2Score.Text = p2Score.ToString();

                if (p1Score == 1)
                {
                    timer1.Stop();
                    WinButton.Visible = true;
                    WinButton.Text = "Spieler 1 hat gewonnen!\n Nochmal spielen?";
                }

                if (p2Score == 1)
                {
                    timer1.Stop();
                    WinButton.Visible = true;
                    WinButton.Text = "Spieler 2 hat gewonnen!\n Nochmal spielen?";
                }


            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1Velocity = -playerSpeed;
            }
            else if (e.KeyCode == Keys.S)
            {
                p1Velocity = playerSpeed;
            }
            else if (e.KeyCode == Keys.Up)
            {
                P2Velocity = -playerSpeed;
            }
            else if (e.KeyCode == Keys.Down)
            {
                P2Velocity = playerSpeed;
            }
            else if (e.KeyCode == Keys.P)
            {
                if (!pause)
                {
                    pause = true;
                    pauseLabel.Visible = true;
                    Console.Beep();
                }
                else if (pause)
                {
                    pause = false;
                    pauseLabel.Visible = false;
                    Console.Beep();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                p1Velocity = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                p1Velocity = 0;
            }
            else if (e.KeyCode == Keys.Up)
            {
                P2Velocity = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                P2Velocity = 0;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            p1Score = 0;
            p2Score = 0;
            WinButton.Visible = false;
            Player1.Location = new Point(Player1.Location.X, this.Height / 3);
            Player2.Location = new Point(Player2.Location.X, this.Height / 3);
            timer1.Start();
            this.Focus();
            return;
        }


    }


}
