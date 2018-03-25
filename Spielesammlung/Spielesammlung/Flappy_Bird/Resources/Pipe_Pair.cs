using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Flappy_Bird.Resources
{
    class Pipe_Pair
    {
        int pipePairPosx;
        int pipePairPosy;
        bool scored = false;
        public Pipe_Pair(int pipePairPosx, int pipePairPosy)
        {
            this.PipePairPosx = pipePairPosx;
            this.PipePairPosy = pipePairPosy;
        }

        public int PipePairPosx
        {
            get
            {
                return pipePairPosx;
            }

            set
            {
                pipePairPosx = value;
            }
        }

        public int PipePairPosy
        {
            get
            {
                return pipePairPosy;
            }

            set
            {
                pipePairPosy = value;
            }
        }

        public bool Scored
        {
            get
            {
                return scored;
            }

            set
            {
                scored = value;
            }
        }
    }
}
