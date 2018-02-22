using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Frogger
{
    class RandObenKurz : Level
    {
        public RandObenKurz()
        {
            form = new int[1, 7];
            model = new Pixel[1, 7];

            #region form
            form[0, 0] = 12;
            form[0, 1] = 12;
            form[0, 2] = 12;
            form[0, 3] = 12;
            form[0, 4] = 12;
            form[0, 5] = 12;
            form[0, 6] = 12;
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
