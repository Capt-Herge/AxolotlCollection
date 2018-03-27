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
            // Alle Einträge löschen die zu viel sind, damit kein Fehler beim Sortieren auftritt
            EintragLöschen(spiel);
            // neuen Eintrag erstellen mit dem Benutzernamen und dem Score
            EintragErstellen(spiel, spieler, punkte);
            // Alle Einträge nach Höhe des Scores sortieren lassen 
            EinträgeSortierenZeit(spiel);
            // den überflüssigen Eintrag löschen
            EintragLöschen(spiel);
            // der Inhalt der Textdatei wird ausgelesen und in anzeige gespeichert
            string anzeige = EinträgeAnzeigenZeit(spiel);
            return anzeige;
        }
        else
        {
            // Alle Einträge löschen die zu viel sind, damit kein Fehler beim Sortieren auftritt
            EintragLöschen(spiel);
            // neuen Eintrag erstellen mit dem Benutzernamen und dem Score
            EintragErstellen(spiel, spieler, punkte);
            // Alle Einträge nach Höhe des Scores sortieren lassen 
            EinträgeSortierenPunkte(spiel);
            // den überflüssigen Eintrag löschen
            EintragLöschen(spiel);
            // der Inhalt der Textdatei wird ausgelesen und in anzeige gespeichert
            string anzeige = EinträgeAnzeigenPunkte(spiel);
            return anzeige;
        }
    }

    #region Allegemein
    public void EintragLöschen(string spiel)
    {
        // Variable mit dem Dateipfad
        string datei = @"test\" + spiel + ".txt";

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

    public void EintragErstellen(string spiel, string spieler, string punkte)
    {
        // Variable mit dem Dateipfad
        string datei = @"test\" + spiel + ".txt";

        // der StreamWriter fügt den Benutzernamen und den Score unten an die Textdatei an
        using (StreamWriter sw = new StreamWriter(datei, true))
        {
            sw.WriteLine(spieler + " " + punkte);
        }
    }

    #endregion

    #region Puntke

    public string EinträgeAnzeigenPunkte(string spiel)
    {
        //Variablen
        int pos = 1;
        string datei = @"test\" + spiel + ".txt";
   
        // Alle Zeilen der Textdatei werden gelesen und im Array gespeichert
        string[] zeilen = File.ReadAllLines(datei);
        // Erstellen des StringBuilders zum Anzeigen der Einträge
        StringBuilder sb = new StringBuilder();
        // Fügt eine neue Zeile mit "Name  Score" und einen Zeilenumbruch ein
        sb.Append("Spieler    Score");
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

    public void EinträgeSortierenPunkte(string spiel)
    {
        // Variablen
        int x = 0;
        string datei = @"test\" + spiel + ".txt";
        // Es wird ein Array erstellt, das Objekte von ScoreItem hält
        ScoreItemPunkte[] SpielScores = new ScoreItemPunkte[11];
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
            SpielScores[x] = new ScoreItemPunkte(nameGelesen, punkteGelesen);
            x++;
        }

        // das Array wird nach dem Score absteigend sortiert
        Array.Sort(SpielScores, delegate (ScoreItemPunkte item1, ScoreItemPunkte item2)
        {
            return item2.Score.CompareTo(item1.Score);
        });

        // für jedes ScoreItem werden Name und Score ausgelesen und als String zusammengefügt
        foreach (ScoreItemPunkte item in SpielScores)
        {
            text = text + item.Benutzer + " " + item.Score + Environment.NewLine;
        }
        // der zusammgefügte String mit den Namen und Scores werden in Textdatei geschrieben
        File.WriteAllText(datei, text);
    }

    #endregion

    #region Zeit
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
        sb.Append("Spieler       Zeit");
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

    public void EinträgeSortierenZeit(string spiel)
    {
        // Variablen
        int x = 0;
        string datei = @"C:\Users\Mama\Desktop\Studium\Softwareprojekt\Axolotl Collection\Test-Highscore\" + spiel + ".txt";
        // Es wird ein Array erstellt, das Objekte von ScoreItem hält
        ScoreItemZeit[] SpielScores = new ScoreItemZeit[11];
        // Alle Zeilen der Textdatei werden in ein Array geschrieben
        String[] Zeilen = File.ReadAllLines(datei);

        // Für jede einzelne Zeile
        foreach (string zeile in Zeilen)
        {
            // werden die Wörter, die duch eine Leerstelle getrennt sind, ausgelesen
            string[] wort = zeile.Split(' ');
            // aus dem Namen und dem Score des Spielers werden die Objekte ScoreItem erstellt und im Array gespeichert
            SpielScores[x] = new ScoreItemZeit(wort[0], wort[1]);
            x++;
        }

        // das Array wird nach dem Score absteigend sortiert
        Array.Sort(SpielScores, delegate (ScoreItemZeit item1, ScoreItemZeit item2)
        {
            return item1.Score.CompareTo(item2.Score);
        });

        // für jedes ScoreItem werden Name und Score ausgelesen und als String zusammengefügt
        foreach (ScoreItemZeit item in SpielScores)
        {
            text = text + item.Benutzer + " " + item.Score + Environment.NewLine;
        }
        // der zusammgefügte String mit den Namen und Scores werden in Textdatei geschrieben
        File.WriteAllText(datei, text);
    }

    #endregion
}


// Klasse ScoreItemPunkte zum Einfügen in das Array wenn Punkte als Highscore
public class ScoreItemPunkte
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
    public ScoreItemPunkte(string name, int wert)
    {
        Benutzer = name;
        Score = wert;
    }

}

// Klasse ScoreItemZeit zum Einfügen in das Array wenn Zeit als Highscore
public class ScoreItemZeit
{
    // Variablen
    string benutzer;
    string score;

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
    public string Score
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
    public ScoreItemZeit(string name, string wert)
    {
        Benutzer = name;
        Score = wert;
    }

}
