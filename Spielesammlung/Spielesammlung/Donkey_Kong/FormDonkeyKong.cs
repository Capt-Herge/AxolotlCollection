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
        int aktuellesLevel = 2;
        static int  affeHilf = 0;
        static int fassHilf1 = 0;
        static int fassHilf2 = 0;
        static int fassHilf3 = 0;
        static int fassHilf4 = 0;

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


        private void Levelladen(int altesLevel, PaintEventArgs e)
        {
            switch (altesLevel)
            {
                case 1:
                    Level2 level2 = new Level2(e, affeHilf);

                    if (affeHilf > 200)
                    {
                        affeHilf = 0;
                    }
                    break;
                case 2:
                    Level1 level1 = new Level1(e, affeHilf, fassHilf1, fassHilf2, fassHilf3, fassHilf4);     
                    if(affeHilf > 200)
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
                    break;
            }
        }
    }
}
