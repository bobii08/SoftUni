namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    using System.Drawing;
    using Weapons;

    public class Warrior : Player
    {
        private const int InitialDamage = 50;
        private const int InitialHealth = 250;
        private const int InitialEnergyPoints = 100;
        private const int HealingPoints = 50;
        private static readonly Image Img = Properties.Resources.BOV_Warrior;

        public Warrior(Position position, string name)
            : base(position, InitialHealth, InitialDamage, name, InitialEnergyPoints, Img, new Sword(), HealingPoints)
        {

        }
    }
}
