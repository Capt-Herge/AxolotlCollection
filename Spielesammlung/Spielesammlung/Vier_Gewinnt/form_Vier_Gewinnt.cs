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
        // ToDo:
        // Tests und Bugfixing
        #region Variablendeklaration
        char[,] spielfeld = new char[7, 6];
        char zug = 'R';
        string message = "404";
        string caption = "404";
        int punkteR = 0;
        int punkteG = 0;
        int zugCounter = 0;
        int spaltenkoordinate = 0;
        int reihenkoordinate = 0;
        bool zugKorrekt = true;
        #endregion
        public form_Vier_Gewinnt()
        {
            InitializeComponent();
            NeueRunde();
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
                if (zug == 'G')
                {
                    button.BackColor = Color.Yellow;
                }
                zugCounter++;
                ArrayZuweisung();
                WinCheck();
                // Spielerwechsel
                if (zug == 'R')
                {
                    zug = 'G';
                    lbl_zuganzeige.BackColor = Color.Yellow;
                    lbl_zuganzeige.Text = "Gelb";
                }
                else
                {
                    zug = 'R';
                    lbl_zuganzeige.BackColor = Color.Red;
                    lbl_zuganzeige.Text = "Rot";
                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Eventhandler vom Resetbutton und Zurücksetzen-Menüeintrag
            // Startet neue Runde und setzt alle weiteren Variablen zurück
            NeueRunde();
            lbl_punkteR.Text = "0";
            lbl_punkteG.Text = "0";
            punkteR = 0;
            punkteG = 0;
            zug = 'R';
            lbl_zuganzeige.BackColor = Color.Red;
            lbl_zuganzeige.Text = "Rot";
        }
        private void btn_menue_Click(object sender, EventArgs e)
        {
            // zum Menü wechseln, Form beenden
            form_Menue.spielGestartet = false;
            this.Close();
        }
        private void btn_messageOK_Click(object sender, EventArgs e)
        {
            // Lässt das Messageoverlay ausblenden
            btn_messageOK.Visible = false;
            lbl_caption.Visible = false;
            lbl_message.Visible = false;
            lbl_messagebackground.Visible = false;
        }
        private void form_Vier_Gewinnt_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Wird ausgeführt wenn die Forms durch Klick auf das X oben rechts geschlossen wird
            form_Menue.spielGestartet = false;
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
            // Spalte kontrollieren
            gewonnen = WinCheckSpalte();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            // Reihe kontrollieren
            gewonnen = WinCheckReihe();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            // Diagonalen kontrollieren
            gewonnen = WinCheckDiagonaleLinksObenRechtsUnten();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            gewonnen = WinCheckDiagonaleLinksUntenRechtsOben();
            if (gewonnen == true)
            {
                Gewonnen();
                return;
            }
            // Zugzahl kontrollieren: 42 Züge ohne Sieger => Alle Felder belegt, Unentschieden
            if (zugCounter == 42)
            {
                message = "Diese Runde ging leider unentschieden aus.";
                caption = "Unentschieden!";
                ShowMessage();
                NeueRunde();
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
                message = "Rot hat diese Runde gewonnen!";
            }
            else
            {
                punkteG++;
                lbl_punkteG.Text = punkteG.ToString();
                message = "Gelb hat diese Runde gewonnen!";
            }
            caption = "Gewonnen!";
            ShowMessage();

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
            if (spielfeld[spaltenkoordinate, reihenkoordinate] == 'R' || spielfeld[spaltenkoordinate, reihenkoordinate] == 'G')
            {
                zugKorrekt = false;
                message = "Das geklickte Feld ist bereits belegt, bitte wähle ein anderes aus.";
                caption = "Nicht möglich!";
                ShowMessage();
            }
        }
        private void TestFeldUnterstesFreies()
        {
            // Methode zum Testen ob das aktuelle Feld das unterste nicht belegte Feld in der Spalte ist
            if (reihenkoordinate == 0)
            {
                return;
            }
            if (spielfeld[spaltenkoordinate, reihenkoordinate - 1] == 'L')
            {
                zugKorrekt = false;
                message = "Das geklickte Feld ist nicht das unterste freie Feld dieser Spalte, bitte wähle ein anderes aus.";
                caption = "Nicht möglich!";
                ShowMessage();
            }
        }
        private int Getspaltenkoordinate(string buttonname)
        {
            // Löst aus dem Namen des Buttons die Spaltenkoordinate im Array auf
            char spalte = buttonname[4];
            switch (spalte)
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
            // Löst aus dem Namen des Buttons die Reihenkoordinate im Array auf
            char reihe = buttonname[5];
            switch (reihe)
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
        private bool WinCheckDiagonaleLinksObenRechtsUnten()
        {
            try
            {
                // Testet die Diagonale links oben nach rechts unten nach 4 Aufeinanderfolgenden
                int s = spaltenkoordinate;
                int r = reihenkoordinate;

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
                return false;
            }
            catch
            {
                return false;
            }
        }
        private bool WinCheckDiagonaleLinksUntenRechtsOben()
        {
            try
            {
                // Testet die Diagonale links unten nach rechts oben nach 4 Aufeinanderfolgenden
                int s = spaltenkoordinate;
                int r = reihenkoordinate;
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
            catch
            {
                return false;
            }
        }
        private void ShowMessage()
        {
            // Anpassen und Anzeigen der Label für das Messageoverlay
            lbl_caption.Text = caption;
            lbl_message.Text = message;
            btn_messageOK.Visible = true;
            lbl_caption.Visible = true;
            lbl_message.Visible = true;
            lbl_messagebackground.Visible = true;
        }
        #endregion

    }
}
