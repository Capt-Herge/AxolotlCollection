using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class AutoWeiss : Figuren
    {
        #region bilder
        public int[,] figur { get; set; } = new int[7, 14];
        #endregion

        public AutoWeiss()
        {
            model = new Pixel[7, 14];

            #region figur
            figur[0, 0] = 0;
            figur[0, 1] = 0;
            figur[0, 2] = 15;
            figur[0, 3] = 15;
            figur[0, 4] = 0;
            figur[0, 5] = 0;
            figur[0, 6] = 15;
            figur[0, 7] = 15;
            figur[0, 8] = 15;
            figur[0, 9] = 15;
            figur[0, 10] = 15;
            figur[0, 11] = 15;
            figur[0, 12] = 15;
            figur[0, 13] = 15;
            figur[1, 0] = 15;
            figur[1, 1] = 15;
            figur[1, 2] = 15;
            figur[1, 3] = 15;
            figur[1, 4] = 15;
            figur[1, 5] = 15;
            figur[1, 6] = 15;
            figur[1, 7] = 15;
            figur[1, 8] = 15;
            figur[1, 9] = 15;
            figur[1, 10] = 15;
            figur[1, 11] = 15;
            figur[1, 12] = 15;
            figur[1, 13] = 15;
            figur[2, 0] = 15;
            figur[2, 1] = 15;
            figur[2, 2] = 15;
            figur[2, 3] = 15;
            figur[2, 4] = 15;
            figur[2, 5] = 15;
            figur[2, 6] = 15;
            figur[2, 7] = 15;
            figur[2, 8] = 15;
            figur[2, 9] = 15;
            figur[2, 10] = 15;
            figur[2, 11] = 15;
            figur[2, 12] = 15;
            figur[2, 13] = 15;
            figur[3, 0] = 15;
            figur[3, 1] = 15;
            figur[3, 2] = 15;
            figur[3, 3] = 15;
            figur[3, 4] = 15;
            figur[3, 5] = 15;
            figur[3, 6] = 15;
            figur[3, 7] = 15;
            figur[3, 8] = 15;
            figur[3, 9] = 15;
            figur[3, 10] = 15;
            figur[3, 11] = 15;
            figur[3, 12] = 15;
            figur[3, 13] = 15;
            figur[4, 0] = 15;
            figur[4, 1] = 15;
            figur[4, 2] = 15;
            figur[4, 3] = 15;
            figur[4, 4] = 15;
            figur[4, 5] = 15;
            figur[4, 6] = 15;
            figur[4, 7] = 15;
            figur[4, 8] = 15;
            figur[4, 9] = 15;
            figur[4, 10] = 15;
            figur[4, 11] = 15;
            figur[4, 12] = 15;
            figur[4, 13] = 15;
            figur[5, 0] = 15;
            figur[5, 1] = 15;
            figur[5, 2] = 15;
            figur[5, 3] = 15;
            figur[5, 4] = 15;
            figur[5, 5] = 15;
            figur[5, 6] = 15;
            figur[5, 7] = 15;
            figur[5, 8] = 15;
            figur[5, 9] = 15;
            figur[5, 10] = 15;
            figur[5, 11] = 15;
            figur[5, 12] = 15;
            figur[5, 13] = 15;
            figur[6, 0] = 0;
            figur[6, 1] = 0;
            figur[6, 2] = 15;
            figur[6, 3] = 15;
            figur[6, 4] = 0;
            figur[6, 5] = 0;
            figur[6, 6] = 15;
            figur[6, 7] = 15;
            figur[6, 8] = 15;
            figur[6, 9] = 15;
            figur[6, 10] = 15;
            figur[6, 11] = 15;
            figur[6, 12] = 15;
            figur[6, 13] = 15;
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
