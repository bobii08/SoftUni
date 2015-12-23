namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    using System;
    using System.Windows.Forms;

    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            this.ChooseCharacterScreen = new ChooseCharacterScreen();
        }
        
        public ChooseCharacterScreen ChooseCharacterScreen { get; set; }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            this.ChooseCharacterScreen.Show();
            this.Hide();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
