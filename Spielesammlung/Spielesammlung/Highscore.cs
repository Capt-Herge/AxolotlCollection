using System;

public class Highscore
{
    //Leerer Konstruktor
    public Highscore()
    {

	}

    //Liest ein Dokument das den Highscore enthaelt ein und gibt ihn als Stringarray mit einer Zeile pro Arrayplatz zurueck
    public string[] Lesen(string spiel)
    {
        //Varablen
        string[] liste;
        string aktuelleZeile;

        //Liest das Dokument ein
        System.IO.StreamReader datei = new System.IO.StreamReader(@"%APPDATA%\AxolotlCollection\" + spiel +".txt");

        //Fuellt das Array mit den Zeilen
        for(int i = 0; (aktuelleZeile = datei.ReadLine()) != null; i++)
        {
            //Schreibt die akutelle Zeile ins Array
            liste[i] = aktuelleZeile;
        }

        //Beendet das lesen der Datei und gibt die liste zurueck
        datei.Close();
        return (liste);
    }

    //Traegt einen Highscore, wenn ausreichend in die Liste ein
    public void Schreiben(string spiel, string spielername, int highscore)
    {
        //Varablen
        string[] zeilewort;
        string[] zeilezahl;
        string[] zahl;
        string[] wort;
        string aktuellesZeichen;

        //Liest das Dokument ein
        System.IO.StreamReader datei = new System.IO.StreamReader(@"%APPDATA%\AxolotlCollection\" + spiel + ".txt");

        //Geht das Dokument Zeilenweise druch
        for (int i = 0; (aktuelleZeile = datei.ReadLine()) != null; i++)
        {
            //Score
            for (int j = 0; (aktuellesZeichen = datei.Read()) != " "; j++)
            {
                zahl[j] = aktuellesZeichen;
            }

            for (int k = 1; k <= 5; k++)
            {
                zeilezahl[i] = zeilezahl[k - 1] + zeilezahl[k];
            }

            //Spieler Name
            for (int j = 0; (aktuellesZeichen = datei.Read()) != " "; j++)
            {
                wort[j] = aktuellesZeichen;
            }

            for (int k = 1; k <= 5; k++)
            {
                zeilewort[i] = zeilewort[k-1]+ zeilewort[k];
            }
        }

        //Beendet das lesen der Datei und gibt die liste zurueck
        datei.Close();

        
    }
}
