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
            oben[0, 0] = 17;
            oben[0, 1] = 0;
            oben[0, 2] = 0;
            oben[0, 3] = 17;
            oben[0, 4] = 0;
            oben[0, 5] = 0;
            oben[0, 6] = 17;
            oben[1, 0] = 17;
            oben[1, 1] = 0;
            oben[1, 2] = 17;
            oben[1, 3] = 17;
            oben[1, 4] = 17;
            oben[1, 5] = 0;
            oben[1, 6] = 17;
            oben[2, 0] = 0;
            oben[2, 1] = 17;
            oben[2, 2] = 17;
            oben[2, 3] = 17;
            oben[2, 4] = 17;
            oben[2, 5] = 17;
            oben[2, 6] = 0;
            oben[3, 0] = 0;
            oben[3, 1] = 17;
            oben[3, 2] = 17;
            oben[3, 3] = 17;
            oben[3, 4] = 17;
            oben[3, 5] = 17;
            oben[3, 6] = 0;
            oben[4, 0] = 17;
            oben[4, 1] = 17;
            oben[4, 2] = 17;
            oben[4, 3] = 17;
            oben[4, 4] = 17;
            oben[4, 5] = 17;
            oben[4, 6] = 17;
            oben[5, 0] = 17;
            oben[5, 1] = 0;
            oben[5, 2] = 0;
            oben[5, 3] = 17;
            oben[5, 4] = 0;
            oben[5, 5] = 0;
            oben[5, 6] = 17;
            oben[6, 0] = 17;
            oben[6, 1] = 0;
            oben[6, 2] = 0;
            oben[6, 3] = 0;
            oben[6, 4] = 0;
            oben[6, 5] = 0;
            oben[6, 6] = 17;
            #endregion

            #region links
            links[0, 0] = 17;
            links[0, 1] = 17;
            links[0, 2] = 0;
            links[0, 3] = 0;
            links[0, 4] = 17;
            links[0, 5] = 17;
            links[0, 6] = 17;
            links[1, 0] = 0;
            links[1, 1] = 0;
            links[1, 2] = 17;
            links[1, 3] = 17;
            links[1, 4] = 17;
            links[1, 5] = 0;
            links[1, 6] = 0;
            links[2, 0] = 0;
            links[2, 1] = 17;
            links[2, 2] = 17;
            links[2, 3] = 17;
            links[2, 4] = 17;
            links[2, 5] = 0;
            links[2, 6] = 0;
            links[3, 0] = 17;
            links[3, 1] = 17;
            links[3, 2] = 17;
            links[3, 3] = 17;
            links[3, 4] = 17;
            links[3, 5] = 17;
            links[3, 6] = 0;
            links[4, 0] = 0;
            links[4, 1] = 17;
            links[4, 2] = 17;
            links[4, 3] = 17;
            links[4, 4] = 17;
            links[4, 5] = 0;
            links[4, 6] = 0;
            links[5, 0] = 0;
            links[5, 1] = 0;
            links[5, 2] = 17;
            links[5, 3] = 17;
            links[5, 4] = 17;
            links[5, 5] = 0;
            links[5, 6] = 0;
            links[6, 0] = 17;
            links[6, 1] = 17;
            links[6, 2] = 0;
            links[6, 3] = 0;
            links[6, 4] = 17;
            links[6, 5] = 17;
            links[6, 6] = 17;
            #endregion

            #region rechts
            rechts[0, 0] = 17;
            rechts[0, 1] = 17;
            rechts[0, 2] = 17;
            rechts[0, 3] = 0;
            rechts[0, 4] = 0;
            rechts[0, 5] = 17;
            rechts[0, 6] = 17;
            rechts[1, 0] = 0;
            rechts[1, 1] = 0;
            rechts[1, 2] = 17;
            rechts[1, 3] = 17;
            rechts[1, 4] = 17;
            rechts[1, 5] = 0;
            rechts[1, 6] = 0;
            rechts[2, 0] = 0;
            rechts[2, 1] = 0;
            rechts[2, 2] = 17;
            rechts[2, 3] = 17;
            rechts[2, 4] = 17;
            rechts[2, 5] = 17;
            rechts[2, 6] = 0;
            rechts[3, 0] = 0;
            rechts[3, 1] = 17;
            rechts[3, 2] = 17;
            rechts[3, 3] = 17;
            rechts[3, 4] = 17;
            rechts[3, 5] = 17;
            rechts[3, 6] = 17;
            rechts[4, 0] = 0;
            rechts[4, 1] = 0;
            rechts[4, 2] = 0;
            rechts[4, 3] = 17;
            rechts[4, 4] = 17;
            rechts[4, 5] = 17;
            rechts[4, 6] = 0;
            rechts[5, 0] = 0;
            rechts[5, 1] = 0;
            rechts[5, 2] = 17;
            rechts[5, 3] = 17;
            rechts[5, 4] = 17;
            rechts[5, 5] = 0;
            rechts[5, 6] = 0;
            rechts[6, 0] = 17;
            rechts[6, 1] = 17;
            rechts[6, 2] = 17;
            rechts[6, 3] = 0;
            rechts[6, 4] = 0;
            rechts[6, 5] = 17;
            rechts[6, 6] = 17;
            #endregion

            #region unten
            unten[0, 0] = 17;
            unten[0, 1] = 0;
            unten[0, 2] = 0;
            unten[0, 3] = 0;
            unten[0, 4] = 0;
            unten[0, 5] = 0;
            unten[0, 6] = 17;
            unten[1, 0] = 17;
            unten[1, 1] = 0;
            unten[1, 2] = 0;
            unten[1, 3] = 17;
            unten[1, 4] = 0;
            unten[1, 5] = 0;
            unten[1, 6] = 17;
            unten[2, 0] = 17;
            unten[2, 1] = 17;
            unten[2, 2] = 17;
            unten[2, 3] = 17;
            unten[2, 4] = 17;
            unten[2, 5] = 17;
            unten[2, 6] = 17;
            unten[3, 0] = 0;
            unten[3, 1] = 17;
            unten[3, 2] = 17;
            unten[3, 3] = 17;
            unten[3, 4] = 17;
            unten[3, 5] = 17;
            unten[3, 6] = 0;
            unten[4, 0] = 0;
            unten[4, 1] = 17;
            unten[4, 2] = 17;
            unten[4, 3] = 17;
            unten[4, 4] = 17;
            unten[4, 5] = 17;
            unten[4, 6] = 0;
            unten[5, 0] = 17;
            unten[5, 1] = 0;
            unten[5, 2] = 17;
            unten[5, 3] = 17;
            unten[5, 4] = 17;
            unten[5, 5] = 0;
            unten[5, 6] = 17;
            unten[6, 0] = 17;
            unten[6, 1] = 0;
            unten[6, 2] = 0;
            unten[6, 3] = 17;
            unten[6, 4] = 0;
            unten[6, 5] = 0;
            unten[6, 6] = 17;
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