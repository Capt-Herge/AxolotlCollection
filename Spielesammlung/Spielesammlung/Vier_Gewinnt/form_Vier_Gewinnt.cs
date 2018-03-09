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
        bool zugKorrekt = true;
        string message = "404";
        string caption = "404";
        int punkteG = 0;
        int punkteR = 0;
        int zugCounter = 0;
        int spaltenkoordinate = 0;
        int reihenkoordinate = 0;
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

            // Auflösen der Koordinaten des geklickten Button
            spaltenkoordinate = Getspaltenkoordinate(button.Name);
            reihenkoordinate = Getreihenkoordinate(button.Name);

            // Tests ob Feld benutzt werden kann
            zugKorrekt = true;
            if (zugKorrekt == true)
            {
                TestFeldBelegt();
            }
            if (zugKorrekt == true)
            {
                TestFeldUnterstesFreies();
            }

            // Zuweisen der richtigen Variable im Spielfeld-Array
            if (zugKorrekt == true)
            {
                if (zug == 'R')
                {
                    button.BackColor = Color.Red;
                }
                if (zug == 'F')
                {
                    button.BackColor = Color.Yellow;
                }
                ArrayZuweisung();
                WinCheck();
            }

            // ToDo:
            // Wincheck
            // Diagonale (Außerhalb des Feldes mit Try Catch Block realisieren?
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
        private void ArrayZuweisung()
        {
            // Methode zum Updaten des Arrays an passender Koordinate mit dem jeweiligen Spielersymbol
            spielfeld[spaltenkoordinate, reihenkoordinate] = zug;
        }
        private void WinCheck()
        {
            // Methode zum Testen ob ein Spieler gewonnen hat
            bool gewonnen = false;
            // Reihe kontrollieren
            gewonnen = WinCheckReihe();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            // Spalte kontrollieren
            gewonnen = WinCheckSpalte();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            // Diagonale kontrollieren
            gewonnen = WinCheckDiagonale();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
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
            btn_A1.BackColor = Color.Blue;
            btn_A2.BackColor = Color.Blue;
            btn_A3.BackColor = Color.Blue;
            btn_A4.BackColor = Color.Blue;
            btn_A5.BackColor = Color.Blue;
            btn_A6.BackColor = Color.Blue;
            btn_B1.BackColor = Color.Blue;
            btn_B2.BackColor = Color.Blue;
            btn_B3.BackColor = Color.Blue;
            btn_B4.BackColor = Color.Blue;
            btn_B5.BackColor = Color.Blue;
            btn_B6.BackColor = Color.Blue;
            btn_C1.BackColor = Color.Blue;
            btn_C2.BackColor = Color.Blue;
            btn_C3.BackColor = Color.Blue;
            btn_C4.BackColor = Color.Blue;
            btn_C5.BackColor = Color.Blue;
            btn_C6.BackColor = Color.Blue;
            btn_D1.BackColor = Color.Blue;
            btn_D2.BackColor = Color.Blue;
            btn_D3.BackColor = Color.Blue;
            btn_D4.BackColor = Color.Blue;
            btn_D5.BackColor = Color.Blue;
            btn_D6.BackColor = Color.Blue;
            btn_E1.BackColor = Color.Blue;
            btn_E2.BackColor = Color.Blue;
            btn_E3.BackColor = Color.Blue;
            btn_E4.BackColor = Color.Blue;
            btn_E5.BackColor = Color.Blue;
            btn_E6.BackColor = Color.Blue;
            btn_F1.BackColor = Color.Blue;
            btn_F2.BackColor = Color.Blue;
            btn_F3.BackColor = Color.Blue;
            btn_F4.BackColor = Color.Blue;
            btn_F5.BackColor = Color.Blue;
            btn_F6.BackColor = Color.Blue;
            btn_G1.BackColor = Color.Blue;
            btn_G2.BackColor = Color.Blue;
            btn_G3.BackColor = Color.Blue;
            btn_G4.BackColor = Color.Blue;
            btn_G5.BackColor = Color.Blue;
            btn_G6.BackColor = Color.Blue;
        }
        private void TestFeldBelegt()
        {
            // Methode zum Testen ob das aktuelle Feld bereits belegt ist
            if (spielfeld[spaltenkoordinate, reihenkoordinate] == 'R' || spielfeld[spaltenkoordinate, reihenkoordinate] == 'F')
            {
                zugKorrekt = false;
                message = "Das geklickte Feld ist bereits belegt, bitte wähle ein anderes aus.";
                caption = "Nicht möglich!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TestFeldUnterstesFreies()
        {
            // Methode zum Testen ob das aktuelle Feld das unterste nicht belegte Feld in der Spalte ist
            if (spielfeld[spaltenkoordinate, reihenkoordinate] == 'R' || spielfeld[spaltenkoordinate, reihenkoordinate] == 'F')
            {
                zugKorrekt = false;
                message = "Das geklickte Feld ist nicht das unterste freie Feld dieser Spalte, bitte wähle ein anderes aus.";
                caption = "Nicht möglich!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private int Getspaltenkoordinate(string buttonname)
        {
            // Löst aus dem Namen des Buttons die spaltenkoordinate im Array auf
            char reihe = buttonname[5];
            switch (reihe)
            {
                case 'A':
                    {
                        return 0;
                    }
                case 'B':
                    {
                        return 1;
                    }
                case 'C':
                    {
                        return 2;
                    }
                case 'D':
                    {
                        return 3;
                    }
                case 'E':
                    {
                        return 4;
                    }
                case 'F':
                    {
                        return 5;
                    }
                case 'G':
                    {
                        return 6;
                    }
            }
            return 0;
        }
        private int Getreihenkoordinate(string buttonname)
        {
            // Löst aus dem Namen des Buttons die reihenkoordinate im Array auf
            char spalte = buttonname[6];
            switch (spalte)
            {
                case '1':
                    {
                        return 0;
                    }
                case '2':
                    {
                        return 1;
                    }
                case '3':
                    {
                        return 2;
                    }
                case '4':
                    {
                        return 3;
                    }
                case '5':
                    {
                        return 4;
                    }
                case '6':
                    {
                        return 5;
                    }
            }
            return 0;
        }
        private bool WinCheckSpalte()
        {
            // Testet die Vertikale nach 4 Aufeinanderfolgenden 
            if (spielfeld[spaltenkoordinate, 0] == zug && spielfeld[spaltenkoordinate, 1] == zug && spielfeld[spaltenkoordinate, 2] == zug && spielfeld[spaltenkoordinate, 3] == zug ||
                spielfeld[spaltenkoordinate, 1] == zug && spielfeld[spaltenkoordinate, 2] == zug && spielfeld[spaltenkoordinate, 3] == zug && spielfeld[spaltenkoordinate, 4] == zug ||
                spielfeld[spaltenkoordinate, 2] == zug && spielfeld[spaltenkoordinate, 3] == zug && spielfeld[spaltenkoordinate, 4] == zug && spielfeld[spaltenkoordinate, 5] == zug)
            {
                return true;
            }
            return false;
        }
        private bool WinCheckReihe()
        {
            // Testet die Horizontale nach 4 Aufeinanderfolgenden 
            if (spielfeld[0, reihenkoordinate] == zug && spielfeld[1, reihenkoordinate] == zug && spielfeld[2, reihenkoordinate] == zug && spielfeld[3, reihenkoordinate] == zug ||
                spielfeld[1, reihenkoordinate] == zug && spielfeld[2, reihenkoordinate] == zug && spielfeld[3, reihenkoordinate] == zug && spielfeld[4, reihenkoordinate] == zug ||
                spielfeld[2, reihenkoordinate] == zug && spielfeld[3, reihenkoordinate] == zug && spielfeld[4, reihenkoordinate] == zug && spielfeld[5, reihenkoordinate] == zug ||
                spielfeld[3, reihenkoordinate] == zug && spielfeld[4, reihenkoordinate] == zug && spielfeld[5, reihenkoordinate] == zug && spielfeld[6, reihenkoordinate] == zug)
            {
                return true;
            }
            return false;
        }
        private bool WinCheckDiagonale()
        {
            // Testet die Diagonalen nach 4 Aufeinanderfolgenden 
            int r = reihenkoordinate;
            int s = spaltenkoordinate;
            // Test links oben nach rechts unten
            while (s > 0 && r < 5)
            {
                s--;
                r++;
            }
            if (spielfeld[s + 0, r - 0] == zug && spielfeld[s + 1, r - 1] == zug && spielfeld[s + 2, r - 2] == zug && spielfeld[s + 3, r - 3] == zug ||
                spielfeld[s + 1, r - 1] == zug && spielfeld[s + 2, r - 2] == zug && spielfeld[s + 3, r - 3] == zug && spielfeld[s + 4, r - 4] == zug ||
                spielfeld[s + 2, r - 2] == zug && spielfeld[s + 3, r - 3] == zug && spielfeld[s + 4, r - 4] == zug && spielfeld[s + 5, r - 5] == zug)
            {
                return true;
            }
            // Test links unten nach rechts oben
            while (s > 0 && r > 0)
            {
                s--;
                r--;
            }
            if (spielfeld[s + 0, r + 0] == zug && spielfeld[s + 1, r + 1] == zug && spielfeld[s + 2, r + 2] == zug && spielfeld[s + 3, r + 3] == zug ||
                spielfeld[s + 1, r + 1] == zug && spielfeld[s + 2, r + 2] == zug && spielfeld[s + 3, r + 3] == zug && spielfeld[s + 4, r + 4] == zug ||
                spielfeld[s + 2, r + 2] == zug && spielfeld[s + 3, r + 3] == zug && spielfeld[s + 4, r + 4] == zug && spielfeld[s + 5, r + 5] == zug)
            {
                return true;
            }
            return false;
        }




        private void LegacyArrayZuweisung(string buttonName, char zug)
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
        #endregion
    }
}
