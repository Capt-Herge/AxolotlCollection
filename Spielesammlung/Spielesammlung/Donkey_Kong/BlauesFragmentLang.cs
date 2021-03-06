﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class BlauesFragmentLang : Ebene
    {
        public BlauesFragmentLang()
        {
            model = new Pixel[5, 25];
            form = new int[5, 25];

            #region form
            form[0, 0] = 11;
            form[0, 1] = 11;
            form[0, 2] = 11;
            form[0, 3] = 11;
            form[0, 4] = 11;
            form[0, 5] = 11;
            form[0, 6] = 11;
            form[0, 7] = 11;
            form[0, 8] = 11;
            form[0, 9] = 11;
            form[0, 10] = 11;
            form[0, 11] = 11;
            form[0, 12] = 11;
            form[0, 13] = 11;
            form[0, 14] = 11;
            form[0, 15] = 11;
            form[0, 16] = 11;
            form[0, 17] = 11;
            form[0, 18] = 11;
            form[0, 19] = 11;
            form[0, 20] = 11;
            form[0, 21] = 11;
            form[0, 22] = 11;
            form[0, 23] = 11;
            form[0, 24] = 11;
            form[1, 0] = 11;
            form[1, 1] = 11;
            form[1, 2] = 11;
            form[1, 3] = 0;
            form[1, 4] = 0;
            form[1, 5] = 0;
            form[1, 6] = 0;
            form[1, 7] = 0;
            form[1, 8] = 0;
            form[1, 9] = 0;
            form[1, 10] = 0;
            form[1, 11] = 11;
            form[1, 12] = 11;
            form[1, 13] = 11;
            form[1, 14] = 0;
            form[1, 15] = 0;
            form[1, 16] = 0;
            form[1, 17] = 0;
            form[1, 18] = 0;
            form[1, 19] = 0;
            form[1, 20] = 0;
            form[1, 21] = 0;
            form[1, 22] = 11;
            form[1, 23] = 11;
            form[1, 24] = 11;
            form[2, 0] = 11;
            form[2, 1] = 11;
            form[2, 2] = 11;
            form[2, 3] = 11;
            form[2, 4] = 11;
            form[2, 5] = 11;
            form[2, 6] = 11;
            form[2, 7] = 11;
            form[2, 8] = 11;
            form[2, 9] = 11;
            form[2, 10] = 11;
            form[2, 11] = 11;
            form[2, 12] = 11;
            form[2, 13] = 11;
            form[2, 14] = 11;
            form[2, 15] = 11;
            form[2, 16] = 11;
            form[2, 17] = 11;
            form[2, 18] = 11;
            form[2, 19] = 11;
            form[2, 20] = 11;
            form[2, 21] = 11;
            form[2, 22] = 11;
            form[2, 23] = 11;
            form[2, 24] = 11;
            form[3, 0] = 11;
            form[3, 1] = 11;
            form[3, 2] = 11;
            form[3, 3] = 0;
            form[3, 4] = 0;
            form[3, 5] = 0;
            form[3, 6] = 0;
            form[3, 7] = 0;
            form[3, 8] = 0;
            form[3, 9] = 0;
            form[3, 10] = 0;
            form[3, 11] = 11;
            form[3, 12] = 11;
            form[3, 13] = 11;
            form[3, 14] = 0;
            form[3, 15] = 0;
            form[3, 16] = 0;
            form[3, 17] = 0;
            form[3, 18] = 0;
            form[3, 19] = 0;
            form[3, 20] = 0;
            form[3, 21] = 0;
            form[3, 22] = 11;
            form[3, 23] = 11;
            form[3, 24] = 11;
            form[4, 0] = 11;
            form[4, 1] = 11;
            form[4, 2] = 11;
            form[4, 3] = 11;
            form[4, 4] = 11;
            form[4, 5] = 11;
            form[4, 6] = 11;
            form[4, 7] = 11;
            form[4, 8] = 11;
            form[4, 9] = 11;
            form[4, 10] = 11;
            form[4, 11] = 11;
            form[4, 12] = 11;
            form[4, 13] = 11;
            form[4, 14] = 11;
            form[4, 15] = 11;
            form[4, 16] = 11;
            form[4, 17] = 11;
            form[4, 18] = 11;
            form[4, 19] = 11;
            form[4, 20] = 11;
            form[4, 21] = 11;
            form[4, 22] = 11;
            form[4, 23] = 11;
            form[4, 24] = 11;
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
                    model[j, i].farbe = form[j, i];
                }
            }
        }
    }
}
