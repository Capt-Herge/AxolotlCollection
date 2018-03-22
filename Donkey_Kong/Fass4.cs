using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Fass4 : Figuren
    {
        public static bool blickRichtung1 { get; set; } = true;

        #region bilder
        public int[,] rollAnimation1 { get; set; } = new int[8, 8];
        public int[,] rollAnimation2 { get; set; } = new int[8, 8];
        public int[,] fallAnimation { get; set; } = new int[8, 8];
        #endregion

        public Fass4(bool fallen)
        {
            model = new Pixel[8, 8];

            #region rollAnimation1
            rollAnimation1[0, 0] = 0;
            rollAnimation1[0, 1] = 0;
            rollAnimation1[0, 2] = 6;
            rollAnimation1[0, 3] = 6;
            rollAnimation1[0, 4] = 6;
            rollAnimation1[0, 5] = 6;
            rollAnimation1[0, 6] = 0;
            rollAnimation1[0, 7] = 0;
            rollAnimation1[1, 0] = 0;
            rollAnimation1[1, 1] = 6;
            rollAnimation1[1, 2] = 6;
            rollAnimation1[1, 3] = 6;
            rollAnimation1[1, 4] = 0;
            rollAnimation1[1, 5] = 6;
            rollAnimation1[1, 6] = 6;
            rollAnimation1[1, 7] = 0;
            rollAnimation1[2, 0] = 6;
            rollAnimation1[2, 1] = 6;
            rollAnimation1[2, 2] = 0;
            rollAnimation1[2, 3] = 6;
            rollAnimation1[2, 4] = 6;
            rollAnimation1[2, 5] = 6;
            rollAnimation1[2, 6] = 6;
            rollAnimation1[2, 7] = 6;
            rollAnimation1[3, 0] = 6;
            rollAnimation1[3, 1] = 6;
            rollAnimation1[3, 2] = 6;
            rollAnimation1[3, 3] = 6;
            rollAnimation1[3, 4] = 6;
            rollAnimation1[3, 5] = 6;
            rollAnimation1[3, 6] = 0;
            rollAnimation1[3, 7] = 6;
            rollAnimation1[4, 0] = 6;
            rollAnimation1[4, 1] = 0;
            rollAnimation1[4, 2] = 6;
            rollAnimation1[4, 3] = 6;
            rollAnimation1[4, 4] = 6;
            rollAnimation1[4, 5] = 6;
            rollAnimation1[4, 6] = 6;
            rollAnimation1[4, 7] = 6;
            rollAnimation1[5, 0] = 6;
            rollAnimation1[5, 1] = 6;
            rollAnimation1[5, 2] = 6;
            rollAnimation1[5, 3] = 6;
            rollAnimation1[5, 4] = 6;
            rollAnimation1[5, 5] = 0;
            rollAnimation1[5, 6] = 6;
            rollAnimation1[5, 7] = 6;
            rollAnimation1[6, 0] = 0;
            rollAnimation1[6, 1] = 6;
            rollAnimation1[6, 2] = 6;
            rollAnimation1[6, 3] = 0;
            rollAnimation1[6, 4] = 6;
            rollAnimation1[6, 5] = 6;
            rollAnimation1[6, 6] = 6;
            rollAnimation1[6, 7] = 0;
            rollAnimation1[7, 0] = 0;
            rollAnimation1[7, 1] = 0;
            rollAnimation1[7, 2] = 6;
            rollAnimation1[7, 3] = 6;
            rollAnimation1[7, 4] = 6;
            rollAnimation1[7, 5] = 6;
            rollAnimation1[7, 6] = 0;
            rollAnimation1[7, 7] = 0;
            #endregion

            #region rallAnimation2
            rollAnimation2[0, 0] = 0;
            rollAnimation2[0, 1] = 0;
            rollAnimation2[0, 2] = 6;
            rollAnimation2[0, 3] = 6;
            rollAnimation2[0, 4] = 6;
            rollAnimation2[0, 5] = 6;
            rollAnimation2[0, 6] = 0;
            rollAnimation2[0, 7] = 0;
            rollAnimation2[1, 0] = 0;
            rollAnimation2[1, 1] = 6;
            rollAnimation2[1, 2] = 6;
            rollAnimation2[1, 3] = 0;
            rollAnimation2[1, 4] = 6;
            rollAnimation2[1, 5] = 6;
            rollAnimation2[1, 6] = 6;
            rollAnimation2[1, 7] = 0;
            rollAnimation2[2, 0] = 6;
            rollAnimation2[2, 1] = 6;
            rollAnimation2[2, 2] = 6;
            rollAnimation2[2, 3] = 6;
            rollAnimation2[2, 4] = 6;
            rollAnimation2[2, 5] = 0;
            rollAnimation2[2, 6] = 6;
            rollAnimation2[2, 7] = 6;
            rollAnimation2[3, 0] = 6;
            rollAnimation2[3, 1] = 0;
            rollAnimation2[3, 2] = 6;
            rollAnimation2[3, 3] = 6;
            rollAnimation2[3, 4] = 6;
            rollAnimation2[3, 5] = 6;
            rollAnimation2[3, 6] = 6;
            rollAnimation2[3, 7] = 6;
            rollAnimation2[4, 0] = 6;
            rollAnimation2[4, 1] = 6;
            rollAnimation2[4, 2] = 6;
            rollAnimation2[4, 3] = 6;
            rollAnimation2[4, 4] = 6;
            rollAnimation2[4, 5] = 6;
            rollAnimation2[4, 6] = 0;
            rollAnimation2[4, 7] = 6;
            rollAnimation2[5, 0] = 6;
            rollAnimation2[5, 1] = 6;
            rollAnimation2[5, 2] = 0;
            rollAnimation2[5, 3] = 6;
            rollAnimation2[5, 4] = 6;
            rollAnimation2[5, 5] = 6;
            rollAnimation2[5, 6] = 6;
            rollAnimation2[5, 7] = 6;
            rollAnimation2[6, 0] = 0;
            rollAnimation2[6, 1] = 6;
            rollAnimation2[6, 2] = 6;
            rollAnimation2[6, 3] = 6;
            rollAnimation2[6, 4] = 0;
            rollAnimation2[6, 5] = 6;
            rollAnimation2[6, 6] = 6;
            rollAnimation2[6, 7] = 0;
            rollAnimation2[7, 0] = 0;
            rollAnimation2[7, 1] = 0;
            rollAnimation2[7, 2] = 6;
            rollAnimation2[7, 3] = 6;
            rollAnimation2[7, 4] = 6;
            rollAnimation2[7, 5] = 6;
            rollAnimation2[7, 6] = 0;
            rollAnimation2[7, 7] = 0;
            #endregion

            #region fallAnimation
            fallAnimation[0, 0] = 0;
            fallAnimation[0, 1] = 0;
            fallAnimation[0, 2] = 6;
            fallAnimation[0, 3] = 6;
            fallAnimation[0, 4] = 6;
            fallAnimation[0, 5] = 6;
            fallAnimation[0, 6] = 0;
            fallAnimation[0, 7] = 0;
            fallAnimation[1, 0] = 0;
            fallAnimation[1, 1] = 6;
            fallAnimation[1, 2] = 0;
            fallAnimation[1, 3] = 6;
            fallAnimation[1, 4] = 6;
            fallAnimation[1, 5] = 0;
            fallAnimation[1, 6] = 6;
            fallAnimation[1, 7] = 0;
            fallAnimation[2, 0] = 6;
            fallAnimation[2, 1] = 0;
            fallAnimation[2, 2] = 6;
            fallAnimation[2, 3] = 6;
            fallAnimation[2, 4] = 6;
            fallAnimation[2, 5] = 6;
            fallAnimation[2, 6] = 0;
            fallAnimation[2, 7] = 6;
            fallAnimation[3, 0] = 6;
            fallAnimation[3, 1] = 0;
            fallAnimation[3, 2] = 0;
            fallAnimation[3, 3] = 0;
            fallAnimation[3, 4] = 0;
            fallAnimation[3, 5] = 0;
            fallAnimation[3, 6] = 0;
            fallAnimation[3, 7] = 6;
            fallAnimation[4, 0] = 6;
            fallAnimation[4, 1] = 0;
            fallAnimation[4, 2] = 0;
            fallAnimation[4, 3] = 0;
            fallAnimation[4, 4] = 0;
            fallAnimation[4, 5] = 0;
            fallAnimation[4, 6] = 0;
            fallAnimation[4, 7] = 6;
            fallAnimation[5, 0] = 6;
            fallAnimation[5, 1] = 0;
            fallAnimation[5, 2] = 6;
            fallAnimation[5, 3] = 6;
            fallAnimation[5, 4] = 6;
            fallAnimation[5, 5] = 6;
            fallAnimation[5, 6] = 0;
            fallAnimation[5, 7] = 6;
            fallAnimation[6, 0] = 0;
            fallAnimation[6, 1] = 6;
            fallAnimation[6, 2] = 0;
            fallAnimation[6, 3] = 6;
            fallAnimation[6, 4] = 6;
            fallAnimation[6, 5] = 0;
            fallAnimation[6, 6] = 6;
            fallAnimation[6, 7] = 0;
            fallAnimation[7, 0] = 0;
            fallAnimation[7, 1] = 0;
            fallAnimation[7, 2] = 6;
            fallAnimation[7, 3] = 6;
            fallAnimation[7, 4] = 6;
            fallAnimation[7, 5] = 6;
            fallAnimation[7, 6] = 0;
            fallAnimation[7, 7] = 0;
            #endregion

            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i] = new Pixel();
                }
            }

            if (fallen == true)
            {
                Fall();
            }
            else
            {
                Dreh();
            }
        }

        public void Dreh()
        {
            switch (blickRichtung1)
            {
                case true:
                    for (int i = 0; i < model.GetLength(1); i++)
                    {
                        for (int j = 0; j < model.GetLength(0); j++)
                        {
                            model[j, i].farbe = rollAnimation1[j, i];
                        }
                    }

                    blickRichtung1 = false;
                    break;
                case false:
                    for (int i = 0; i < model.GetLength(1); i++)
                    {
                        for (int j = 0; j < model.GetLength(0); j++)
                        {
                            model[j, i].farbe = rollAnimation2[j, i];
                        }
                    }

                    blickRichtung1 = true;
                    break;
            }
        }

        public void Fall()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = fallAnimation[j, i];
                }
            }
        }
    }
}