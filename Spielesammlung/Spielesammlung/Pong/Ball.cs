using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pong
{
    public class Ball
    {
        Rectangle ball = new Rectangle() { Width = 20, Height = 20 };
        int velocityX = 5, velocityY = 5;

        public Ball(int x, int y)
        {
            ball.X = x;
            ball.Y = y;
        }  

        public Rectangle getBall() { return ball; }

        public void move()
        {
            ball.Location = new Point(ball.X + velocityX, ball.Y + velocityY);
        }

        public void toggleX()
        {
            velocityX = - velocityX;
        }

        public void toggleY()
        {
            velocityY = -velocityY;
        }
    }
}
