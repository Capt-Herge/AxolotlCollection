using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Vier_Gewinnt
{
    public partial class form_Vier_Gewinnt : Form
    {
        // Variablendeklaration
        char[,] spielfeld = new char[7, 6];
        char zug = 'X';
        string message = "404";
        string caption = "404";
        int punkteG = 0;
        int punkteR = 0;
        int zugCounter = 0;
        public form_Vier_Gewinnt()
        {
            InitializeComponent();
            ArrayInitialisieren();
        }
        #region EventHandler
        private void btn_SpielClick(object sender, EventArgs e)
        {

        }
        #endregion
        #region Methoden
        private void ArrayInitialisieren()
        {
            // Methode zum Initialisieren des Arrays
            for (int s = 0; s < 7; s++)
            {
                for (int r = 0; r < 6; r++)
                {
                    // L als Charwert für Leer
                    spielfeld[s, r] = 'L';
                }
            }
        }
        private void Gewonnen()
        {
            // Methode falls ein Spieler gewonnen hat
            // Inkrementieren des jeweiligen Punktezählers
            // Anpassen des Labels für die Punkte
            // Anpassen der Message für die Messagebox
            if (zug == 'R')
            {
                punkteR++;
                lbl_punkteR.Text = punkteR.ToString();
                message = "R hat diese Runde gewonnen!";
            }
            else
            {
                punkteG++;
                lbl_punkteG.Text = punkteG.ToString();
                message = "G hat diese Runde gewonnen!";
            }
            caption = "Gewonnen!";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Starten einer neuen Runde nach einem Sieg
            NeueRunde();
        }
        private void NeueRunde()
        {
            // Beginn einer neuen Runde und zurücksetzen der Variablen
            zugCounter = 0;
            ArrayInitialisieren();
            lbl_A1.BackColor = Color.LightBlue;
            lbl_A2.BackColor = Color.LightBlue;
            lbl_A3.BackColor = Color.LightBlue;
            lbl_A4.BackColor = Color.LightBlue;
            lbl_A5.BackColor = Color.LightBlue;
            lbl_A6.BackColor = Color.LightBlue;
            lbl_B1.BackColor = Color.LightBlue;
            lbl_B2.BackColor = Color.LightBlue;
            lbl_B3.BackColor = Color.LightBlue;
            lbl_B4.BackColor = Color.LightBlue;
            lbl_B5.BackColor = Color.LightBlue;
            lbl_B6.BackColor = Color.LightBlue;
            lbl_C1.BackColor = Color.LightBlue;
            lbl_C2.BackColor = Color.LightBlue;
            lbl_C3.BackColor = Color.LightBlue;
            lbl_C4.BackColor = Color.LightBlue;
            lbl_C5.BackColor = Color.LightBlue;
            lbl_C6.BackColor = Color.LightBlue;
            lbl_D1.BackColor = Color.LightBlue;
            lbl_D2.BackColor = Color.LightBlue;
            lbl_D3.BackColor = Color.LightBlue;
            lbl_D4.BackColor = Color.LightBlue;
            lbl_D5.BackColor = Color.LightBlue;
            lbl_D6.BackColor = Color.LightBlue;
            lbl_E1.BackColor = Color.LightBlue;
            lbl_E2.BackColor = Color.LightBlue;
            lbl_E3.BackColor = Color.LightBlue;
            lbl_E4.BackColor = Color.LightBlue;
            lbl_E5.BackColor = Color.LightBlue;
            lbl_E6.BackColor = Color.LightBlue;
            lbl_F1.BackColor = Color.LightBlue;
            lbl_F2.BackColor = Color.LightBlue;
            lbl_F3.BackColor = Color.LightBlue;
            lbl_F4.BackColor = Color.LightBlue;
            lbl_F5.BackColor = Color.LightBlue;
            lbl_F6.BackColor = Color.LightBlue;
            lbl_D1.BackColor = Color.LightBlue;
            lbl_D2.BackColor = Color.LightBlue;
            lbl_D3.BackColor = Color.LightBlue;
            lbl_D4.BackColor = Color.LightBlue;
            lbl_D5.BackColor = Color.LightBlue;
            lbl_D6.BackColor = Color.LightBlue;
        }
        #endregion
    }
}
