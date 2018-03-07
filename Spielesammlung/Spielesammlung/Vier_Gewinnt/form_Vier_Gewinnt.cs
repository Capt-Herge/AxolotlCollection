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
        private void btn_Spielfeld_Click(object sender, EventArgs e)
        {
            // ClickeventHandler für alle 7x6=42 Spielfeldbuttons
            // Casten des geklickten Buttons, sodass genau der Button verwendet werden kann
            Button button = (Button)sender;

            // ToDo:
            // Test ob Feld belegt ist
            // Test ob Feld unterstes mögliches Feld ist
            // Wincheck
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Todo
            // Eventhandler vom Resetbutton und Zurücksetzen-Menüeintrag
            // Startet neue Runde und setzt alle weiteren Variablen zurück
        }
        private void btn_menue_Click(object sender, EventArgs e)
        {
            // Todo
            // zum Menü wechseln, Form beenden
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
        private void ArrayZuweisung(string buttonName, char zug)
        {
            // Methode zum Belegen des Arrays per Switchcase
            switch (buttonName)
            {
                case "btn_A1":
                    {
                        spielfeld[0, 0] = zug;
                        break;
                    }
                case "btn_A2":
                    {
                        spielfeld[0, 1] = zug;
                        break;
                    }
                case "btn_A3":
                    {
                        spielfeld[0, 2] = zug;
                        break;
                    }
                case "btn_A4":
                    {
                        spielfeld[0, 3] = zug;
                        break;
                    }
                case "btn_A5":
                    {
                        spielfeld[0, 4] = zug;
                        break;
                    }
                case "btn_A6":
                    {
                        spielfeld[0, 5] = zug;
                        break;
                    }
                case "btn_B1":
                    {
                        spielfeld[1, 0] = zug;
                        break;
                    }
                case "btn_B2":
                    {
                        spielfeld[1, 1] = zug;
                        break;
                    }
                case "btn_B3":
                    {
                        spielfeld[1, 2] = zug;
                        break;
                    }
                case "btn_B4":
                    {
                        spielfeld[1, 3] = zug;
                        break;
                    }
                case "btn_B5":
                    {
                        spielfeld[1, 4] = zug;
                        break;
                    }
                case "btn_B6":
                    {
                        spielfeld[1, 5] = zug;
                        break;
                    }
                case "btn_C1":
                    {
                        spielfeld[2, 0] = zug;
                        break;
                    }
                case "btn_C2":
                    {
                        spielfeld[2, 1] = zug;
                        break;
                    }
                case "btn_C3":
                    {
                        spielfeld[2, 2] = zug;
                        break;
                    }
                case "btn_C4":
                    {
                        spielfeld[2, 3] = zug;
                        break;
                    }
                case "btn_C5":
                    {
                        spielfeld[2, 4] = zug;
                        break;
                    }
                case "btn_C6":
                    {
                        spielfeld[2, 5] = zug;
                        break;
                    }
                case "btn_D1":
                    {
                        spielfeld[3, 0] = zug;
                        break;
                    }
                case "btn_D2":
                    {
                        spielfeld[3, 1] = zug;
                        break;
                    }
                case "btn_D3":
                    {
                        spielfeld[3, 2] = zug;
                        break;
                    }
                case "btn_D4":
                    {
                        spielfeld[3, 3] = zug;
                        break;
                    }
                case "btn_D5":
                    {
                        spielfeld[3, 4] = zug;
                        break;
                    }
                case "btn_D6":
                    {
                        spielfeld[3, 5] = zug;
                        break;
                    }
                case "btn_E1":
                    {
                        spielfeld[4, 0] = zug;
                        break;
                    }
                case "btn_E2":
                    {
                        spielfeld[4, 1] = zug;
                        break;
                    }
                case "btn_E3":
                    {
                        spielfeld[4, 2] = zug;
                        break;
                    }
                case "btn_E4":
                    {
                        spielfeld[4, 3] = zug;
                        break;
                    }
                case "btn_E5":
                    {
                        spielfeld[4, 4] = zug;
                        break;
                    }
                case "btn_E6":
                    {
                        spielfeld[4, 5] = zug;
                        break;
                    }
                case "btn_F1":
                    {
                        spielfeld[5, 0] = zug;
                        break;
                    }
                case "btn_F2":
                    {
                        spielfeld[5, 1] = zug;
                        break;
                    }
                case "btn_F3":
                    {
                        spielfeld[5, 2] = zug;
                        break;
                    }
                case "btn_F4":
                    {
                        spielfeld[5, 3] = zug;
                        break;
                    }
                case "btn_F5":
                    {
                        spielfeld[5, 4] = zug;
                        break;
                    }
                case "btn_F6":
                    {
                        spielfeld[5, 5] = zug;
                        break;
                    }
                case "btn_G1":
                    {
                        spielfeld[6, 0] = zug;
                        break;
                    }
                case "btn_G2":
                    {
                        spielfeld[6, 1] = zug;
                        break;
                    }
                case "btn_G3":
                    {
                        spielfeld[6, 2] = zug;
                        break;
                    }
                case "btn_G4":
                    {
                        spielfeld[6, 3] = zug;
                        break;
                    }
                case "btn_G5":
                    {
                        spielfeld[6, 4] = zug;
                        break;
                    }
                case "btn_G6":
                    {
                        spielfeld[6, 5] = zug;
                        break;
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
            // Beginn einer neuen Runde durch Zurücksetzen der Variablen
            zugCounter = 0;
            ArrayInitialisieren();
        }
        #endregion
    }
}
