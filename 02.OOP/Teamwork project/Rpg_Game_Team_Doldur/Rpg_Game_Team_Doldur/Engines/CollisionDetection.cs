namespace Rpg_Game_Team_Doldur.Engines
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Screens;

    public class CollisionDetection : ICollision
    {
        public CollisionDetection(Form level)
        {
            this.PlayField = level;
        }

        private Form PlayField { get; set; }

        private Form CombatScreen { get; set; }

        public IEnumerable<ICharacter> UnitsInMap { get; private set; }

        public void DetectCollision(IPlayer player, ICharacter enemy)
        {
            this.PlayField.Hide();
            this.CombatScreen = new CombatScreen(player, enemy, this.PlayField);
            this.CombatScreen.StartPosition = FormStartPosition.Manual;
            this.CombatScreen.Location = this.PlayField.Location;
            this.CombatScreen.Show();
        }
    }
}