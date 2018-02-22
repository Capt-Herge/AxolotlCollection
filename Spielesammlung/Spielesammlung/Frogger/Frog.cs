using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class Frog : Figuren
    {
        #region bilder
        public int[,] oben { get; set; } = new int[7, 7];
        public int[,] unten { get; set; } = new int[7, 7];
        public int[,] links { get; set; } = new int[7, 7];
        public int[,] rechts { get; set; } = new int[7, 7];
        #endregion

        public Frog()
        {
            model = new Pixel[7, 7];

            #region oben
            oben[0, 0] = 12;
            oben[0, 1] = 0;
            oben[0, 2] = 0;
            oben[0, 3] = 12;
            oben[0, 4] = 0;
            oben[0, 5] = 0;
            oben[0, 6] = 12;
            oben[1, 0] = 12;
            oben[1, 1] = 0;
            oben[1, 2] = 12;
            oben[1, 3] = 12;
            oben[1, 4] = 12;
            oben[1, 5] = 0;
            oben[1, 6] = 12;
            oben[2, 0] = 0;
            oben[2, 1] = 12;
            oben[2, 2] = 12;
            oben[2, 3] = 12;
            oben[2, 4] = 12;
            oben[2, 5] = 12;
            oben[2, 6] = 0;
            oben[3, 0] = 0;
            oben[3, 1] = 12;
            oben[3, 2] = 12;
            oben[3, 3] = 12;
            oben[3, 4] = 12;
            oben[3, 5] = 12;
            oben[3, 6] = 0;
            oben[4, 0] = 12;
            oben[4, 1] = 12;
            oben[4, 2] = 12;
            oben[4, 3] = 12;
            oben[4, 4] = 12;
            oben[4, 5] = 12;
            oben[4, 6] = 12;
            oben[5, 0] = 12;
            oben[5, 1] = 0;
            oben[5, 2] = 0;
            oben[5, 3] = 12;
            oben[5, 4] = 0;
            oben[5, 5] = 0;
            oben[5, 6] = 12;
            oben[6, 0] = 12;
            oben[6, 1] = 0;
            oben[6, 2] = 0;
            oben[6, 3] = 0;
            oben[6, 4] = 0;
            oben[6, 5] = 0;
            oben[6, 6] = 12;
            #endregion

            #region links
            oben[0, 0] = 12;
            oben[0, 1] = 12;
            oben[0, 2] = 0;
            oben[0, 3] = 0;
            oben[0, 4] = 12;
            oben[0, 5] = 12;
            oben[0, 6] = 12;
            oben[1, 0] = 0;
            oben[1, 1] = 0;
            oben[1, 2] = 12;
            oben[1, 3] = 12;
            oben[1, 4] = 12;
            oben[1, 5] = 0;
            oben[1, 6] = 0;
            oben[2, 0] = 0;
            oben[2, 1] = 12;
            oben[2, 2] = 12;
            oben[2, 3] = 12;
            oben[2, 4] = 12;
            oben[2, 5] = 0;
            oben[2, 6] = 0;
            oben[3, 0] = 12;
            oben[3, 1] = 12;
            oben[3, 2] = 12;
            oben[3, 3] = 12;
            oben[3, 4] = 12;
            oben[3, 5] = 12;
            oben[3, 6] = 0;
            oben[4, 0] = 0;
            oben[4, 1] = 12;
            oben[4, 2] = 12;
            oben[4, 3] = 12;
            oben[4, 4] = 12;
            oben[4, 5] = 0;
            oben[4, 6] = 0;
            oben[5, 0] = 0;
            oben[5, 1] = 0;
            oben[5, 2] = 12;
            oben[5, 3] = 12;
            oben[5, 4] = 12;
            oben[5, 5] = 0;
            oben[5, 6] = 0;
            oben[6, 0] = 12;
            oben[6, 1] = 12;
            oben[6, 2] = 0;
            oben[6, 3] = 0;
            oben[6, 4] = 12;
            oben[6, 5] = 12;
            oben[6, 6] = 12;
            #endregion

            #region rechts
            oben[0, 0] = 12;
            oben[0, 1] = 12;
            oben[0, 2] = 12;
            oben[0, 3] = 0;
            oben[0, 4] = 0;
            oben[0, 5] = 12;
            oben[0, 6] = 12;
            oben[1, 0] = 0;
            oben[1, 1] = 0;
            oben[1, 2] = 12;
            oben[1, 3] = 12;
            oben[1, 4] = 12;
            oben[1, 5] = 0;
            oben[1, 6] = 0;
            oben[2, 0] = 0;
            oben[2, 1] = 0;
            oben[2, 2] = 12;
            oben[2, 3] = 12;
            oben[2, 4] = 12;
            oben[2, 5] = 12;
            oben[2, 6] = 0;
            oben[3, 0] = 0;
            oben[3, 1] = 12;
            oben[3, 2] = 12;
            oben[3, 3] = 12;
            oben[3, 4] = 12;
            oben[3, 5] = 12;
            oben[3, 6] = 12;
            oben[4, 0] = 0;
            oben[4, 1] = 0;
            oben[4, 2] = 0;
            oben[4, 3] = 12;
            oben[4, 4] = 12;
            oben[4, 5] = 12;
            oben[4, 6] = 0;
            oben[5, 0] = 0;
            oben[5, 1] = 0;
            oben[5, 2] = 12;
            oben[5, 3] = 12;
            oben[5, 4] = 12;
            oben[5, 5] = 0;
            oben[5, 6] = 0;
            oben[6, 0] = 12;
            oben[6, 1] = 12;
            oben[6, 2] = 12;
            oben[6, 3] = 0;
            oben[6, 4] = 0;
            oben[6, 5] = 12;
            oben[6, 6] = 12;
            #endregion

            #region unten
            oben[0, 0] = 12;
            oben[0, 1] = 0;
            oben[0, 2] = 0;
            oben[0, 3] = 0;
            oben[0, 4] = 0;
            oben[0, 5] = 0;
            oben[0, 6] = 12;
            oben[1, 0] = 12;
            oben[1, 1] = 0;
            oben[1, 2] = 0;
            oben[1, 3] = 12;
            oben[1, 4] = 0;
            oben[1, 5] = 0;
            oben[1, 6] = 12;
            oben[2, 0] = 12;
            oben[2, 1] = 12;
            oben[2, 2] = 12;
            oben[2, 3] = 12;
            oben[2, 4] = 12;
            oben[2, 5] = 12;
            oben[2, 6] = 12;
            oben[3, 0] = 0;
            oben[3, 1] = 12;
            oben[3, 2] = 12;
            oben[3, 3] = 12;
            oben[3, 4] = 12;
            oben[3, 5] = 12;
            oben[3, 6] = 0;
            oben[4, 0] = 0;
            oben[4, 1] = 12;
            oben[4, 2] = 12;
            oben[4, 3] = 12;
            oben[4, 4] = 12;
            oben[4, 5] = 12;
            oben[4, 6] = 0;
            oben[5, 0] = 12;
            oben[5, 1] = 0;
            oben[5, 2] = 12;
            oben[5, 3] = 12;
            oben[5, 4] = 12;
            oben[5, 5] = 0;
            oben[5, 6] = 12;
            oben[6, 0] = 12;
            oben[6, 1] = 0;
            oben[6, 2] = 0;
            oben[6, 3] = 12;
            oben[6, 4] = 0;
            oben[6, 5] = 0;
            oben[6, 6] = 12;
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


        public void Rechts()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = rechts[j, i];
                }
            }
        }

        public void Runter()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = unten[j, i];
                }
            }
        }

        public void Links()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = links[j, i];
                }
            }
        }
    }
}