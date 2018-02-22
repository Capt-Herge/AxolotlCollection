using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class AutoPink : Figuren
    {
        #region bilder
        public int[,] figur { get; set; } = new int[7, 7];
        #endregion

        public AutoPink()
        {
            model = new Pixel[7, 7];

            #region figur
            figur[0, 0] = 14;
            figur[0, 1] = 14;
            figur[0, 2] = 14;
            figur[0, 3] = 14;
            figur[0, 4] = 14;
            figur[0, 5] = 14;
            figur[0, 6] = 14;
            figur[1, 0] = 14;
            figur[1, 1] = 14;
            figur[1, 2] = 14;
            figur[1, 3] = 14;
            figur[1, 4] = 14;
            figur[1, 5] = 14;
            figur[1, 6] = 14;
            figur[2, 0] = 14;
            figur[2, 1] = 14;
            figur[2, 2] = 14;
            figur[2, 3] = 14;
            figur[2, 4] = 14;
            figur[2, 5] = 14;
            figur[2, 6] = 14;
            figur[3, 0] = 14;
            figur[3, 1] = 14;
            figur[3, 2] = 14;
            figur[3, 3] = 14;
            figur[3, 4] = 14;
            figur[3, 5] = 14;
            figur[3, 6] = 14;
            figur[4, 0] = 14;
            figur[4, 1] = 14;
            figur[4, 2] = 14;
            figur[4, 3] = 14;
            figur[4, 4] = 14;
            figur[4, 5] = 14;
            figur[4, 6] = 14;
            figur[5, 0] = 14;
            figur[5, 1] = 14;
            figur[5, 2] = 14;
            figur[5, 3] = 14;
            figur[5, 4] = 14;
            figur[5, 5] = 14;
            figur[5, 6] = 14;
            figur[6, 0] = 14;
            figur[6, 1] = 14;
            figur[6, 2] = 14;
            figur[6, 3] = 14;
            figur[6, 4] = 14;
            figur[6, 5] = 14;
            figur[6, 6] = 14;
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