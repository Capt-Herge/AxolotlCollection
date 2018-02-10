using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Falltuer : Ebene
    {
        public bool offen { get; set; } = false;

        public Falltuer()
        {

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
