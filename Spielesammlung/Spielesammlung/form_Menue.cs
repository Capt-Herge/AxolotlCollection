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
            if (spielGestartet == false)
            {
                Spiel = new Donkey_Kong.FormDonkeyKong();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Pong_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Pong.Form1();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Vanguards_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Vanguards.Vanguards();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Snake_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Snake.Form_Snake();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Tic_Tac_Toe_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Tic_Tac_Toe.Form_Tic_Tac_Toe();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Breakout_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Breakout.Form1();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Minesweeper_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Minesweeper.Form_Minesweeper();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Vier_Gewinnt_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Vier_Gewinnt.Form_Vier_Gewinnt();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_Frogger_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Frogger.Form_Frogger();
                spielGestartet = true;
                Spiel.Show();
            }
        }

        private void btn_FlappyBird_Click(object sender, EventArgs e)
        {
            if (spielGestartet == false)
            {
                Spiel = new Flappy_Bird.Flappy_Bird();
                spielGestartet = true;
                Spiel.Show();
            }
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
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("Vanguards");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void donkeyKongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("DonkeyKong");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("Snake");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void breakoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("Breakout");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void minesweeperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenZeit("Minesweeper");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void flappyBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("Flappybird");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }

        private void froggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Highscore highscore = new Highscore();
            lbl_message.Text = highscore.EinträgeAnzeigenPunkte("Frogger");
            btn_messageOK.Visible = true;
            btn_messageOK.Enabled = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }
        private void btn_messageOK_Click(object sender, EventArgs e)
        {
            // Lässt das Highscoremessageoverlay ausblenden
            btn_messageOK.Visible = false;
            btn_messageOK.Enabled = false;
            lbl_caption.Visible = false;
            lbl_message.Visible = false;
            lbl_messagebackground.Visible = false;
        }
        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
