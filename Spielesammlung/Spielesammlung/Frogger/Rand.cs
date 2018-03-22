using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class Rand : Level
    {
        public Rand()
        {
            form = new int[10, 7];
            model = new Pixel[10, 7];

            #region form
            form[0, 0] = 12;
            form[1, 0] = 12;
            form[2, 0] = 12;
            form[3, 0] = 12;
            form[4, 0] = 12;
            form[5, 0] = 12;
            form[6, 0] = 12;
            form[7, 0] = 12;
            form[8, 0] = 12;
            form[9, 0] = 12;
            form[0, 1] = 12;
            form[1, 1] = 12;
            form[2, 1] = 12;
            form[3, 1] = 12;
            form[4, 1] = 12;
            form[5, 1] = 12;
            form[6, 1] = 12;
            form[7, 1] = 12;
            form[8, 1] = 12;
            form[9, 1] = 12;
            form[0, 2] = 12;
            form[1, 2] = 12;
            form[2, 2] = 12;
            form[3, 2] = 12;
            form[4, 2] = 12;
            form[5, 2] = 12;
            form[6, 2] = 12;
            form[7, 2] = 12;
            form[8, 2] = 12;
            form[9, 2] = 12;
            form[0, 3] = 12;
            form[1, 3] = 12;
            form[2, 3] = 12;
            form[3, 3] = 12;
            form[4, 3] = 12;
            form[5, 3] = 12;
            form[6, 3] = 12;
            form[7, 3] = 12;
            form[8, 3] = 12;
            form[9, 3] = 12;
            form[0, 4] = 12;
            form[1, 4] = 12;
            form[2, 4] = 12;
            form[3, 4] = 12;
            form[4, 4] = 12;
            form[5, 4] = 12;
            form[6, 4] = 12;
            form[7, 4] = 12;
            form[8, 4] = 12;
            form[9, 4] = 12;
            form[0, 5] = 12;
            form[1, 5] = 12;
            form[2, 5] = 12;
            form[3, 5] = 12;
            form[4, 5] = 12;
            form[5, 5] = 12;
            form[6, 5] = 12;
            form[7, 5] = 12;
            form[8, 5] = 12;
            form[9, 5] = 12;
            form[0, 6] = 12;
            form[1, 6] = 12;
            form[2, 6] = 12;
            form[3, 6] = 12;
            form[4, 6] = 12;
            form[5, 6] = 12;
            form[6, 6] = 12;
            form[7, 6] = 12;
            form[8, 6] = 12;
            form[9, 6] = 12;
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
