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


        public FormDonkeyKong()
        {
            InitializeComponent();

            timer1.Tick += UpdateSpiel;

            timer1.Start();
        }


        private void UpdateSpiel(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Levelladen(aktuellesLevel ,e);
        }

        private void Levelladen(int altesLevel, PaintEventArgs e)
        {
            switch (altesLevel)
            {
                case 1:
                    pictureBox1.Refresh();
                    Level2 level2 = new Level2(e);
                    break;
                case 2:
                    pictureBox1.Refresh();
                    Level1 level1 = new Level1(e);                
                    level1.AffeSetzen(e).AendereBlickRichtung();
                    break;
            }
        }
    }
}
