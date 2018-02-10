using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class LilaFragmentHalbLinks : Ebene
    {
        public LilaFragmentHalbLinks()
        {
            form = new int[5, 8];
            model = new Pixel[5, 8];

            #region form
            form[0, 0] = 10;
            form[0, 1] = 10;
            form[0, 2] = 10;
            form[0, 3] = 10;
            form[0, 4] = 10;
            form[0, 5] = 10;
            form[0, 6] = 10;
            form[0, 7] = 10;
            form[1, 0] = 0;
            form[1, 1] = 0;
            form[1, 2] = 0;
            form[1, 3] = 10;
            form[1, 4] = 10;
            form[1, 5] = 10;
            form[1, 6] = 10;
            form[1, 7] = 10;
            form[2, 0] = 10;
            form[2, 1] = 10;
            form[2, 2] = 10;
            form[2, 3] = 0;
            form[2, 4] = 0;
            form[2, 5] = 0;
            form[2, 6] = 0;
            form[2, 7] = 0;
            form[3, 0] = 0;
            form[3, 1] = 0;
            form[3, 2] = 0;
            form[3, 3] = 0;
            form[3, 4] = 10;
            form[3, 5] = 10;
            form[3, 6] = 10;
            form[3, 7] = 10;
            form[4, 0] = 10;
            form[4, 1] = 10;
            form[4, 2] = 10;
            form[4, 3] = 10;
            form[4, 4] = 10;
            form[4, 5] = 10;
            form[4, 6] = 10;
            form[4, 7] = 10;
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
