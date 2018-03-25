using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Flappy_Bird.Resources
{
    class Ground
    {
        int GroundPosX;

        public Ground(int groundPosX)
        {
            GroundPosX1 = groundPosX;
        }

        public int GroundPosX1
        {
            get
            {
                return GroundPosX;
            }

            set
            {
                GroundPosX = value;
            }
        }
    }
}
