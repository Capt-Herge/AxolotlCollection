using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Donkey_Kong
{
    public partial class FormDonkeyKong : Form
    {
        static int aktuellesLevel = 2;

        static int  affeHilf = 0;
        static int fassHilf1 = 0;
        static int fassHilf2 = 0;
        static int fassHilf3 = 0;
        static int fassHilf4 = 0;

        static KeyEventArgs Taste = new KeyEventArgs(new Keys());



        public FormDonkeyKong()
        {
            #region timer Spiel
            Timer timerSpiel = new Timer();

            timerSpiel.Tick += new EventHandler(UpdateSpiel);

            timerSpiel.Interval = 1;

            timerSpiel.Enabled = true;

            timerSpiel.Start();
            #endregion

            InitializeComponent();
        }


        private void UpdateSpiel(object sender, EventArgs e)
        {
            affeHilf++;
            fassHilf1++;
            fassHilf2++;
            fassHilf3++;
            fassHilf4++;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Levelladen(aktuellesLevel, e);
        }

        private void FormDonkeyKong_KeyDown(object sender, KeyEventArgs e)
        {
            Taste = e;
        }

        private void FormDonkeyKong_KeyUp(object sender, KeyEventArgs e)
        {
            Taste = new KeyEventArgs(new Keys());
        }

        private void Levelladen(int altesLevel, PaintEventArgs e)
        {
            switch (altesLevel)
            {
                case 1:
                    Level2 level2 = new Level2(e, affeHilf, Taste);

                    if (affeHilf > 200)
                    {
                        affeHilf = 0;
                    }

                    if (level2.levelbeendedt == true)
                    {
                        level2.Neustart();
                        aktuellesLevel = 2;
                        affeHilf = 0;
                        level2.levelbeendedt = false;
                    }

                    break;
                case 2:
                    Level1 level1 = new Level1(e, affeHilf, fassHilf1, fassHilf2, fassHilf3, fassHilf4, Taste);

                    if (affeHilf > 200)
                    {
                        affeHilf = 0;
                    }

                    if (fassHilf1 > 23)
                    {
                        fassHilf1 = 0;
                    }
                    if (fassHilf2 > 23)
                    {
                        fassHilf2 = 0;
                    }
                    if (fassHilf3 > 23)
                    {
                        fassHilf3 = 0;
                    }
                    if (fassHilf4 > 23)
                    {
                        fassHilf4 = 0;
                    }

                    if (level1.levelbeendedt == true)
                    {
                        level1.Neustart();
                        aktuellesLevel = 1;
                        affeHilf = 0;
                        fassHilf1 = 0;
                        fassHilf2 = 0;
                        fassHilf3 = 0;
                        fassHilf4 = 0;
                        level1.levelbeendedt = false;
                    }
                    break;
            }
        }
    }
}
