using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Hammer : Figuren
    {
        #region bilder
        public int[,] obenAnimation { get; set; } = new int[6,6];
        public int[,] linksAnimation { get; set; } = new int[6, 6];
        public int[,] rechtsAnimation { get; set; } = new int[6, 6];
        #endregion

        public Hammer()
        {
            model = new Pixel[6, 6];

            #region obenAnimation
            obenAnimation[0, 0] = 0;
            obenAnimation[0, 1] = 0;
            obenAnimation[0, 2] = 6;
            obenAnimation[0, 3] = 6;
            obenAnimation[0, 4] = 0;
            obenAnimation[0, 5] = 0;
            obenAnimation[1, 0] = 0;
            obenAnimation[1, 1] = 8;
            obenAnimation[1, 2] = 8;
            obenAnimation[1, 3] = 8;
            obenAnimation[1, 4] = 8;
            obenAnimation[1, 5] = 0;
            obenAnimation[2, 0] = 0;
            obenAnimation[2, 1] = 8;
            obenAnimation[2, 2] = 8;
            obenAnimation[2, 3] = 8;
            obenAnimation[2, 4] = 8;
            obenAnimation[2, 5] = 0;
            obenAnimation[3, 0] = 0;
            obenAnimation[3, 1] = 0;
            obenAnimation[3, 2] = 6;
            obenAnimation[3, 3] = 6;
            obenAnimation[3, 4] = 0;
            obenAnimation[3, 5] = 0;
            obenAnimation[4, 0] = 0;
            obenAnimation[4, 1] = 0;
            obenAnimation[4, 2] = 6;
            obenAnimation[4, 3] = 6;
            obenAnimation[4, 4] = 0;
            obenAnimation[4, 5] = 0;
            obenAnimation[5, 0] = 0;
            obenAnimation[5, 1] = 0;
            obenAnimation[5, 2] = 6;
            obenAnimation[5, 3] = 6;
            obenAnimation[5, 4] = 0;
            obenAnimation[5, 5] = 0;
            #endregion

            #region linksAnimation
            linksAnimation[0, 0] = 0;
            linksAnimation[0, 1] = 0;
            linksAnimation[0, 2] = 0;
            linksAnimation[0, 3] = 0;
            linksAnimation[0, 4] = 0;
            linksAnimation[0, 5] = 0;
            linksAnimation[1, 0] = 0;
            linksAnimation[1, 1] = 8;
            linksAnimation[1, 2] = 8;
            linksAnimation[1, 3] = 0;
            linksAnimation[1, 4] = 0;
            linksAnimation[1, 5] = 0;
            linksAnimation[2, 0] = 6;
            linksAnimation[2, 1] = 8;
            linksAnimation[2, 2] = 8;
            linksAnimation[2, 3] = 6;
            linksAnimation[2, 4] = 6;
            linksAnimation[2, 5] = 6;
            linksAnimation[3, 0] = 6;
            linksAnimation[3, 1] = 8;
            linksAnimation[3, 2] = 8;
            linksAnimation[3, 3] = 6;
            linksAnimation[3, 4] = 6;
            linksAnimation[3, 5] = 6;
            linksAnimation[4, 0] = 0;
            linksAnimation[4, 1] = 8;
            linksAnimation[4, 2] = 8;
            linksAnimation[4, 3] = 0;
            linksAnimation[4, 4] = 0;
            linksAnimation[4, 5] = 0;
            linksAnimation[5, 0] = 0;
            linksAnimation[5, 1] = 0;
            linksAnimation[5, 2] = 0;
            linksAnimation[5, 3] = 0;
            linksAnimation[5, 4] = 0;
            linksAnimation[5, 5] = 0;
            #endregion

            #region rechtsAnimation
            rechtsAnimation[0, 0] = 0;
            rechtsAnimation[0, 1] = 0;
            rechtsAnimation[0, 2] = 0;
            rechtsAnimation[0, 3] = 0;
            rechtsAnimation[0, 4] = 0;
            rechtsAnimation[0, 5] = 0;
            rechtsAnimation[1, 0] = 0;
            rechtsAnimation[1, 1] = 0;
            rechtsAnimation[1, 2] = 0;
            rechtsAnimation[1, 3] = 8;
            rechtsAnimation[1, 4] = 8;
            rechtsAnimation[1, 5] = 0;
            rechtsAnimation[2, 0] = 6;
            rechtsAnimation[2, 1] = 6;
            rechtsAnimation[2, 2] = 6;
            rechtsAnimation[2, 3] = 8;
            rechtsAnimation[2, 4] = 8;
            rechtsAnimation[2, 5] = 6;
            rechtsAnimation[3, 0] = 6;
            rechtsAnimation[3, 1] = 6;
            rechtsAnimation[3, 2] = 6;
            rechtsAnimation[3, 3] = 8;
            rechtsAnimation[3, 4] = 8;
            rechtsAnimation[3, 5] = 6;
            rechtsAnimation[4, 0] = 0;
            rechtsAnimation[4, 1] = 0;
            rechtsAnimation[4, 2] = 0;
            rechtsAnimation[4, 3] = 8;
            rechtsAnimation[4, 4] = 8;
            rechtsAnimation[4, 5] = 0;
            rechtsAnimation[5, 0] = 0;
            rechtsAnimation[5, 1] = 0;
            rechtsAnimation[5, 2] = 0;
            rechtsAnimation[5, 3] = 0;
            rechtsAnimation[5, 4] = 0;
            rechtsAnimation[5, 5] = 0;
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
                    model[j, i].farbe = obenAnimation[j, i];
                }
            }
        }
    }
}
