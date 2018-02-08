using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Feuer : Figuren
    {
        public int ebene { get; set; } = 1;
        #region bilder
        public int[,] linksSchwebAnimation { get; set; } = new int[8, 8];
        public int[,] rechtsSchwebAnimation { get; set; } = new int[8, 8];
        #endregion

        public Feuer()
        {
            model = new Pixel[8, 8];

            #region linksSchwebAnimation
            linksSchwebAnimation[0, 0] = 0;
            linksSchwebAnimation[0, 1] = 7;
            linksSchwebAnimation[0, 2] = 7;
            linksSchwebAnimation[0, 3] = 7;
            linksSchwebAnimation[0, 4] = 0;
            linksSchwebAnimation[0, 5] = 0;
            linksSchwebAnimation[0, 6] = 0;
            linksSchwebAnimation[0, 7] = 7;
            linksSchwebAnimation[1, 0] = 7;
            linksSchwebAnimation[1, 1] = 0;
            linksSchwebAnimation[1, 2] = 7;
            linksSchwebAnimation[1, 3] = 0;
            linksSchwebAnimation[1, 4] = 7;
            linksSchwebAnimation[1, 5] = 0;
            linksSchwebAnimation[1, 6] = 7;
            linksSchwebAnimation[1, 7] = 0;
            linksSchwebAnimation[2, 0] = 7;
            linksSchwebAnimation[2, 1] = 0;
            linksSchwebAnimation[2, 2] = 7;
            linksSchwebAnimation[2, 3] = 0;
            linksSchwebAnimation[2, 4] = 7;
            linksSchwebAnimation[2, 5] = 0;
            linksSchwebAnimation[2, 6] = 7;
            linksSchwebAnimation[2, 7] = 0;
            linksSchwebAnimation[3, 0] = 0;
            linksSchwebAnimation[3, 1] = 7;
            linksSchwebAnimation[3, 2] = 7;
            linksSchwebAnimation[3, 3] = 7;
            linksSchwebAnimation[3, 4] = 0;
            linksSchwebAnimation[3, 5] = 0;
            linksSchwebAnimation[3, 6] = 0;
            linksSchwebAnimation[3, 7] = 7;
            linksSchwebAnimation[4, 0] = 0;
            linksSchwebAnimation[4, 1] = 7;
            linksSchwebAnimation[4, 2] = 7;
            linksSchwebAnimation[4, 3] = 7;
            linksSchwebAnimation[4, 4] = 7;
            linksSchwebAnimation[4, 5] = 7;
            linksSchwebAnimation[4, 6] = 7;
            linksSchwebAnimation[4, 7] = 7;
            linksSchwebAnimation[5, 0] = 7;
            linksSchwebAnimation[5, 1] = 7;
            linksSchwebAnimation[5, 2] = 7;
            linksSchwebAnimation[5, 3] = 7;
            linksSchwebAnimation[5, 4] = 7;
            linksSchwebAnimation[5, 5] = 7;
            linksSchwebAnimation[5, 6] = 7;
            linksSchwebAnimation[5, 7] = 0;
            linksSchwebAnimation[6, 0] = 0;
            linksSchwebAnimation[6, 1] = 7;
            linksSchwebAnimation[6, 2] = 7;
            linksSchwebAnimation[6, 3] = 7;
            linksSchwebAnimation[6, 4] = 7;
            linksSchwebAnimation[6, 5] = 7;
            linksSchwebAnimation[6, 6] = 7;
            linksSchwebAnimation[6, 7] = 0;
            linksSchwebAnimation[7, 0] = 0;
            linksSchwebAnimation[7, 1] = 0;
            linksSchwebAnimation[7, 2] = 7;
            linksSchwebAnimation[7, 3] = 7;
            linksSchwebAnimation[7, 4] = 7;
            linksSchwebAnimation[7, 5] = 0;
            linksSchwebAnimation[7, 6] = 0;
            linksSchwebAnimation[7, 7] = 0;
            #endregion

            #region rechtsSchwebAnimation
            rechtsSchwebAnimation[0, 0] = 7;
            rechtsSchwebAnimation[0, 1] = 0;
            rechtsSchwebAnimation[0, 2] = 0;
            rechtsSchwebAnimation[0, 3] = 0;
            rechtsSchwebAnimation[0, 4] = 7;
            rechtsSchwebAnimation[0, 5] = 7;
            rechtsSchwebAnimation[0, 6] = 7;
            rechtsSchwebAnimation[0, 7] = 0;
            rechtsSchwebAnimation[1, 0] = 0;
            rechtsSchwebAnimation[1, 1] = 7;
            rechtsSchwebAnimation[1, 2] = 0;
            rechtsSchwebAnimation[1, 3] = 7;
            rechtsSchwebAnimation[1, 4] = 0;
            rechtsSchwebAnimation[1, 5] = 7;
            rechtsSchwebAnimation[1, 6] = 0;
            rechtsSchwebAnimation[1, 7] = 7;
            rechtsSchwebAnimation[2, 0] = 0;
            rechtsSchwebAnimation[2, 1] = 7;
            rechtsSchwebAnimation[2, 2] = 0;
            rechtsSchwebAnimation[2, 3] = 7;
            rechtsSchwebAnimation[2, 4] = 0;
            rechtsSchwebAnimation[2, 5] = 7;
            rechtsSchwebAnimation[2, 6] = 0;
            rechtsSchwebAnimation[2, 7] = 7;
            rechtsSchwebAnimation[3, 0] = 7;
            rechtsSchwebAnimation[3, 1] = 0;
            rechtsSchwebAnimation[3, 2] = 0;
            rechtsSchwebAnimation[3, 3] = 0;
            rechtsSchwebAnimation[3, 4] = 7;
            rechtsSchwebAnimation[3, 5] = 7;
            rechtsSchwebAnimation[3, 6] = 7;
            rechtsSchwebAnimation[3, 7] = 0;
            rechtsSchwebAnimation[4, 0] = 7;
            rechtsSchwebAnimation[4, 1] = 7;
            rechtsSchwebAnimation[4, 2] = 7;
            rechtsSchwebAnimation[4, 3] = 7;
            rechtsSchwebAnimation[4, 4] = 7;
            rechtsSchwebAnimation[4, 5] = 7;
            rechtsSchwebAnimation[4, 6] = 7;
            rechtsSchwebAnimation[4, 7] = 0;
            rechtsSchwebAnimation[5, 0] = 0;
            rechtsSchwebAnimation[5, 1] = 7;
            rechtsSchwebAnimation[5, 2] = 7;
            rechtsSchwebAnimation[5, 3] = 7;
            rechtsSchwebAnimation[5, 4] = 7;
            rechtsSchwebAnimation[5, 5] = 7;
            rechtsSchwebAnimation[5, 6] = 7;
            rechtsSchwebAnimation[5, 7] = 7;
            rechtsSchwebAnimation[6, 0] = 0;
            rechtsSchwebAnimation[6, 1] = 7;
            rechtsSchwebAnimation[6, 2] = 7;
            rechtsSchwebAnimation[6, 3] = 7;
            rechtsSchwebAnimation[6, 4] = 7;
            rechtsSchwebAnimation[6, 5] = 7;
            rechtsSchwebAnimation[6, 6] = 7;
            rechtsSchwebAnimation[6, 7] = 0;
            rechtsSchwebAnimation[7, 0] = 0;
            rechtsSchwebAnimation[7, 1] = 0;
            rechtsSchwebAnimation[7, 2] = 0;
            rechtsSchwebAnimation[7, 3] = 7;
            rechtsSchwebAnimation[7, 4] = 7;
            rechtsSchwebAnimation[7, 5] = 7;
            rechtsSchwebAnimation[7, 6] = 0;
            rechtsSchwebAnimation[7, 7] = 0;
            #endregion

            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i] = new Pixel();
                }
            }

            RechtsSchweb();
        }

        public void LinksSchweb()
        {

        }

        public void RechtsSchweb()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = rechtsSchwebAnimation[j, i];
                }
            }
        }
    }
}
