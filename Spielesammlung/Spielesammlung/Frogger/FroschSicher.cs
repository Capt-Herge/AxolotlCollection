using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class FroschSicher : Figuren
    {
        #region bilder
        public int[,] figur { get; set; } = new int[7, 7];
        #endregion

        public FroschSicher()
        {
            model = new Pixel[7, 7];

            #region figur
            figur[0, 0] = 0;
            figur[0, 1] = 17;
            figur[0, 2] = 0;
            figur[0, 3] = 0;
            figur[0, 4] = 0;
            figur[0, 5] = 17;
            figur[0, 6] = 0;
            figur[1, 0] = 17;
            figur[1, 1] = 0;
            figur[1, 2] = 17;
            figur[1, 3] = 0;
            figur[1, 4] = 17;
            figur[1, 5] = 0;
            figur[1, 6] = 17;
            figur[2, 0] = 0;
            figur[2, 1] = 17;
            figur[2, 2] = 17;
            figur[2, 3] = 17;
            figur[2, 4] = 17;
            figur[2, 5] = 17;
            figur[2, 6] = 0;
            figur[3, 0] = 17;
            figur[3, 1] = 17;
            figur[3, 2] = 0;
            figur[3, 3] = 17;
            figur[3, 4] = 0;
            figur[3, 5] = 17;
            figur[3, 6] = 17;
            figur[4, 0] = 0;
            figur[4, 1] = 17;
            figur[4, 2] = 0;
            figur[4, 3] = 0;
            figur[4, 4] = 0;
            figur[4, 5] = 17;
            figur[4, 6] = 0;
            figur[5, 0] = 0;
            figur[5, 1] = 0;
            figur[5, 2] = 17;
            figur[5, 3] = 17;
            figur[5, 4] = 17;
            figur[5, 5] = 0;
            figur[5, 6] = 0;
            figur[6, 0] = 17;
            figur[6, 1] = 17;
            figur[6, 2] = 0;
            figur[6, 3] = 0;
            figur[6, 4] = 0;
            figur[6, 5] = 17;
            figur[6, 6] = 17;
            #endregion

            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i] = new Pixel();
                }
            }

            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = figur[j, i];
                }
            }
        }
    }
}