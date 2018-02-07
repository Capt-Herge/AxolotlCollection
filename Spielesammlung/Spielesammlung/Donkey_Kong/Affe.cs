using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class Affe : Figuren
    {
        public bool blickRichtung { get; set; } = false;

        #region bilder
        #region linksAnimation
        public int[,] linksAnimation { get; set; } = new int[21,18];
        linksAnimation[0,0] = 0;
        #endregion
        #region rechtsAnimation
        public int[,] rechtsAnimation { get; set; } = new int[21,18];
        #endregion
        #endregion

        public void AendereBlickRichtung()
        {

        }
    }
}
