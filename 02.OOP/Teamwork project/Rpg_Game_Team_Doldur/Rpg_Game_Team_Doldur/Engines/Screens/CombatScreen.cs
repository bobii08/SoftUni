namespace Rpg_Game_Team_Doldur.Engines.Screens
{
    using System.Drawing;
    using Interfaces;
    using System.Windows.Forms;

    public partial class CombatScreen : Form
    {
        public CombatScreen(IPlayer player, ICharacter enemy, Form playField)
        {
            InitializeComponent();
            this.Player = player;
            this.Enemy = enemy;
            this.PlayeField = playField;
            this.DrawCharacters();
        }

        private void DrawCharacters()
        {
            PictureBox playerPictureBox = new PictureBox();
            playerPictureBox.Location = new Point(45, 230);
            playerPictureBox.Image = this.Player.Image;
            this.Controls.Add(playerPictureBox);

            PictureBox enemyPictureBox = new PictureBox();
            enemyPictureBox.Location = new Point(350, 230);
            enemyPictureBox.Image = this.Enemy.Image;
            this.Controls.Add(enemyPictureBox);
        }

        public IPlayer Player { get; private set; }

        public ICharacter Enemy { get; private set; }
        
        public Form PlayeField { get; set; }
        
        private void attackButton_Click(object sender, System.EventArgs e)
        {
            this.Player.Attack(this.Enemy);
            this.IsEnemyAliveCheck();
            this.Enemy.Attack(this.Player);
            this.IsPlayerAliveCheck();
            this.ShowStats();
        }

        private void defendButton_Click(object sender, System.EventArgs e)
        {
            this.Player.Heal();
            this.IsEnemyAliveCheck();
            this.Enemy.Attack(this.Player);
            this.IsPlayerAliveCheck();
            this.ShowStats();
        }

        private void ShowStats()
        {
            this.playerAttackPoints.Text = this.Player.Damage.ToString();
            this.playerHealthPoints.Text = this.Player.Health.ToString();
            this.enemyAttackPoints.Text = this.Enemy.Damage.ToString();
            this.enemyHealthPoints.Text = this.Enemy.Health.ToString();
        }

        private void IsEnemyAliveCheck()
        {
            if (!this.Enemy.IsAlive)
            {
                this.Hide();
                MessageBox.Show("You killed the enemy");
                this.PlayeField.Show();
            }
        }

        private void IsPlayerAliveCheck()
        {
            if (!this.Player.IsAlive)
            {
                MessageBox.Show("You've been killed. You lost!");
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
