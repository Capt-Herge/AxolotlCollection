using Spielesammlung;
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
        //Variablen deklariert
        int playerSpeed = 5;
        int ballVelocityX = 3;
        int ballVelocityY = 3;

        int p1Velocity;
        int P2Velocity;

        int p1Score;
        int p2Score;

        bool pause = false;
        bool randObenLinks = false;
        bool randUntenLinks = false;
        bool randObenRechts = false;
        bool randUntenRechts = false;
        public Form1()
        {
            InitializeComponent();
            pause = true;
            string anleitung = " Steuere die Platten mit W,S (Spieler 1) und Pfeil-Oben, Pfeil-Unten (Spieler 2) \n Versuche den Ball am Gegner vorbei zu schießen um einen Punkt zu erhalten. \n Wer zuerst 5 Punkte erzielt gewinnt!";
            labelAnleitung.Text = anleitung;
            labelAnleitung.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                Ball.Location = new Point(Ball.Location.X + ballVelocityX, Ball.Location.Y + ballVelocityY);
                if (randObenLinks == false || randObenRechts == false || randUntenLinks == false || randUntenRechts == false)
                {
                    Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + p1Velocity);
                    Player2.Location = new Point(Player2.Location.X, Player2.Location.Y + P2Velocity);
                }

                if (Player1.Location.Y <= 20)
                {
                    randObenLinks = true;
                }
                if (randObenLinks == true)
                {
                    Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + 5);
                    randObenLinks = false;
                }
                if (Player2.Location.Y <= 20)
                {
                    randObenRechts = true;
                }
                if (randObenRechts == true)
                {
                    Player2.Location = new Point(Player2.Location.X, Player2.Location.Y + 5);
                    randObenRechts = false;
                }


                if (Player1.Location.Y + Player1.Height + 35 >= this.Height)
                {
                    randUntenLinks = true;
                }
                if (randUntenLinks == true)
                {
                    Player1.Location = new Point(Player1.Location.X, Player1.Location.Y - 5);
                    randUntenLinks = false;
                }

                if (Player2.Location.Y + Player2.Height + 35 >= this.Height)
                {
                    randUntenRechts = true;
                }
                if (randUntenRechts == true)
                {
                    Player2.Location = new Point(Player2.Location.X, Player2.Location.Y - 5);
                    randUntenRechts = false;
                }


                if (Ball.Location.X < 0)
                {
                    p2Score++;
                    ballVelocityX = -3;
                    Ball.Location = new Point(this.Height / 2, this.Width / 2);

                }
                if (Ball.Location.X > this.Width)
                {
                    p1Score++;
                    ballVelocityX = 3;
                    Ball.Location = new Point(this.Height / 2, this.Width / 2);
                }

                if (Ball.Bounds.IntersectsWith(Player1.Bounds))
                {
                    ballVelocityX *= -1;
                    ballVelocityX++;
                }

                if (Ball.Bounds.IntersectsWith(Player2.Bounds))
                {
                    ballVelocityX *= -1;
                    ballVelocityX--;
                }

                if (Ball.Location.Y + Ball.Height * 3 < this.Height)
                {
                    ballVelocityY *= -1;
                }
                if (Ball.Location.Y > 20)
                {
                    ballVelocityY *= -1;
                }

                Player1Score.Text = p1Score.ToString();
                Player2Score.Text = p2Score.ToString();
                //Sieg Spieler 1
                if (p1Score == 5)
                {
                    timer1.Stop();
                    WinButton.Visible = true;
                    closeButton.Visible = true;
                    WinButton.Text = "Spieler 1 hat gewonnen!\n Nochmal spielen?";
                }
                //Sieg Spieler 2
                if (p2Score == 5)
                {
                    timer1.Stop();
                    WinButton.Visible = true;
                    closeButton.Visible = true;
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

        //Sieg Button
        private void button1_Click(object sender, EventArgs e)
        {

            p1Score = 0;
            p2Score = 0;
            p1Velocity = 0;
            P2Velocity = 0;
            ballVelocityX = 3;
            WinButton.Visible = false;
            closeButton.Visible = false;
            Player1.Location = new Point(Player1.Location.X, this.Height / 3);
            Player2.Location = new Point(Player2.Location.X, this.Height / 3);
            timer1.Start();
            this.Focus();
            return;
        }
        // Start Button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            pause = !pause;
            labelAnleitung.Visible = false;
            this.Focus();
        }

        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1Score = 0;
            p2Score = 0;
            p1Velocity = 0;
            P2Velocity = 0;
            ballVelocityX = 3;
            Ball.Location = new Point(this.Height / 2, this.Width / 2);
            Player1.Location = new Point(Player1.Location.X, this.Height / 3);
            Player2.Location = new Point(Player2.Location.X, this.Height / 3);
            timer1.Start();
            pause = !pause;
            this.Focus();
            return;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Menue.spielGestartet = false;
        }

        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Menue.spielGestartet = false;
        }
        // Schließen Button
        private void closeButton_Click(object sender, EventArgs e)
        {
            form_Menue.spielGestartet = false;
            this.Close();
        }
    }
}
            
        
