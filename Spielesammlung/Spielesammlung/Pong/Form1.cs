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
        Game game;

        int playerSpeed = 5;
        int ballSpeed;

        int ballVelocityX = 2;
        int ballVelocityY = 2;

        int p1Velocity;
        int P2Velocity;

        int p1Score;
        int p2Score;


        bool pause = false;
        
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            game = new Game(Width, Height);
            game.GameStateChanged += Game_GameStateChanged;

        }

        private void Game_GameStateChanged(object sender, EventArgs e)
        {
            Player1.Location = new Point(Player1.Location.X, game.getPlayer(1).getY());
            Player2.Location = new Point(Player2.Location.X, game.getPlayer(2).getY());
            Ball.Location = game.getBall().getBall().Location;
            //TODO punkte aktualisieren, auf pause prüfen, Punktelogik einfügen :)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!pause)
            {
                Ball.Location = new Point(Ball.Location.X + ballVelocityX, Ball.Location.Y + ballVelocityY);
                Player1.Location = new Point(Player1.Location.X, Player1.Location.Y + p1Velocity);
                Player2.Location = new Point(Player2.Location.X, Player2.Location.Y + P2Velocity);
            }

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

            if (abprallenPaddle1())
            {
                ballVelocityX *= -1;
            }
            if (abprallenPaddle2())
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
                pause = true;
                WinButton.Visible = true;
                WinButton.Text = "Spieler 1 hat gewonnen!\n Nochmal spielen?";
            }

            if (p2Score == 1)
            {
                pause = true;
                WinButton.Visible = true;
                WinButton.Text = "Spieler 2 hat gewonnen!\n Nochmal spielen?";
            }
        }

        private bool abprallenPaddle1()
        {
            if ((Ball.Location.X <= Player1.Location.X + Player1.Width) && (Ball.Location.Y + Ball.Height / 2 >= Player1.Location.Y) && (Ball.Location.Y + Ball.Height / 2 <= Player1.Location.Y + Player1.Height))
            { return true; }
            return false;
        }

        private bool abprallenPaddle2()
        {
            if ((Ball.Location.X <= Player2.Location.X) && (Ball.Location.Y + 20 + Ball.Height / 2 >= Player2.Location.Y) && (Ball.Location.Y + 20 + Ball.Height / 2 <= Player2.Location.Y + Player2.Height))
            { return true; }
            return false;
        }
        */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                game.changePlayerMovement(game.getPlayer(1), Player.Direction.up);
            }
            else if (e.KeyCode == Keys.S)
            {
                game.changePlayerMovement(game.getPlayer(1), Player.Direction.down);
            }
            else if (e.KeyCode == Keys.Up)
            {
                game.changePlayerMovement(game.getPlayer(2), Player.Direction.up);
            }
            else if (e.KeyCode == Keys.Down)
            {
                game.changePlayerMovement(game.getPlayer(2), Player.Direction.down);
            }
            else if (e.KeyCode == Keys.P)
            {
                game.togglePause();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                case Keys.S:
                    game.changePlayerMovement(game.getPlayer(1), Player.Direction.none);
                    break;
                case Keys.Up:
                case Keys.Down:
                    game.changePlayerMovement(game.getPlayer(2), Player.Direction.none);
                    break;
            }
        }
/*
        private void button1_Click(object sender, EventArgs e)
        {
            p1Score = 0;
            p2Score = 0;
            WinButton.Visible = false;
            Player1.Location = new Point(Player1.Location.X, this.Height / 3);
            Player2.Location = new Point(Player2.Location.X, this.Height / 3);
            pause = false;
            return;
        }
        */
    }
}
