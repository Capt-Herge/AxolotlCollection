using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Spielesammlung.Snake
{
    class Steuerung
    {
        // Erstellen einer Hashtabelle für die Tasten
        private static Hashtable tasten = new Hashtable();

        // Tastenbelegung
        private void TasteW(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, 1);
        }
        private void TasteA(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, 2);
        }
        private void TasteS(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, 3);
        }
        private void TasteD(object sender, KeyEventArgs e)
        {
            Steuerung.ChangeState(e.KeyCode, 4);
        }

        // ändert den Zustand, wenn eine Taste gedrückt wurde
        private static void ChangeState(Keys key, int richtung)
        {
            tasten[key] = richtung;
        }

        // Überprüft, ob eine taste gedrückt ist
        public static bool TasteGedrückt(Keys key)
        {
            if (tasten[key] == null)
            {
                return false;
            }
            else
            {
                return (bool)tasten[key];
            }
        }

    }
}
