using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Minesweeper
{
    public partial class Form_Minesweeper : Form
    {
        // Variable, ob das Feld schon erstellt wurde
        bool feldVorhanden = false;
        // Array für die Buttons
        Button[,] buttonArray = new Button[20, 20];
        // Liste für die Minen
        private List<int> ListeMinen = new List<int>();
        // Liste für die Nullen, die noch abgearbeitet werden müssen
        private List<int> NullenAufzudecken = new List<int>();

        public Form_Minesweeper()
        {
            InitializeComponent();

            //Setzen des Intervals des Timers auf 1 Sekunde
            timerMinesweeper.Interval = 1000;
            // Nach 1 Sekunde wird die Zeit erhöht
            timerMinesweeper.Tick += ErhöheZeit;

            // Hintergrundfarbe wird blau, damit die Anleitung besser zu lesen ist
            panelMinesweeper.BackColor = Color.LightSteelBlue;

            // Anleitung, Name des Spiels und der Button zum Starten des Spiels werden angezeigt
            string anleitung = "Klicke mit der linken Maustaste auf die Felder,\num diese aufzudecken. Ziel ist es in möglichst\nkurzer Zeit alle Felder ohne Bomben aufzudecken.\nWenn sich eine Bombe unter dem geklickten Feld\n          befindet ist das Spiel vobei.\nHinweis: Mit Rechtsklick können vermutete Bomben\n         markiert werden ohne diese aufzudecken.";
            labelAnleitung.Text = anleitung;
            labelAnleitung.Visible = true;
            labelMinesweeper.Visible = true;
            buttonStart.Enabled = true;
            buttonStart.Visible = true;

        }

        public void ErstelleFeld()
        {
            // Das Array soll automatisch mit 20x20 Buttons gefüllt werden
            for (int x = 0; x < buttonArray.GetLength(0); x++)
            {
                for (int y = 0; y < buttonArray.GetLength(1); y++)
                {
                    // Erstellen eines Buttons an Position x,y
                    buttonArray[x, y] = new Button();
                    // Größe des Buttons Festlegen
                    buttonArray[x, y].Size = new Size(34, 34);
                    //Position des Buttons wird festgelegt
                    buttonArray[x, y].Left = x * 34;
                    buttonArray[x, y].Top = y * 34;
                    // Hintergundfarbe der Buttons
                    buttonArray[x, y].BackColor = Color.LightSteelBlue;
                    // Hinzufügen des Buttons zum dahinter liegenden Panel
                    panelMinesweeper.Controls.Add(buttonArray[x, y]);
                    // Click-Eventhandler für jeden Button
                    buttonArray[x, y].MouseDown += new MouseEventHandler(ButtonGeklickt);
                }
            }
            // Feld wurde erstellt
            feldVorhanden = true;
        }

        public void ButtonGeklickt(object sender, MouseEventArgs e)
        {
            // sender zu Button casten, damit der "richtige" Button reagiert
            Button button = (Button)sender;

            // wenn die rechte Maustaste gedrückt wurde (für eine vermutete Mine)
            if (e.Button == MouseButtons.Right)
            {
                // und der Button verfügbar ist
                if (button.Enabled == true)
                {
                    // und der Button schon geld ist
                    if (button.BackColor == Color.Yellow)
                    {
                        // wird die Farbe zurückgesetzt 
                        button.BackColor = Color.LightSteelBlue;
                        // und der Button ist wieder "leer"
                        button.Text = "";
                    }
                    // wenn das Feld noch nicht gelb ist
                    else
                    {
                        // wird es gelb gefärbt
                        button.BackColor = Color.Yellow;
                        // und es erscheint ein Ausrufezeichen 
                        button.Text = "!";
                    }
                }
            }
            // wenn die linke Maustaste grdückt wurde
            else if (e.Button == MouseButtons.Left)
            {
                // und wenn der geklickte Button eine Mine ist,
                if (button.Name.Equals("Mine"))
                {
                    // decke alle Felder auf, die noch verfüfbar sind
                    for (int x = 0; x < buttonArray.GetLength(0); x++)
                    {
                        for (int y = 0; y < buttonArray.GetLength(1); y++)
                        {
                            if (buttonArray[x, y].Enabled == true)
                            {
                                // wenn das Feld eine Mine ist
                                if (buttonArray[x, y].Name.Equals("Mine"))
                                {
                                    // Zeige ein "X" auf dem Button an
                                    buttonArray[x, y].Text = "X";
                                    // und färbe ihn rot
                                    buttonArray[x, y].BackColor = Color.Red;
                                }

                                // wenn der Button keine Mine ist
                                else
                                {
                                    // zeige den Namen des Buttons an
                                    buttonArray[x, y].Text = buttonArray[x, y].Name;
                                }

                                // der bearbeitete Button ist dann nicht mehr verfügbar
                                buttonArray[x, y].Enabled = false;
                            }
                        }
                    }

                    //gameover auf true setzen
                    Spielfeld.GameOver = true;
                    // Die Highscoreliste soll eingezeigt werden
                    SpielVorbei();
                }

                // und wenn der geklickte Button eine 0 ist
                else if (button.Name.Equals("0"))
                {
                    // Soll der Button eine 0 anzeigen
                    button.Text = button.Name;
                    // und der Button nicht mehr verfühbar sein
                    button.Enabled = false;
                    // die restlichen Felder um 1 verringern
                    Spielfeld.FelderRest--;

                    // der ausgewählte Button soll in die Liste der Nullen eingetragen werden
                    for (int x = 0; x < buttonArray.GetLength(0); x++)
                    {
                        for (int y = 0; y < buttonArray.GetLength(1); y++)
                        {
                            if (buttonArray[x, y] == button)
                            {
                                // Hinzufügen des Buttons zu der Liste
                                NullenAufzudecken.Add(x * 100 + y);
                            }
                        }
                    }

                    // Es sollen alle anliegenden Nullen mit aufgedeckt werden
                    AufdeckenNullen();
                    // Überprüft, ob der Spieler gewonnen hat
                    Gewonnen();
                }

                // und wenn der Button keine Mine und keine 0 ist,
                else
                {
                    // wird der Name als Text anezeigt
                    button.Text = button.Name;
                    // und der Button ist nicht mehr verfügbar
                    button.Enabled = false;
                    // die restlichen Felder um 1 verringern
                    Spielfeld.FelderRest--;
                    // Überprüft, ob der Spieler gewonnen hat
                    Gewonnen();
                }
            }
        }

        public void NeuesSpiel()
        {
            // Text im Label für die Zeit wird zurückgesetzt
            labelZeitWert.Text = "0:00:00";

            // für jeden Button 
            for (int x = 0; x < buttonArray.GetLength(0); x++)
            {
                for (int y = 0; y < buttonArray.GetLength(1); y++)
                {
                    // Name und Text zurücksetzen
                    buttonArray[x, y].Name = "";
                    buttonArray[x, y].Text = "";
                    // Hintergundfarbe zurücksetzen
                    buttonArray[x, y].BackColor = Color.LightSteelBlue;
                    // Verfügbarkeit zurücksetzen
                    buttonArray[x, y].Enabled = true;
                }
            }

            // Erzeugt ein Objekt Spielfeld, damit beinhaltete Variablen den Standardwert annehmen
            new Spielfeld();

            // Die Liste mit den Minen wird geleert
            ListeMinen.Clear();

            // Es werden neue Positionen für die Minen ermittelt
            PlatziereMinen();

            // Errechnet für jeden Button wie viele Minen im Umkreis vorhanden sind
            MinenNachbarschaft();

            // Der Timer wird gestartet
            timerMinesweeper.Start();
        }

        public void PlatziereMinen()
        {
            // Minen sollen zufällig positioniert werden
            Random zufall = new Random();

            // Es sollen eine bestimmte Anzahl Minen erstellt werden
            for (int i = 1; i <= Spielfeld.Minen; i++)
            {
                // Es werden zufällige x- und y-Werte ermittelt
                int zufallX = zufall.Next(0, (buttonArray.GetLength(0)));
                int zufallY = zufall.Next(0, (buttonArray.GetLength(1)));

                // mit x und y wird der eingetragene Wert berechnet
                int eintrag = zufallX * 100 + zufallY;

                // Wenn der Wert schon in der Liste vorhanden ist, werden solange neue ermittelt, bis ein neuer Wert kommt
                while (ListeMinen.Contains(eintrag))
                {
                    zufallX = zufall.Next(0, (buttonArray.GetLength(0) - 1));
                    zufallY = zufall.Next(0, (buttonArray.GetLength(1) - 1));

                    eintrag = zufallX * 100 + zufallY;
                }

                // Der Name des jeweiligen Buttons wird geändert
                buttonArray[zufallX, zufallY].Name = "Mine";
                // Eintrag wird zur Liste der Minen hinzugefügt
                ListeMinen.Add(eintrag);
            }
        }

        public void MinenNachbarschaft()
        {
            //  Berechnet für jeden Button der keine Mine enthält wie viele Minen im Umkreis sind
            for (int x = 0; x < buttonArray.GetLength(0); x++)
            {
                for (int y = 0; y < buttonArray.GetLength(1); y++)
                {
                    if (buttonArray[x, y].Name != "Mine")
                    {
                        int minenUmkreis = 0;
                        // oben links
                        if (x > 0 && y > 0 && buttonArray[(x - 1), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // oben mitte
                        if (y > 0 && buttonArray[(x), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // oben rechts
                        if (x < buttonArray.GetLength(0) - 1 && y > 0 && buttonArray[(x + 1), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // links
                        if (x > 0 && buttonArray[(x - 1), (y)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // rechts
                        if (x < buttonArray.GetLength(0) - 1 && buttonArray[(x + 1), (y)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // unten links
                        if (x > 0 && y < buttonArray.GetLength(1) - 1 && buttonArray[(x - 1), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // unten mitte
                        if (y < buttonArray.GetLength(1) - 1 && buttonArray[(x), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // unten rechts
                        if (x < buttonArray.GetLength(0) - 1 && y < buttonArray.GetLength(1) - 1 && buttonArray[(x + 1), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }

                        // Der Name ist die Menge der Minen im Umkreis
                        buttonArray[x, y].Name = minenUmkreis.ToString();
                    }
                }
            }
        }

        public void AufdeckenNullen()
        {
            // läuft solange, bis die Liste leer ist
            while (NullenAufzudecken.Count != 0)
            {
                // Werte für X und Y werden ermittelt
                int x = NullenAufzudecken[0] / 100;
                int y = NullenAufzudecken[0] % 100;
                // und der Eintrag in der Liste entfernt
                NullenAufzudecken.RemoveAt(0);

                // oben links
                if (x > 0 && y > 0)
                {
                    if (buttonArray[x - 1, y - 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x - 1, y - 1].Text = buttonArray[x - 1, y - 1].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x - 1, y - 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x - 1, y - 1].Name == "0")
                        {
                            NullenAufzudecken.Add((x - 1) * 100 + (y - 1));
                        }
                    }
                }

                // oben mitte
                if (y > 0)
                {
                    if (buttonArray[x, y - 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x, y - 1].Text = buttonArray[x, y - 1].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x, y - 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x, y - 1].Name == "0")
                        {
                            NullenAufzudecken.Add(x * 100 + (y - 1));
                        }
                    }
                }

                // oben rechts
                if (x < (buttonArray.GetLength(0) - 1) && y > 0)
                {
                    if (buttonArray[x + 1, y - 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x + 1, y - 1].Text = buttonArray[x + 1, y - 1].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x + 1, y - 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x + 1, y - 1].Name == "0")
                        {
                            NullenAufzudecken.Add((x + 1) * 100 + (y - 1));
                        }
                    }
                }

                // links
                if (x > 0)
                {
                    if (buttonArray[x - 1, y].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x - 1, y].Text = buttonArray[x - 1, y].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x - 1, y].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x - 1, y].Name == "0")
                        {
                            NullenAufzudecken.Add((x - 1) * 100 + y);
                        }
                    }
                }

                // rechts
                if (x < (buttonArray.GetLength(0) - 1))
                {
                    if (buttonArray[x + 1, y].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x + 1, y].Text = buttonArray[x + 1, y].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x + 1, y].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x + 1, y].Name == "0")
                        {
                            NullenAufzudecken.Add((x + 1) * 100 + y);
                        }
                    }
                }

                // unten links
                if (x > 0 && y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x - 1, y + 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x - 1, y + 1].Text = buttonArray[x - 1, y + 1].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x - 1, y + 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x - 1, y + 1].Name == "0")
                        {
                            NullenAufzudecken.Add((x - 1) * 100 + (y + 1));
                        }
                    }
                }

                // unten mitte
                if (y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x, y + 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x, y + 1].Text = buttonArray[x, y + 1].Name;
                        buttonArray[x, y + 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x, y + 1].Name == "0")
                        {
                            NullenAufzudecken.Add(x * 100 + (y + 1));
                        }
                    }
                }

                // unten rechts
                if (x < buttonArray.GetLength(0) - 1 && y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x + 1, y + 1].Enabled == true)
                    {
                        // der Name wird als Text gesetzt
                        buttonArray[x + 1, y + 1].Text = buttonArray[x + 1, y + 1].Name;
                        // Button ist nicht mehr verfügbar
                        buttonArray[x + 1, y + 1].Enabled = false;
                        // die restlichen Felder um 1 verringern
                        Spielfeld.FelderRest--;

                        // wenn ein Nachbarbutton eine 0 ist, wird er zur Liste hinzugefügt
                        if (buttonArray[x + 1, y + 1].Name == "0")
                        {
                            NullenAufzudecken.Add((x + 1) * 100 + (y + 1));
                        }
                    }
                }

                // Methode wird wieder aufgerufen, um gesamten Bereich aufzudecken
                AufdeckenNullen();
            }
        }

        public void Gewonnen()
        {
            // Wenn keine restlichen Felder mehr übrig sind           
            if (Spielfeld.FelderRest == 0)
            {
                // wird gewonnen auf true gesetzt
                Spielfeld.Gewonnen = true;
                // Der Score soll eingetragen und die Highscoreliste angezeigt werden
                SpielVorbei();
            }
        }

        public void ErhöheZeit(object sender, EventArgs e)
        {
            // wenn Sekunde nicht 59 ist
            if (Spielfeld.Sekunde != 59)
            {
                // wird Sekunde um 1 erhöht
                Spielfeld.Sekunde += 1;

                // je nach Höhe der Sekunden und Minuten wird die Zeit entsprechend angezeigt
                if (Spielfeld.Sekunde < 10 && Spielfeld.Minute >= 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":" + Spielfeld.Minute.ToString() + ":0" + Spielfeld.Sekunde.ToString();
                }
                else if (Spielfeld.Sekunde >= 10 && Spielfeld.Minute < 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":0" + Spielfeld.Minute.ToString() + ":" + Spielfeld.Sekunde.ToString();
                }
                else if (Spielfeld.Sekunde < 10 && Spielfeld.Minute < 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":0" + Spielfeld.Minute.ToString() + ":0" + Spielfeld.Sekunde.ToString();
                }
                else
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":" + Spielfeld.Minute.ToString() + ":" + Spielfeld.Sekunde.ToString();
                }
            }

            // wenn Sekunde 59 ist
            else if (Spielfeld.Sekunde == 59)
            {
                // wird Sekunde auf 0 gesetzt
                Spielfeld.Sekunde = 0;
                // wird Minute um 1 erhöht
                Spielfeld.Minute += 1;

                // wenn Minute auch 59 ist
                if (Spielfeld.Minute == 59)
                {
                    // wird Minute auf 0 gesetzt
                    Spielfeld.Minute = 0;
                    // wird Stunde auf 1 gesetzt
                    Spielfeld.Stunde += 1;
                }

                // je nach Höhe der Sekunden und Minuten wird die Zeit entsprechend angezeigt
                if (Spielfeld.Sekunde < 10 && Spielfeld.Minute >= 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":" + Spielfeld.Minute.ToString() + ":0" + Spielfeld.Sekunde.ToString();
                }
                else if (Spielfeld.Sekunde >= 10 && Spielfeld.Minute < 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":0" + Spielfeld.Minute.ToString() + ":" + Spielfeld.Sekunde.ToString();
                }
                else if (Spielfeld.Sekunde < 10 && Spielfeld.Minute < 10)
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":0" + Spielfeld.Minute.ToString() + ":0" + Spielfeld.Sekunde.ToString();
                }
                else
                {
                    labelZeitWert.Text = Spielfeld.Stunde.ToString() + ":" + Spielfeld.Minute.ToString() + ":" + Spielfeld.Sekunde.ToString();
                }
            }
        }

        public void SpielVorbei()
        {
            // Wird ausgeführt, wenn man das Spiel gewonnen hat
            if (Spielfeld.Gewonnen == true)
            {
                // der Timer gestoppt
                timerMinesweeper.Stop();

                // Die Nachricht gewonnen mit der Zeit, die Textbox für den Spielernamen und der Button zum Bestätigen wird angezeigt
                string gewonnen = "            Gewonnen!\n         Score: " + labelZeitWert.Text + "\nBitte gib deinen Spielernamen ein\n        (genau 3 Zeichen)";
                labelGewonnen.Text = gewonnen;
                labelGewonnen.Visible = true;
                buttonWeiter.Visible = true;
                buttonWeiter.Enabled = true;
                textBoxSpieler.Visible = true;
                textBoxSpieler.Enabled = true;

            }
            // Wird ausgeführt, wenn man das Spiel verloren hat
            else if (Spielfeld.GameOver == true)
            {
                // Es wird ein Objekt vom Tyo Highscore erstellt
                Highscore minesweeperHighscore = new Highscore();

                // Timer wird gestoppt
                timerMinesweeper.Stop();

                // Der aktuelle Highscore soll engezeigt werden
                labelHighscore.Text = minesweeperHighscore.EinträgeAnzeigenZeit("Minesweeper");
                labelHighscore.Visible = true;

                // Button zum Neustart und Label GameOver werden sichtbar
                labelGameOver.Visible = true;
                buttonNeustart.Visible = true;
                buttonNeustart.Enabled = true;

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Anleitung, Name des Spiels und der Button zum Starten sind während des Spiels nicht sichtbar
            labelAnleitung.Visible = false;
            labelMinesweeper.Visible = false;
            buttonStart.Visible = false;
            // und der Button nicht aktiviert
            buttonStart.Enabled = false;

            // Der Hintergrund soll während des Spiels schwarz sein, damit die Abgrenzung der Felder deutlicher ist
            panelMinesweeper.BackColor = Color.Black;

            // Erstellt das Feld mit den Buttons
            ErstelleFeld();

            // Startet ein neues Spiel
            NeuesSpiel();
        }

        private void buttonNeustart_Click(object sender, EventArgs e)
        {
            //Hintergrundfarbe und Feld werden erstellt, falls man das Spiel nicht über den Button beim Highscore startet
            if (feldVorhanden == false)
            {
                panelMinesweeper.BackColor = Color.Black;
                ErstelleFeld();
            }
            // Startet ein neues Spiel
            NeuesSpiel();
            // der Highscore, die jeweilige Nachrichte (Gewonnen oder GameOver), und diw Button für einen Neustart und zum Weiterspielen werden ausgeblendet
            labelHighscore.Visible = false;
            labelGameOver.Visible = false;
            labelGewonnen.Visible = false;
            buttonNeustart.Visible = false;
            buttonNeustart.Enabled = false;
            buttonWeiterspielen.Visible = false;
            buttonWeiterspielen.Enabled = false;
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            // Überprüft, ob das Textfeld genau 3 Zeichen enthält
            if (textBoxSpieler.TextLength == 3)
            {
                // Der Button zum Bestätigen, die Textbox für den Spielernamen und der Schirftzug Gewonnen werden ausgeblendet
                buttonWeiter.Visible = false;
                buttonWeiter.Enabled = false;
                textBoxSpieler.Visible = false;
                textBoxSpieler.Enabled = false;
                labelGewonnen.Visible = false;

                // Es wird ein Objekt vom Tyo Highscore erstellt
                Highscore minesweeperHighscore = new Highscore();

                // Der Spielername wird aus der Textbox übernommen
                string spieler = textBoxSpieler.Text;
                // Die Zeit wird aus dem Label genommen, das diese anzeigt
                string punktzahl = labelZeitWert.Text;

                // Der Score wird eingetragen und die neue Highscoreliste angezeigt
                labelHighscore.Text = minesweeperHighscore.HighscoreEintragen("Minesweeper", spieler, punktzahl);
                labelHighscore.Visible = true;

                // Der Button für den Neustart wird sichtbar und aktiviert
                buttonNeustart.Visible = true;
                buttonNeustart.Enabled = true;

            }
        }

        private void zurückZumMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_Menue.spielGestartet = false;
            this.Close();
        }

        private void neustartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Falls Buttons oder Label angezeigt werden, werden diese ausgeblendet
            labelAnleitung.Visible = false;
            labelMinesweeper.Visible = false;
            buttonStart.Visible = false;
            buttonStart.Enabled = false;
            labelGameOver.Visible = false;
            textBoxSpieler.Visible = false;
            textBoxSpieler.Enabled = false;
            buttonWeiter.Visible = false;
            buttonWeiter.Enabled = false;
            labelHighscore.Visible = false;
            buttonNeustart.Visible = false;
            buttonNeustart.Enabled = false;
            buttonWeiterspielen.Visible = false;
            buttonWeiterspielen.Enabled = false;
            //Hintergrundfarbe und Feld werden erstellt, falls man das Spiel nicht über den Button beim Highscore startet
            if (feldVorhanden == false)
            {
                panelMinesweeper.BackColor = Color.Black;
                ErstelleFeld();
            }
            // Es wird ein neues Spiel gestartet
            NeuesSpiel();
        }

        private void highscoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Falls Buttons oder Label angezeigt werden, werden diese ausgeblendet
            labelAnleitung.Visible = false;
            labelMinesweeper.Visible = false;
            buttonStart.Visible = false;
            buttonStart.Enabled = false;
            labelGameOver.Visible = false;
            labelGewonnen.Visible = false;
            textBoxSpieler.Visible = false;
            textBoxSpieler.Enabled = false;
            buttonWeiter.Visible = false;
            buttonWeiter.Enabled = false;
            // Die Zeit wird angehalten
            timerMinesweeper.Stop();
            // erstellen eines Objektes der Klasse Highscore
            Highscore minesweeperHighscore = new Highscore();
            // Anzeigen des Highscores
            labelHighscore.Text = minesweeperHighscore.EinträgeAnzeigenZeit("Minesweeper");
            labelHighscore.Visible = true;
            // Der Button zum Neustart wird sichtbar und verfügbar
            buttonNeustart.Visible = true;
            buttonNeustart.Enabled = true;
            // Der Button zum Weiterspielen wird sichtbar und verfügbar
            buttonWeiterspielen.Visible = true;
            buttonWeiterspielen.Enabled = true;
        }

        private void buttonWeiterspielen_Click(object sender, EventArgs e)
        {
            //Hintergrundfarbe und Feld werden erstellt, falls man das Spiel nicht über den Button beim Highscore startet
            if (feldVorhanden == false)
            {
                panelMinesweeper.BackColor = Color.Black;
                ErstelleFeld();
                NeuesSpiel();
            }
            // Die Zeit läuft weiter
            timerMinesweeper.Start();
            // Der Highscore wird nicht mehr angezeigt
            labelHighscore.Visible = false;
            // Die Button zum Neustart und zum Weiterspielen werden unsichtbar und sind nicht mehr verfügbar
            buttonNeustart.Visible = false;
            buttonNeustart.Enabled = false;
            buttonWeiterspielen.Visible = false;
            buttonWeiterspielen.Enabled = false;
        }

        private void Form_Minesweeper_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_Menue.spielGestartet = false;
        }
    }
}