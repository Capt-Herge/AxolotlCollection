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
        static int fassHilf = 0;

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
            fassHilf++;
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
                    Level1 level1 = new Level1(e, affeHilf, fassHilf);     
                    if(affeHilf > 200)
                    {
                        affeHilf = 0;
                    }

                    if (fassHilf > 23)
                    {
                        fassHilf = 0;
                    }
                    break;
            }
        }
    }
}
