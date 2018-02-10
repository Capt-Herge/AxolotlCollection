using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class BlauesFragmentOberstes : Ebene
    {
        public BlauesFragmentOberstes()
        {
            form = new int[2, 17];
            model = new Pixel[2, 17];

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
            form[1, 0] = 11;
            form[1, 1] = 11;
            form[1, 2] = 11;
            form[1, 3] = 11;
            form[1, 4] = 11;
            form[1, 5] = 11;
            form[1, 6] = 11;
            form[1, 7] = 11;
            form[1, 8] = 11;
            form[1, 9] = 11;
            form[1, 10] = 11;
            form[1, 11] = 11;
            form[1, 12] = 11;
            form[1, 13] = 11;
            form[1, 14] = 11;
            form[1, 15] = 11;
            form[1, 16] = 11;
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
