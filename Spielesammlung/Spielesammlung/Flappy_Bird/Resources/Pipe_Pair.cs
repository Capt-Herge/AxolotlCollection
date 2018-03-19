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
            this.pipePairPosx = pipePairPosx;
            this.pipePairPosy = pipePairPosy;
        }

        public int PipePairPosx { get => pipePairPosx; set => pipePairPosx = value; }
        public int PipePairPosy { get => pipePairPosy; set => pipePairPosy = value; }
        public bool Scored { get => scored; set => scored = value; }
    }
}
