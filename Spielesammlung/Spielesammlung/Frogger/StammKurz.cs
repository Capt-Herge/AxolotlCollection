using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class StammKurz : Figuren
    {
        #region bilder
        public int[,] figur { get; set; } = new int[7, 14];
        #endregion

        public StammKurz()
        {
            model = new Pixel[7, 14];

            #region figur
            figur[0, 0] = 12;
            figur[0, 1] = 12;
            figur[0, 2] = 12;
            figur[0, 3] = 12;
            figur[0, 4] = 12;
            figur[0, 5] = 12;
            figur[0, 6] = 12;
            figur[0, 7] = 12;
            figur[0, 8] = 12;
            figur[0, 9] = 12;
            figur[0, 10] = 12;
            figur[0, 11] = 12;
            figur[0, 12] = 12;
            figur[0, 13] = 12;
            figur[1, 0] = 12;
            figur[1, 1] = 0;
            figur[1, 2] = 12;
            figur[1, 3] = 12;
            figur[1, 4] = 0;
            figur[1, 5] = 12;
            figur[1, 6] = 12;
            figur[1, 7] = 12;
            figur[1, 8] = 12;
            figur[1, 9] = 0;
            figur[1, 10] = 12;
            figur[1, 11] = 12;
            figur[1, 12] = 12;
            figur[1, 13] = 12;
            figur[2, 0] = 12;
            figur[2, 1] = 12;
            figur[2, 2] = 12;
            figur[2, 3] = 12;
            figur[2, 4] = 12;
            figur[2, 5] = 12;
            figur[2, 6] = 0;
            figur[2, 7] = 12;
            figur[2, 8] = 12;
            figur[2, 9] = 12;
            figur[2, 10] = 12;
            figur[2, 11] = 12;
            figur[2, 12] = 12;
            figur[2, 13] = 12;
            figur[3, 0] = 12;
            figur[3, 1] = 12;
            figur[3, 2] = 12;
            figur[3, 3] = 0;
            figur[3, 4] = 12;
            figur[3, 5] = 12;
            figur[3, 6] = 12;
            figur[3, 7] = 12;
            figur[3, 8] = 0;
            figur[3, 9] = 12;
            figur[3, 10] = 12;
            figur[3, 11] = 12;
            figur[3, 12] = 0;
            figur[3, 13] = 12;
            figur[4, 0] = 0;
            figur[4, 1] = 12;
            figur[4, 2] = 12;
            figur[4, 3] = 12;
            figur[4, 4] = 12;
            figur[4, 5] = 12;
            figur[4, 6] = 12;
            figur[4, 7] = 12;
            figur[4, 8] = 12;
            figur[4, 9] = 12;
            figur[4, 10] = 12;
            figur[4, 11] = 12;
            figur[4, 12] = 12;
            figur[4, 13] = 12;
            figur[5, 0] = 12;
            figur[5, 1] = 12;
            figur[5, 2] = 12;
            figur[5, 3] = 0;
            figur[5, 4] = 12;
            figur[5, 5] = 12;
            figur[5, 6] = 12;
            figur[5, 7] = 12;
            figur[5, 8] = 12;
            figur[5, 9] = 12;
            figur[5, 10] = 0;
            figur[5, 11] = 12;
            figur[5, 12] = 12;
            figur[5, 13] = 12;
            figur[6, 0] = 12;
            figur[6, 1] = 12;
            figur[6, 2] = 12;
            figur[6, 3] = 12;
            figur[6, 4] = 0;
            figur[6, 5] = 12;
            figur[6, 6] = 12;
            figur[6, 7] = 12;
            figur[6, 8] = 12;
            figur[6, 9] = 12;
            figur[6, 10] = 12;
            figur[6, 11] = 0;
            figur[6, 12] = 12;
            figur[6, 13] = 12;
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
