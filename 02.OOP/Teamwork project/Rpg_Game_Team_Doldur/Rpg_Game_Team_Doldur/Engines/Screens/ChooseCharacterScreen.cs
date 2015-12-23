namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Characters.PlayerCharacters;
    using Worlds;

    public partial class ChooseCharacterScreen : Form
    {
        public ChooseCharacterScreen()
        {
            InitializeComponent();
        }
        
        private void chooseCharacterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameInput.Text))
            {
                Label erroLabel = new Label();
                erroLabel.Text = "You must enter character name before you press \"Choose character\" button";
                erroLabel.Enabled = true;
                erroLabel.Visible = true;
                var labelLocation = new Point(200,450);
                erroLabel.Font = new Font(FontFamily.GenericSerif, 10);
                erroLabel.Location = labelLocation;
                erroLabel.AutoSize = true;
                this.Controls.Add(erroLabel);
            }
            else
            {
                if (this.warriorRadioButton.Checked)
                {
                    Player player = new Warrior(new Position(0, 0), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                }

                else if (this.archerRadioButton.Checked)
                {
                    Player player = new Archer(new Position(0, 0), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                }

                else if (this.mageRadioButton.Checked)
                {
                    Player player = new Mage(new Position(0, 0), nameInput.Text);
                    CreatePlayerAndStartGame(player);
                }
            }
        }

        private void CreatePlayerAndStartGame(Player player)
        {
            var firstLevel = new ShadowMountains(player);
            firstLevel.StartPosition = FormStartPosition.Manual;
            firstLevel.Location = this.Location;
            firstLevel.Show();
            firstLevel.Activate();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToStartScreenButton_Click(object sender, EventArgs e)
        {
            Program.InitialScreen.Show();
            this.Hide();
        }
    }
}
