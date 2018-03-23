using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class form_Menue : Form
    {
        #region Variablendeklaration
        Form Spiel;
        #endregion
        public form_Menue()
        {
            InitializeComponent();
            spielGestartet = false;
        }
        #region Buttoneventhandler
        #region Spielebuttons
        private void btn_DonkeyKong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pong_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vanguard_Click(object sender, EventArgs e)
        {

        }

        private void btn_Snake_Click(object sender, EventArgs e)
        {

        }

        private void btn_TicTacToe_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Tic_Tac_Toe.form_TicTacToe();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Breakout_Click(object sender, EventArgs e)
        {

        }

        private void btn_Minesweeper_Click(object sender, EventArgs e)
        {

        }

        private void btn_4Gewinnt_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Vier_Gewinnt.form_Vier_Gewinnt();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Frogger_Click(object sender, EventArgs e)
        {

        }

        private void btn_FlappyBird_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Menübuttons
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void vanguardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donkeyKongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void breakoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minesweeperToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flappyBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void froggerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion
        #region Methoden
        public static bool spielGestartet
        {
            get; set;
        }
        #endregion
    }
}
