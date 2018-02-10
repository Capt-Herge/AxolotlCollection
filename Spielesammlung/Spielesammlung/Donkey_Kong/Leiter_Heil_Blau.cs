using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Leiter_Heil_Blau : Leitern
    {
        public Leiter_Heil_Blau()
        {
            form = new int[17, 5];
            model = new Pixel[17, 5];

            #region form
            form[0, 0] = 11;
            form[0, 1] = 11;
            form[0, 2] = 11;
            form[0, 3] = 11;
            form[0, 4] = 11;
            form[1, 0] = 0;
            form[1, 1] = 0;
            form[1, 2] = 0;
            form[1, 3] = 0;
            form[1, 4] = 0;
            form[2, 0] = 0;
            form[2, 1] = 0;
            form[2, 2] = 0;
            form[2, 3] = 0;
            form[2, 4] = 0;
            form[3, 0] = 0;
            form[3, 1] = 0;
            form[3, 2] = 0;
            form[3, 3] = 0;
            form[3, 4] = 0;
            form[4, 0] = 11;
            form[4, 1] = 11;
            form[4, 2] = 11;
            form[4, 3] = 11;
            form[4, 4] = 11;
            form[5, 0] = 0;
            form[5, 1] = 0;
            form[5, 2] = 0;
            form[5, 3] = 0;
            form[5, 4] = 0;
            form[6, 0] = 0;
            form[6, 1] = 0;
            form[6, 2] = 0;
            form[6, 3] = 0;
            form[6, 4] = 0;
            form[7, 0] = 0;
            form[7, 1] = 0;
            form[7, 2] = 0;
            form[7, 3] = 0;
            form[7, 4] = 0;
            form[8, 0] = 11;
            form[8, 1] = 11;
            form[8, 2] = 11;
            form[8, 3] = 11;
            form[8, 4] = 11;
            form[9, 0] = 0;
            form[9, 1] = 0;
            form[9, 2] = 0;
            form[9, 3] = 0;
            form[9, 4] = 0;
            form[10, 0] = 0;
            form[10, 1] = 0;
            form[10, 2] = 0;
            form[10, 3] = 0;
            form[10, 4] = 0;
            form[11, 0] = 0;
            form[11, 1] = 0;
            form[11, 2] = 0;
            form[11, 3] = 0;
            form[11, 4] = 0;
            form[12, 0] = 11;
            form[12, 1] = 11;
            form[12, 2] = 11;
            form[12, 3] = 11;
            form[12, 4] = 11;
            form[13, 0] = 0;
            form[13, 1] = 0;
            form[13, 2] = 0;
            form[13, 3] = 0;
            form[13, 4] = 0;
            form[14, 0] = 0;
            form[14, 1] = 0;
            form[14, 2] = 0;
            form[14, 3] = 0;
            form[14, 4] = 0;
            form[15, 0] = 0;
            form[15, 1] = 0;
            form[15, 2] = 0;
            form[15, 3] = 0;
            form[15, 4] = 0;
            form[16, 0] = 11;
            form[16, 1] = 11;
            form[16, 2] = 11;
            form[16, 3] = 11;
            form[16, 4] = 11;
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
