using System;
using System.Windows.Forms;
using Rpg_Game_Team_Doldur.Engines.Screens;

namespace Rpg_Game_Team_Doldur
{
    static class Program
    {
        public static StartScreen InitialScreen { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitialScreen = new StartScreen();
            InitialScreen.Show();
            Application.Run();
        }
    }
}
