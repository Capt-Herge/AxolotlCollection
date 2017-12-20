using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pong
{
    public class Player
    {
        Rectangle rectangle = new Rectangle() { Width = 20, Height = 100, Y = 164 };
        int velocity = 0;
        int speed = 10;
        Direction direction = Direction.none;


        public int getY()
        {
            return rectangle.Y;
        }

        public void setY(int y)
        {
            rectangle.X = 559;
            rectangle.Y = y;
        }

        public void setDirection(Direction direction)
        {
            this.direction = direction;
        }

        public void move()
        {
            switch(direction)
            {
                case Direction.none:
                    break;
                case Direction.up:
                    rectangle.Y -= speed;
                    break;
                case Direction.down:
                    rectangle.Y += speed;
                    break;
            }
        }

        public bool istouched(Ball ball)
        {
            Point ballTopLeft = new Point(ball.getBall().X, ball.getBall().Y);
            Point ballTopRight = new Point(ball.getBall().X + ball.getBall().Width, ball.getBall().Y);
            Point ballBotRight = new Point(ball.getBall().X, ball.getBall().Y + ball.getBall().Height);
            Point ballBotLeft = new Point(ball.getBall().X + ball.getBall().Width, ball.getBall().Y + ball.getBall().Height);

            Point recTopLeft = new Point(rectangle.X, rectangle.Y);
            Point recTopRight = new Point(rectangle.X + rectangle.Width, rectangle.Y);
            Point recBotright = new Point(rectangle.X, rectangle.Y + rectangle.Height);
            Point recBotLeft = new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);

            if (ballTopLeft.X <= recTopRight.X)
                return willbeTouched(recTopRight, recBotright, ballTopLeft, ballBotLeft);
            if (ballTopRight.X >= recTopLeft.X)
                return willbeTouched(recTopLeft, recBotLeft, ballTopRight, ballTopLeft);
            return false;
        }

        bool willbeTouched(Point playerPointTop, Point playerPointBot, Point ballPointTop, Point ballPointBot)
        {
            return (playerPointTop.Y <= ballPointBot.Y && playerPointBot.Y >= ballPointTop.Y);
        }
        public enum Direction
        {
            up, down, none
        }
    }
}
