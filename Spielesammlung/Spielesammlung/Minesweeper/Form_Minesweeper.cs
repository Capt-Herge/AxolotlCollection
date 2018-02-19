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

            // Erstellt das Feld mit den Buttons
            ErstelleFeld();

            // Startet ein neues Spiel
            NeuesSpiel();
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
                    buttonArray[x, y].Size = new Size(35, 35);
                    //Position des Buttons wird festgelegt
                    buttonArray[x, y].Left = x * 35;
                    buttonArray[x, y].Top = y * 35;
                    // Hintergundfarbe der Buttons
                    buttonArray[x, y].BackColor = Color.LightSteelBlue;
                    // Hinzufügen des Buttons zum dahinter liegenden Panel
                    panelMinesweeper.Controls.Add(buttonArray[x, y]);
                    // Eventhandler für jeden Button
                    buttonArray[x, y].MouseDown += new MouseEventHandler(ButtonGeklickt);
                }
            }
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
                    // Timer wird gestoppt
                    timerMinesweeper.Stop();

                    // und decke alle Felder auf, die noch verfüfbar sind
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
                    // Button und Label werden sichtbar
                    labelGameOver.Visible = true;
                    buttonNeustart.Visible = true;
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
                //und wenn der Button keine Mine und keine 0 ist,
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
            // Button und Label sind nicht mehr sichtbar
            labelGameOver.Visible = false;
            labelGewonnen.Visible = false;
            buttonNeustart.Visible = false;

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

            // Erzeugt ein Objekt Spielfeld
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
                // der Timer gestoppt
                timerMinesweeper.Stop();
                // der Text mit der Zeit angeseigt
                string gewonnen = "Gewonnen! \n Deine Zeit:\n    " + labelZeitWert.Text;
                labelGewonnen.Text = gewonnen;
                labelGewonnen.Visible = true;
                // und der Button zum Neustarten angezeigt
                buttonNeustart.Visible = true;
            }
        }


        private void buttonNeustart_Click(object sender, EventArgs e)
        {
            // wenn der Button Neustart geklickt wird, beginnt ein neues Spiel
            NeuesSpiel();
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
    }
}
