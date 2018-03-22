using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form_Menue());
            //Application.Run(new Vanguards.Vanguards());
            Application.Run(new Flappy_Bird.Flappy_Bird());
            //Application.Run(new Pong.Form1());
            //Application.Run(new Snake.Form_Snake());
            //Application.Run(new Donkey_Kong.Donkey_Kong().Donkey_Kong_Start());
            //Application.Run(new Minesweeper.Form_Minesweeper());
        }
    }
}
