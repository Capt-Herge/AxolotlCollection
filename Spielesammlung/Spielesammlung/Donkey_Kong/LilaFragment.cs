using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Donkey_Kong
{
    class LilaFragment : Ebene
    {
        public LilaFragment()
        {
            model = new Pixel[5, 17];
            form = new int[5, 17];

            #region form
            form[0, 0] = 10;
            form[0, 1] = 10;
            form[0, 2] = 10;
            form[0, 3] = 10;
            form[0, 4] = 10;
            form[0, 5] = 10;
            form[0, 6] = 10;
            form[0, 7] = 10;
            form[0, 8] = 10;
            form[0, 9] = 10;
            form[0, 10] = 10;
            form[0, 11] = 10;
            form[0, 12] = 10;
            form[0, 13] = 10;
            form[0, 14] = 10;
            form[0, 15] = 10;
            form[0, 16] = 10;
            form[1, 0] = 10;
            form[1, 1] = 10;
            form[1, 2] = 10;
            form[1, 3] = 10;
            form[1, 4] = 10;
            form[1, 5] = 0;
            form[1, 6] = 0;
            form[1, 7] = 0;
            form[1, 8] = 0;
            form[1, 9] = 0;
            form[1, 10] = 0;
            form[1, 11] = 0;
            form[1, 12] = 10;
            form[1, 13] = 10;
            form[1, 14] = 10;
            form[1, 15] = 10;
            form[1, 16] = 10;
            form[2, 0] = 0;
            form[2, 1] = 0;
            form[2, 2] = 0;
            form[2, 3] = 0;
            form[2, 4] = 0;
            form[2, 5] = 10;
            form[2, 6] = 10;
            form[2, 7] = 10;
            form[2, 8] = 10;
            form[2, 9] = 10;
            form[2, 10] = 10;
            form[2, 11] = 10;
            form[2, 12] = 0;
            form[2, 13] = 0;
            form[2, 14] = 0;
            form[2, 15] = 0;
            form[2, 16] = 0;
            form[3, 0] = 10;
            form[3, 1] = 10;
            form[3, 2] = 10;
            form[3, 3] = 10;
            form[3, 4] = 10;
            form[3, 5] = 0;
            form[3, 6] = 0;
            form[3, 7] = 0;
            form[3, 8] = 0;
            form[3, 9] = 0;
            form[3, 10] = 0;
            form[3, 11] = 0;
            form[3, 12] = 10;
            form[3, 13] = 10;
            form[3, 14] = 10;
            form[3, 15] = 10;
            form[3, 16] = 10;
            form[4, 0] = 10;
            form[4, 1] = 10;
            form[4, 2] = 10;
            form[4, 3] = 10;
            form[4, 4] = 10;
            form[4, 5] = 10;
            form[4, 6] = 10;
            form[4, 7] = 10;
            form[4, 8] = 10;
            form[4, 9] = 10;
            form[4, 10] = 10;
            form[4, 11] = 10;
            form[4, 12] = 10;
            form[4, 13] = 10;
            form[4, 14] = 10;
            form[4, 15] = 10;
            form[4, 16] = 10;
            #endregion
        }
    }
}
