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

        public Form_Minesweeper()
        {
            InitializeComponent();

            // Erzeugt ein Objekt Spielfeld
            new Spielfeld();

            // Erstellt das Feld mit den Buttons
            ErstelleFeld();
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
                    // Ändern des Namens des Buttons
                    buttonArray[x, y].Name = "button" + x + "" + y + "";
                    // Größe des Buttons Festlegen
                    buttonArray[x, y].Size = new Size(35, 35);
                    //Position des Buttons wird festgelegt
                    buttonArray[x, y].Left = x * 35;
                    buttonArray[x, y].Top = y * 35;
                    // Hinzufügen des Buttons zum dahinter liegenden Panels
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


        }



        void NeuesSpiel()
        {
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



    }
}