using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Donkey_Kong
{
    class Mario : Figuren
    {
        public int ebene { get; set; } = 1;
        public bool hammer { get; set; } = false;
        public int leiterPosition { get; set; } = 0;

        public void LinksLauf(KeyEventArgs e)
        {
            while(e.KeyCode == Keys.Left)
            {

            }
        }

        public void RechtsLauf(KeyEventArgs e)
        {
            while (e.KeyCode == Keys.Right)
            {

            }
        }

        public void Springen(KeyEventArgs e)
        {
            while (e.KeyCode == Keys.Up)
            {

            }
        }

        public void HochKlettern(KeyEventArgs e, Leiter_Heil leiter)
        {
            while ((e.KeyCode == Keys.Up) && (leiter.xPosition == xPosition) && (leiterPosition != 3))
            {
                leiterPosition++;
            }

            if(leiterPosition == 3)
            {
                leiterPosition = 0;
                ebene++;
            }
        }

        public void RunterKlettern(KeyEventArgs e, Leiter_Heil leiter)
        {
            while ((e.KeyCode == Keys.Down) && (leiter.xPosition == xPosition) && (leiterPosition != 0))
            {
                leiterPosition--;
            }

            if ((leiterPosition == 0) && (leiter.xPosition == xPosition))
            {
                leiterPosition = 3;
                ebene--;
            }
        }

        public void HammerSchwingen()
        {

        }
    }
}
