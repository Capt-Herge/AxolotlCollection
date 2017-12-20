using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    public class Game
    {
        int width, height;
        Player player1, player2;
        Ball ball;
        bool pause = false;
        Timer timer = new Timer();

        public event EventHandler GameStateChanged;
        

        public Game(int width, int height)
        {
            this.width = width - 40;
            this.height = height - 60;
            player1 = new Player();
            player2 = new Player();
            ball = new Ball(width / 2, height / 2);
            

            timer.Tick += (a, b) =>
            {
                if (!pause)
                {
                    runChecks();
                    movePlayer();
                    moveBall();
                    GameStateChanged.Invoke(this, null);
                }
            };
            timer.Start();
        }
        

        private void movePlayer()
        {
            player1.move();
            player2.move();
        }

        private void moveBall()
        {
            ball.move();
        }

        private void runChecks()
        {
            if (player1.istouched(ball) || player2.istouched(ball))
                ball.toggleX();
            if (ball.getBall().Y + ball.getBall().Height >= height || ball.getBall().Y <= 0)
                ball.toggleY();
            if (ball.getBall().X + ball.getBall().Width >= width)
            {
                System.Console.WriteLine("Spieler 1 gewinnt");
            }
            if (ball.getBall().X <= 0)
                Console.WriteLine("Spieler 2 gewinnt");
        }

        public void togglePause()
        {
            pause = !pause;
        }

        public void changePlayerMovement(Player player, Player.Direction direction)
        {
            player.setDirection(direction);
        }

        public Ball getBall()
        {
            return ball;
        }

        public Player getPlayer(int i)
        {
            switch(i)
            {
                case 1:
                    return player1;
                case 2:
                    return player2;
                default:
                    return null;
            }
        }
    }    
}
