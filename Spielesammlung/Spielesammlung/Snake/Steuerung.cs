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

        // ändert den Zustand, wenn eine Taste gedrückt wurde
        public static void ChangeState(Keys key, bool state)
        {
            tasten[key] = state;
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
