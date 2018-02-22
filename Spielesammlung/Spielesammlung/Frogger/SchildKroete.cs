using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class SchildKroete : Figuren
    {
        #region bilder
        public int[,] oben { get; set; } = new int[7, 7];
        public int[,] unten { get; set; } = new int[7, 7];
        #endregion

        public SchildKroete()
        {
            model = new Pixel[7, 7];

            #region oben
            oben[0, 0] = 0;
            oben[0, 1] = 0;
            oben[0, 2] = 4;
            oben[0, 3] = 4;
            oben[0, 4] = 4;
            oben[0, 5] = 0;
            oben[0, 6] = 0;
            oben[1, 0] = 0;
            oben[1, 1] = 4;
            oben[1, 2] = 4;
            oben[1, 3] = 4;
            oben[1, 4] = 4;
            oben[1, 5] = 4;
            oben[1, 6] = 0;
            oben[2, 0] = 4;
            oben[2, 1] = 4;
            oben[2, 2] = 4;
            oben[2, 3] = 4;
            oben[2, 4] = 4;
            oben[2, 5] = 4;
            oben[2, 6] = 4;
            oben[3, 0] = 4;
            oben[3, 1] = 4;
            oben[3, 2] = 4;
            oben[3, 3] = 4;
            oben[3, 4] = 4;
            oben[3, 5] = 4;
            oben[3, 6] = 4;
            oben[4, 0] = 4;
            oben[4, 1] = 4;
            oben[4, 2] = 4;
            oben[4, 3] = 4;
            oben[4, 4] = 4;
            oben[4, 5] = 4;
            oben[4, 6] = 4;
            oben[5, 0] = 0;
            oben[5, 1] = 4;
            oben[5, 2] = 4;
            oben[5, 3] = 4;
            oben[5, 4] = 4;
            oben[5, 5] = 4;
            oben[5, 6] = 0;
            oben[6, 0] = 0;
            oben[6, 1] = 0;
            oben[6, 2] = 4;
            oben[6, 3] = 4;
            oben[6, 4] = 4;
            oben[6, 5] = 0;
            oben[6, 6] = 0;
            #endregion

            #region unten
            oben[0, 0] = 0;
            oben[0, 1] = 0;
            oben[0, 2] = 16;
            oben[0, 3] = 16;
            oben[0, 4] = 16;
            oben[0, 5] = 0;
            oben[0, 6] = 0;
            oben[1, 0] = 0;
            oben[1, 1] = 16;
            oben[1, 2] = 16;
            oben[1, 3] = 16;
            oben[1, 4] = 16;
            oben[1, 5] = 16;
            oben[1, 6] = 0;
            oben[2, 0] = 16;
            oben[2, 1] = 16;
            oben[2, 2] = 16;
            oben[2, 3] = 16;
            oben[2, 4] = 16;
            oben[2, 5] = 16;
            oben[2, 6] = 16;
            oben[3, 0] = 16;
            oben[3, 1] = 16;
            oben[3, 2] = 16;
            oben[3, 3] = 16;
            oben[3, 4] = 16;
            oben[3, 5] = 16;
            oben[3, 6] = 16;
            oben[4, 0] = 16;
            oben[4, 1] = 16;
            oben[4, 2] = 16;
            oben[4, 3] = 16;
            oben[4, 4] = 16;
            oben[4, 5] = 16;
            oben[4, 6] = 16;
            oben[5, 0] = 0;
            oben[5, 1] = 16;
            oben[5, 2] = 16;
            oben[5, 3] = 16;
            oben[5, 4] = 16;
            oben[5, 5] = 16;
            oben[5, 6] = 0;
            oben[6, 0] = 0;
            oben[6, 1] = 0;
            oben[6, 2] = 16;
            oben[6, 3] = 16;
            oben[6, 4] = 16;
            oben[6, 5] = 0;
            oben[6, 6] = 0;
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
                    model[j, i].farbe = oben[j, i];
                }
            }
        }

        public void tauchen()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = unten[j, i];
                }
            }
        }

    }
}
