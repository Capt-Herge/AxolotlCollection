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
        int[,] formZu = new int[1, 9];
        int[,] formOffen = new int[1, 9];
        
        public Falltuer()
        {
            model = new Pixel[1, 9];

            #region formZu
            formZu[0, 0] = 11;
            formZu[0, 1] = 11;
            formZu[0, 2] = 11;
            formZu[0, 3] = 11;
            formZu[0, 4] = 11;
            formZu[0, 5] = 11;
            formZu[0, 6] = 11;
            formZu[0, 7] = 11;
            formZu[0, 8] = 11;
            #endregion

            #region formOffen
            formOffen[0, 0] = 0;
            formOffen[0, 1] = 0;
            formOffen[0, 2] = 0;
            formOffen[0, 3] = 0;
            formOffen[0, 4] = 0;
            formOffen[0, 5] = 0;
            formOffen[0, 6] = 0;
            formOffen[0, 7] = 0;
            formOffen[0, 8] = 0;
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
                    model[j, i].farbe = formZu[j, i];
                }
            }
        }

        public void Oeffnen()
        {
            for (int i = 0; i < model.GetLength(1); i++)
            {
                for (int j = 0; j < model.GetLength(0); j++)
                {
                    model[j, i].farbe = formOffen[j, i];
                }
            }
        }
    }
}
