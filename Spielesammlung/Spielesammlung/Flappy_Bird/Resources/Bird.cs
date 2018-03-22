using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Flappy_Bird.Resources
{
    class Bird
    {
        int birdPosx;
        int birdPosy;

        public Bird( int birdPosy)
        {
            this.birdPosy = birdPosy;
            this.birdPosx = 240;
        }

        public int BirdPosx { get => birdPosx; set => birdPosx = value; }
        public int BirdPosy { get => birdPosy; set => birdPosy = value; }
    }
}
