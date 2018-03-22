using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Frogger
{
    public partial class Form_Frogger : Form
    {
        static KeyEventArgs Taste = new KeyEventArgs(new Keys());

        public Form_Frogger()
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
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Levelladen(e);
        }

        private void FormDonkeyKong_KeyDown(object sender, KeyEventArgs e)
        {
            Taste = e;                
        }

        private void FormDonkeyKong_KeyUp(object sender, KeyEventArgs e)
        {
            Taste = new KeyEventArgs(Keys.P);
        }

        private void Levelladen(PaintEventArgs e)
        {
            Level1 level1 = new Level1(e, Taste);
        }
    }
}