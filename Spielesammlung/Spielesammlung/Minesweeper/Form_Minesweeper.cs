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

            // Erstellt das Feld mit den Buttons
            ErstelleFeld();

            // Startet ein neues Spiel
            NeuesSpiel();

        }

        private void ErstelleFeld()
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
                    // Click-Eventhandler für jeden Button
                    buttonArray[x, y].Click += new EventHandler(ButtonGeklickt);

                }
            }
        }


        void ButtonGeklickt(object sender, EventArgs e)
        {
            // sender zu Button casten, damit der "richtige" Button reagiert
            Button button = (Button)sender;

            // wenn der geklickte Button eine Mine ist,
            if (button.Name.Equals("Mine"))
            {
                // dann färbe den Button rot
                button.BackColor = Color.Red;

                // und decke alle Felder auf
                for (int x = 0; x < buttonArray.GetLength(0); x++)
                {
                    for (int y = 0; y < buttonArray.GetLength(1); y++)
                    {
                        if (buttonArray[x, y].Enabled == true)
                        {
                            if (buttonArray[x, y].Name.Equals("Mine"))
                            {
                                buttonArray[x, y].Text = "X";
                            }
                            else
                            {
                                buttonArray[x, y].Text = buttonArray[x, y].Name;
                            }

                            buttonArray[x, y].Enabled = false;
                        }
                    }
                }

                Spielfeld.GameOver = true;
                labelGameOver.Visible = true;
                buttonNeustart.Visible = true;

            }

            else if (button.Name.Equals("0"))
            {
                button.Text = button.Name;
                button.Enabled = false;

                for (int x = 0; x < buttonArray.GetLength(0); x++)
                {
                    for (int y = 0; y < buttonArray.GetLength(1); y++)
                    {
                        if (buttonArray[x, y] == button)
                        {
                            NullenAufzudecken.Add(x + 100 + y);
                        }
                    }
                }

                AufdeckenNullen();

            }

            else
            {
                button.Text = button.Name;
                button.Enabled = false;
            }

        }



        void NeuesSpiel()
        {
            // Button und Label sind nicht mehr sichtbar
            labelGameOver.Visible = false;
            buttonNeustart.Visible = false;

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

            // Gameover wird zurück auf false gesetzt
            Spielfeld.GameOver = false;

            // Die Liste mit den Minen wird geleert
            ListeMinen.Clear();
            // Es werden neue Positionen für die Minen ermittelt
            PlatziereMinen();

            // Errechnet für jeden Button wie viele Minen im Umkreis vorhanden sind
            MinenNachbarschaft();


        }


        void PlatziereMinen()
        {
            // Minen sollen zufällig positioniert werden
            Random zufall = new Random();

            // Es sollen eine bestimmte Anzahl Minen erstellt werden
            for (int i = 1; i <= Spielfeld.Minen; i++)
            {
                // Es werden zufällige x- und y-Werte ermittelt
                int zufallX = zufall.Next(0, (buttonArray.Length - 1));
                int zufallY = zufall.Next(0, (buttonArray.Length - 1));

                // mit x und y wird der eingetragene Wert berechnet
                int eintrag = zufallX * 100 + zufallY;

                // Wenn der Wert schon in der Liste vorhanden ist, werden solange neue ermittelt, bis ein neuer Wert kommt
                while (ListeMinen.Contains(eintrag))
                {
                    zufallX = zufall.Next(0, (buttonArray.GetLength(0) - 1));
                    zufallY = zufall.Next(0, (buttonArray.GetLength(1) - 1));

                    eintrag = zufallX * 100 + zufallY;
                }

                // Der Name und der Text des jeweiligen Buttons werden geändert
                buttonArray[zufallX, zufallY].Name = "Mine";
                buttonArray[zufallX, zufallY].Text = "*";

                // Eintrag wird zur Liste der Minen hinzugefügt
                ListeMinen.Add(eintrag);
            }
        }

        void MinenNachbarschaft()
        {
            int minenUmkreis = 0;
            //  Berechnet für jeden Button der keine Mine enthält wie viele Minen im Umkreis sind
            for (int x = 0; x < buttonArray.GetLength(0); x++)
            {
                for (int y = 0; y < buttonArray.GetLength(1); y++)
                {
                    if (buttonArray[x, y].Name != "Mine")
                    {
                        // Oben Links
                        if (x > 0 && y > 0 && buttonArray[(x - 1), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Oben
                        if (y > 0 && buttonArray[(x), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Oben Rechts
                        if (x < buttonArray.GetLength(0) - 1 && y > 0 && buttonArray[(x + 1), (y - 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Links
                        if (x > 0 && buttonArray[(x - 1), (y)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Rechts
                        if (x < buttonArray.GetLength(0) - 1 && buttonArray[(x + 1), (y)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Unten Links
                        if (x > 0 && y < buttonArray.GetLength(1 - 1) && buttonArray[(x - 1), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Unten
                        if (y < buttonArray.GetLength(1) - 1 && buttonArray[(x), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }
                        // Unten Rechts
                        if (x < buttonArray.GetLength(0) - 1 && y < buttonArray.GetLength(1 - 1) && buttonArray[(x + 1), (y + 1)].Name == "Mine")
                        {
                            minenUmkreis++;
                        }

                        buttonArray[x, y].Name = minenUmkreis.ToString() + "Minen";
                        buttonArray[x, y].Text = minenUmkreis.ToString();
                    }
                }
            }
        }

        void AufdeckenNullen()
        {
            while (NullenAufzudecken.Count != 0)
            {
                int x = NullenAufzudecken[0] / 100;
                int y = NullenAufzudecken[0] % 100;
                NullenAufzudecken.RemoveAt(0);

                // oben links
                if (x > 0 && y > 0)
                {
                    if (buttonArray[x - 1, y - 1].Name == "0")
                    {
                        if (buttonArray[x - 1, y - 1].Enabled == true)
                        {
                            buttonArray[x - 1, y - 1].Text = buttonArray[x - 1, y - 1].Name;
                            NullenAufzudecken.Add((x - 1) * 100 + (y - 1));
                            buttonArray[x - 1, y - 1].Enabled = false;
                        }
                    }
                }
                // oben mitte
                if (y > 0)
                {
                    if (buttonArray[x, y - 1].Name == "0")
                    {
                        if (buttonArray[x, y - 1].Enabled == true)
                        {
                            buttonArray[x, y - 1].Text = buttonArray[x, y - 1].Name;
                            NullenAufzudecken.Add(x * 100 + (y - 1));
                            buttonArray[x, y - 1].Enabled = false;
                        }
                    }
                }
                // oben rechts
                if (x < buttonArray.GetLength(0) - 1 && y > 0)
                {
                    if (buttonArray[x + 1, y - 1].Name == "0")
                    {
                        if (buttonArray[x + 1, y - 1].Enabled == true)
                        {
                            buttonArray[x + 1, y - 1].Text = buttonArray[x + 1, y - 1].Name;
                            NullenAufzudecken.Add((x + 1) * 100 + (y - 1));
                            buttonArray[x + 1, y - 1].Enabled = false;
                        }
                    }
                }
                // links
                if (x > 0)
                {
                    if (buttonArray[x - 1, y].Name == "0")
                    {
                        if (buttonArray[x - 1, y].Enabled == true)
                        {
                            buttonArray[x - 1, y].Text = buttonArray[x - 1, y].Name;
                            NullenAufzudecken.Add((x - 1) * 100 + y);
                            buttonArray[x - 1, y].Enabled = false;
                        }
                    }
                }
                // rechts
                if (x < buttonArray.GetLength(0) - 1)
                {
                    if (buttonArray[x + 1, y].Name == "0")
                    {
                        if (buttonArray[x + 1, y].Enabled == true)
                        {
                            buttonArray[x + 1, y].Text = buttonArray[x + 1, y].Name;
                            NullenAufzudecken.Add((x + 1) * 100 + y);
                            buttonArray[x + 1, y].Enabled = false;
                        }
                    }
                }
                // unten links
                if (x > 0 && y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x - 1, y + 1].Name == "0")
                    {
                        if (buttonArray[x - 1, y + 1].Enabled == true)
                        {
                            buttonArray[x - 1, y + 1].Text = buttonArray[x - 1, y + 1].Name;
                            NullenAufzudecken.Add((x - 1) * 100 + (y + 1));
                            buttonArray[x - 1, y + 1].Enabled = false;
                        }
                    }
                }
                // unten mitte
                if (y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x, y + 1].Name == "0")
                    {
                        if (buttonArray[x, y + 1].Enabled == true)
                        {
                            buttonArray[x, y + 1].Text = buttonArray[x, y + 1].Name;
                            NullenAufzudecken.Add(x * 100 + (y + 1));
                            buttonArray[x, y + 1].Enabled = false;
                        }
                    }
                }
                // unten rechts
                if (x < buttonArray.GetLength(0) - 1 && y < buttonArray.GetLength(1) - 1)
                {
                    if (buttonArray[x + 1, y + 1].Name == "0")
                    {
                        if (buttonArray[x + 1, y + 1].Enabled == true)
                        {
                            buttonArray[x + 1, y + 1].Text = buttonArray[x + 1, y + 1].Name;
                            NullenAufzudecken.Add((x + 1) * 100 + (y + 1));
                            buttonArray[x + 1, y + 1].Enabled = false;
                        }
                    }
                }

                AufdeckenNullen();
            }
        }

        private void buttonNeustart_Click(object sender, EventArgs e)
        {
            NeuesSpiel();
        }
    }
}