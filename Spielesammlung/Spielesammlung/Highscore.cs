using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Highscore
{
    // globale Variablen
    string text;

    public string HighscoreEintragen(string spiel, string spieler, string punkte)
    {

        if (spiel.Equals("Minesweeper"))
        { 
            /*
            // Alle Einträge löschen die zu viel sind, damit kein Fehler beim Sortieren auftritt
            EintragLöschenZeit(spiel);
            // neuen Eintrag erstellen mit dem Benutzernamen und dem Score
            EintragErstellenZeit(spiel, spieler, punkte);
            // Alle Einträge nach Höhe des Scores sortieren lassen 
            EinträgeSortierenZeit(spiel);
            // den überflüssigen Eintrag löschen
            EintragLöschenZeit(spiel);
            // der Inhalt der Textdatei wird ausgelesen und in anzeige gespeichert
            string anzeige = EinträgeAnzeigenZeit(spiel);
            // anzeige wird zurückgegeben
            */
            return null;
            
        }
        else
        {
            // Alle Einträge löschen die zu viel sind, damit kein Fehler beim Sortieren auftritt
            EintragLöschenPunkte(spiel);
            // neuen Eintrag erstellen mit dem Benutzernamen und dem Score
            EintragErstellenPunkte(spiel, spieler, punkte);
            // Alle Einträge nach Höhe des Scores sortieren lassen 
            EinträgeSortierenPunkte(spiel);
            // den überflüssigen Eintrag löschen
            EintragLöschenPunkte(spiel);
            // der Inhalt der Textdatei wird ausgelesen und in anzeige gespeichert
            string anzeige = EinträgeAnzeigenPunkte(spiel);
            // anzeige wird zurückgegeben
            return anzeige;
        }
    }

    public string EinträgeAnzeigenPunkte(string spiel)
    {
        //Variablen
        int pos = 1;
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";
        // Alle Zeilen der Textdatei werden gelesen und im Array gespeichert
        string[] zeilen = File.ReadAllLines(datei);
        // Erstellen des StringBuilders zum Anzeigen der Einträge
        StringBuilder sb = new StringBuilder();
        // Fügt eine neue Zeile mit "Name  Score" und einen Zeilenumbruch ein
        sb.Append("Name  Score");
        sb.Append("\n");

        // für alle Zeilen im Array
        foreach (string zeile in zeilen)
        {
            //werden die wörter aus den einzelnen chars zusammen gesetzt (Trennung durch eine Leerstelle)
            string[] wörter = zeile.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // und jedes Wort werden je nach Position in der Textdatei Leerstellen hinzugefügt zur Formatierung
            foreach (string wort in wörter)
            {
                // Position 1 ist der Name des Spielers
                if (pos == 1)
                {
                    sb.Append("  " + wort);
                    sb.Append("       ");
                    pos++;
                }
                // Position 2 ist der Score des Spielers
                else if (pos == 2)
                {
                    sb.Append(wort);
                    pos--;
                }
            }
            // Die Zeile ist nach Eintragen des Namens und des Scores zu ende
            sb.AppendLine();
        }
        // die fertig ausgelesene Textdatei wird zurückgegeben
        return sb.ToString();
    }

    public void EintragErstellenPunkte(string spiel, string spieler, string punkte)
    {
        // Variable mit dem Dateipfad
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";

        // der StreamWriter fügt den Benutzernamen und den Score unten an die Textdatei an
        using (StreamWriter sw = new StreamWriter(datei, true))
        {
            sw.WriteLine(spieler + " " + punkte);
        }
    }

    public void EintragLöschenPunkte(string spiel)
    {
        // Variable mit dem Dateipfad
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";

        // es wird eine Liste erstellt, die die einzelnen Zeilen als strings enthält
        List<string> Zeilen = File.ReadAllLines(datei).ToList<string>();

        // Es werden alle Zeilen gelöscht, die hinter der 10. Zeile stehen
        for (int i = Zeilen.Count - 1; i > 9; i--)
        {
            Zeilen.RemoveAt(i);
            // und das Ergebnis in die Datei geschrieben
            File.WriteAllLines(datei, Zeilen);
        }
    }

    public void EinträgeSortierenPunkte(string spiel)
    {
        // Variablen
        int x = 0;
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";
        // Es wird ein Array erstellt, das Objekte von ScoreItem hält
        ScoreItem[] SpielScores = new ScoreItem[11];
        // Alle Zeilen der Textdatei werden in ein Array geschrieben
        String[] Zeilen = File.ReadAllLines(datei);

        // Für jede einzelne Zeile
        foreach (string zeile in Zeilen)
        {
            // werden die Wörter, die duch eine Leerstelle getrennt sind, ausgelesen
            string[] wort = zeile.Split(' ');
            //
            string nameGelesen = wort[0];
            int punkteGelesen = int.Parse(wort[1]);
            // aus dem Namen und dem Score des Spielers werden die Objekte ScoreItem erstellt und im Array gespeichert
            SpielScores[x] = new ScoreItem(nameGelesen, punkteGelesen);
            x++;
        }

        // das Array wird nach dem Score absteigend sortiert
        Array.Sort(SpielScores, delegate (ScoreItem item1, ScoreItem item2)
        {
            return item2.Score.CompareTo(item1.Score);
        });

        // für jedes ScoreItem werden Name und Score ausgelesen und als String zusammengefügt
        foreach (ScoreItem item in SpielScores)
        {
            text = text + item.Benutzer + " " + item.Score + Environment.NewLine;
        }
        // der zusammgefügte String mit den Namen und Scores werden in Textdatei geschrieben
        File.WriteAllText(datei, text);
    }


    /*

    public string EinträgeAnzeigenZeit(string spiel)
    {
        //Variablen
        int pos = 1;
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";
        // Alle Zeilen der Textdatei werden gelesen und im Array gespeichert
        string[] zeilen = File.ReadAllLines(datei);
        // Erstellen des StringBuilders zum Anzeigen der Einträge
        StringBuilder sb = new StringBuilder();
        // Fügt eine neue Zeile mit "Name  Score" und einen Zeilenumbruch ein
        sb.Append("Name  Score");
        sb.Append("\n");

        // für alle Zeilen im Array
        foreach (string zeile in zeilen)
        {
            //werden die wörter aus den einzelnen chars zusammen gesetzt (Trennung durch eine Leerstelle)
            string[] wörter = zeile.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // und jedes Wort werden je nach Position in der Textdatei Leerstellen hinzugefügt zur Formatierung
            foreach (string wort in wörter)
            {
                // Position 1 ist der Name des Spielers
                if (pos == 1)
                {
                    sb.Append("  " + wort);
                    sb.Append("       ");
                    pos++;
                }
                // Position 2 ist der Score des Spielers
                else if (pos == 2)
                {
                    sb.Append(wort);
                    pos--;
                }
            }
            // Die Zeile ist nach Eintragen des Namens und des Scores zu ende
            sb.AppendLine();
        }
        // die fertig ausgelesene Textdatei wird zurückgegeben
        return sb.ToString();

    }

    public void EintragErstellenZeit(string spiel, string spieler, string punkte)
    {
        // Variable mit dem Dateipfad
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";

        // der StreamWriter fügt den Benutzernamen und den Score unten an die Textdatei an
        using (StreamWriter sw = new StreamWriter(datei, true))
        {
            sw.WriteLine(spieler + " " + punkte);
        }

    }

    public void EintragLöschenZeit(string spiel)
    {
        // Variable mit dem Dateipfad
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";

        // es wird eine Liste erstellt, die die einzelnen Zeilen als strings enthält
        List<string> Zeilen = File.ReadAllLines(datei).ToList<string>();

        // Es werden alle Zeilen gelöscht, die hinter der 10. Zeile stehen
        for (int i = Zeilen.Count - 1; i > 9; i--)
        {
            Zeilen.RemoveAt(i);
            // und das Ergebnis in die Datei geschrieben
            File.WriteAllLines(datei, Zeilen);
        }
    }

    public void EinträgeSortierenZeit(string spiel)
    {
        // Variablen
        int x = 0;
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";
        // Es wird ein Array erstellt, das Objekte von ScoreItem hält
        ScoreItem[] SpielScores = new ScoreItem[11];
        // Alle Zeilen der Textdatei werden in ein Array geschrieben
        String[] Zeilen = File.ReadAllLines(datei);

        // Für jede einzelne Zeile
        foreach (string zeile in Zeilen)
        {
            // werden die Wörter, die duch eine Leerstelle getrennt sind, ausgelesen
            string[] wort = zeile.Split(' ');
            // aus dem Namen und dem Score des Spielers werden die Objekte ScoreItem erstellt und im Array gespeichert
            SpielScores[x] = new ScoreItem(wort[0], int.Parse(wort[1]));
            x++;
        }

        // das Array wird nach dem Score absteigend sortiert
        Array.Sort(SpielScores, delegate (ScoreItem item1, ScoreItem item2)
        {
            return item1.Score.CompareTo(item2.Score);
        });

        // für jedes ScoreItem werden Name und Score ausgelesen und als String zusammengefügt
        foreach (ScoreItem item in SpielScores)
        {
            text = text + item.Benutzer + " " + item.Score + Environment.NewLine;
        }
        // der zusammgefügte String mit den Namen und Scores werden in Textdatei geschrieben
        File.WriteAllText(datei, text);
    }
    */

}


// Klasse ScoreItem für das Einfügen in das Array
public class ScoreItem
{
    // Variablen
    string benutzer;
    int score;

    // getter und setter
    public string Benutzer
    {
        get
        {
            return benutzer;
        }
        set
        {
            benutzer = value;
        }
    }
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }

    // Konstruktor
    public ScoreItem(string name, int wert)
    {
        Benutzer = name;
        Score = wert;
    }

}
