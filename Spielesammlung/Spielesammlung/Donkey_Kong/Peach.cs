using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Peach : Figuren
    {
        #region bilder
        public int[,] stehAnimation { get; set; } = new int[17,9];
        #endregion

        public Peach()
        {
            model = new Pixel[17, 9];

            #region stehAnimation
            stehAnimation[0, 0] = 0;
            stehAnimation[0, 1] = 0;
            stehAnimation[0, 2] = 0;
            stehAnimation[0, 3] = 0;
            stehAnimation[0, 4] = 0;
            stehAnimation[0, 5] = 0;
            stehAnimation[0, 6] = 9;
            stehAnimation[0, 7] = 9;
            stehAnimation[0, 8] = 9;
            stehAnimation[1, 0] = 0;
            stehAnimation[1, 1] = 0;
            stehAnimation[1, 2] = 0;
            stehAnimation[1, 3] = 9;
            stehAnimation[1, 4] = 9;
            stehAnimation[1, 5] = 9;
            stehAnimation[1, 6] = 9;
            stehAnimation[1, 7] = 9;
            stehAnimation[1, 8] = 9;
            stehAnimation[2, 0] = 0;
            stehAnimation[2, 1] = 0;
            stehAnimation[2, 2] = 9;
            stehAnimation[2, 3] = 9;
            stehAnimation[2, 4] = 9;
            stehAnimation[2, 5] = 9;
            stehAnimation[2, 6] = 0;
            stehAnimation[2, 7] = 9;
            stehAnimation[2, 8] = 0;
            stehAnimation[3, 0] = 9;
            stehAnimation[3, 1] = 0;
            stehAnimation[3, 2] = 9;
            stehAnimation[3, 3] = 9;
            stehAnimation[3, 4] = 9;
            stehAnimation[3, 5] = 9;
            stehAnimation[3, 6] = 9;
            stehAnimation[3, 7] = 9;
            stehAnimation[3, 8] = 9;
            stehAnimation[4, 0] = 0;
            stehAnimation[4, 1] = 9;
            stehAnimation[4, 2] = 9;
            stehAnimation[4, 3] = 9;
            stehAnimation[4, 4] = 9;
            stehAnimation[4, 5] = 9;
            stehAnimation[4, 6] = 9;
            stehAnimation[4, 7] = 9;
            stehAnimation[4, 8] = 0;
            stehAnimation[5, 0] = 9;
            stehAnimation[5, 1] = 0;
            stehAnimation[5, 2] = 0;
            stehAnimation[5, 3] = 9;
            stehAnimation[5, 4] = 9;
            stehAnimation[5, 5] = 9;
            stehAnimation[5, 6] = 0;
            stehAnimation[5, 7] = 0;
            stehAnimation[5, 8] = 0;
            stehAnimation[6, 0] = 0;
            stehAnimation[6, 1] = 0;
            stehAnimation[6, 2] = 3;
            stehAnimation[6, 3] = 3;
            stehAnimation[6, 4] = 3;
            stehAnimation[6, 5] = 3;
            stehAnimation[6, 6] = 0;
            stehAnimation[6, 7] = 0;
            stehAnimation[6, 8] = 0;
            stehAnimation[7, 0] = 0;
            stehAnimation[7, 1] = 3;
            stehAnimation[7, 2] = 3;
            stehAnimation[7, 3] = 3;
            stehAnimation[7, 4] = 3;
            stehAnimation[7, 5] = 3;
            stehAnimation[7, 6] = 3;
            stehAnimation[7, 7] = 3;
            stehAnimation[7, 8] = 0;
            stehAnimation[8, 0] = 0;
            stehAnimation[8, 1] = 0;
            stehAnimation[8, 2] = 0;
            stehAnimation[8, 3] = 4;
            stehAnimation[8, 4] = 4;
            stehAnimation[8, 5] = 4;
            stehAnimation[8, 6] = 0;
            stehAnimation[8, 7] = 0;
            stehAnimation[8, 8] = 0;
            stehAnimation[9, 0] = 0;
            stehAnimation[9, 1] = 0;
            stehAnimation[9, 2] = 3;
            stehAnimation[9, 3] = 3;
            stehAnimation[9, 4] = 3;
            stehAnimation[9, 5] = 3;
            stehAnimation[9, 6] = 3;
            stehAnimation[9, 7] = 0;
            stehAnimation[9, 8] = 0;
            stehAnimation[10, 0] = 0;
            stehAnimation[10, 1] = 3;
            stehAnimation[10, 2] = 3;
            stehAnimation[10, 3] = 3;
            stehAnimation[10, 4] = 3;
            stehAnimation[10, 5] = 3;
            stehAnimation[10, 6] = 3;
            stehAnimation[10, 7] = 3;
            stehAnimation[10, 8] = 0;
            stehAnimation[11, 0] = 0;
            stehAnimation[11, 1] = 3;
            stehAnimation[11, 2] = 3;
            stehAnimation[11, 3] = 3;
            stehAnimation[11, 4] = 3;
            stehAnimation[11, 5] = 3;
            stehAnimation[11, 6] = 3;
            stehAnimation[11, 7] = 3;
            stehAnimation[11, 8] = 3;
            stehAnimation[12, 0] = 3;
            stehAnimation[12, 1] = 3;
            stehAnimation[12, 2] = 3;
            stehAnimation[12, 3] = 3;
            stehAnimation[12, 4] = 3;
            stehAnimation[12, 5] = 3;
            stehAnimation[12, 6] = 3;
            stehAnimation[12, 7] = 3;
            stehAnimation[12, 8] = 3;
            stehAnimation[13, 0] = 0;
            stehAnimation[13, 1] = 3;
            stehAnimation[13, 2] = 3;
            stehAnimation[13, 3] = 3;
            stehAnimation[13, 4] = 3;
            stehAnimation[13, 5] = 3;
            stehAnimation[13, 6] = 3;
            stehAnimation[13, 7] = 0;
            stehAnimation[13, 8] = 0;
            stehAnimation[14, 0] = 0;
            stehAnimation[14, 1] = 3;
            stehAnimation[14, 2] = 3;
            stehAnimation[14, 3] = 3;
            stehAnimation[14, 4] = 3;
            stehAnimation[14, 5] = 3;
            stehAnimation[14, 6] = 3;
            stehAnimation[14, 7] = 0;
            stehAnimation[14, 8] = 0;
            stehAnimation[15, 0] = 9;
            stehAnimation[15, 1] = 0;
            stehAnimation[15, 2] = 0;
            stehAnimation[15, 3] = 0;
            stehAnimation[15, 4] = 0;
            stehAnimation[15, 5] = 9;
            stehAnimation[15, 6] = 9;
            stehAnimation[15, 7] = 0;
            stehAnimation[15, 8] = 0;
            stehAnimation[16, 0] = 0;
            stehAnimation[16, 1] = 9;
            stehAnimation[16, 2] = 9;
            stehAnimation[16, 3] = 0;
            stehAnimation[16, 4] = 0;
            stehAnimation[16, 5] = 9;
            stehAnimation[16, 6] = 9;
            stehAnimation[16, 7] = 9;
            stehAnimation[16, 8] = 9;
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
                    model[j, i].farbe = stehAnimation[j, i];
                }
            }

        }
    }
}
