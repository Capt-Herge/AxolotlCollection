﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Tic_Tac_Toe
{
    public partial class Form_Tic_Tac_Toe : Form
    {
        #region Variablendeklaration
        char[,] spielfeld = new char[3, 3];
        char zug = 'X';
        string message = "404";
        string caption = "404";
        int punkteX = 0;
        int punkteO = 0;
        int zugCounter = 0;
        #endregion
        public Form_Tic_Tac_Toe()
        {
            InitializeComponent();
            NeueRunde();
        }
        #region Eventhandler
        private void btn_Spielfeld_Click(object sender, EventArgs e)
        {
            // ClickeventHandler für alle 3x3=9 Spielfeldbuttons
            // Casten des geklickten Buttons, sodass genau der Button verwendet werden kann
            Button button = (Button)sender;

            // IF-Anweisung testet ob das Feld bereits belegt ist
            if (button.Text != "X" && button.Text != "O")
            {
                // Aufruf der Methode mit dem Switchcase
                // Setzt das Array an passender Stelle
                ArrayZuweisung(button.Name.ToString(), zug);

                // Erhöhen des Zug-Zählers
                zugCounter = zugCounter + 1;

                // Setzen des Button.Text mit X oder O
                // Dazu Aufruf von Wincheck zur Prüfung auf Sieg
                // Anschließendes Ändern der Variable "zug" zum Spielerwechsel
                if (zug == 'X')
                {
                    button.Text = "X";
                    WinCheck();
                    zug = 'O';
                    lbl_zuganzeige.Text = "Spieler O";
                }
                else
                {
                    button.Text = "O";
                    WinCheck();
                    zug = 'X';
                    lbl_zuganzeige.Text = "Spieler X";
                }
            }
            else
            {
                // Eine Messagebox wird ausgegeben wenn versucht wird ein Feld zu überschreiben
                message = "Dieses Feld ist bereits belegt! \nBitte wähle ein anderes Feld aus.";
                caption = "Warnung!";
                ShowMessage();
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            // Eventhandler vom Resetbutton und Zurücksetzen-Menüeintrag
            // Startet neue Runde und setzt alle weiteren Variablen zurück
            NeueRunde();
            zug = 'X';
            lbl_zuganzeige.Text = "Spieler X";
            lbl_punkteX.Text = "0";
            lbl_punkteO.Text = "0";
            punkteX = 0;
            punkteO = 0;
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
        private void form_TicTacToe_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Wird ausgeführt wenn die Forms durch Klick auf das X oben rechts geschlossen wird
            form_Menue.spielGestartet = false;
        }
        #endregion
        #region Methoden
        private void ArrayInitialisieren()
        {
            // Methode zum Initialisieren des Arrays
            for (int s = 0; s < 3; s++)
            {
                for (int r = 0; r < 3; r++)
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
            }
        }
        private void WinCheck()
        {
            // Methode zum Testen ob jemand gewonnen hat
            for (int i = 0; i < 3; i++)
            {
                if (spielfeld[i, 0] == zug && spielfeld[i, 1] == zug && spielfeld[i, 2] == zug)
                {
                    // Horizontaler Sieg
                    Gewonnen();
                }
                if (spielfeld[0, i] == zug && spielfeld[1, i] == zug && spielfeld[2, i] == zug)
                {
                    // Vertikaler Sieg
                    Gewonnen();
                }
            }
            if (spielfeld[0, 0] == zug && spielfeld[1, 1] == zug && spielfeld[2, 2] == zug)
            {
                // Diagonaler Sieg linksoben nach rechtsunten
                Gewonnen();
            }
            if (spielfeld[2, 0] == zug && spielfeld[1, 1] == zug && spielfeld[0, 2] == zug)
            {
                // Diagonaler Sieg linksunten nach rechtsoben
                Gewonnen();
            }

            if (zugCounter == 9)
            {
                message = "Diese Runde ging leider unentschieden aus!";
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
            if (zug == 'X')
            {
                punkteX++;
                lbl_punkteX.Text = punkteX.ToString();
                message = "X hat diese Runde gewonnen!";
            }
            else
            {
                punkteO++;
                lbl_punkteO.Text = punkteO.ToString();
                message = "O hat diese Runde gewonnen!";
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
            btn_A1.Text = "";
            btn_A2.Text = "";
            btn_A3.Text = "";
            btn_B1.Text = "";
            btn_B2.Text = "";
            btn_B3.Text = "";
            btn_C1.Text = "";
            btn_C2.Text = "";
            btn_C3.Text = "";
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
