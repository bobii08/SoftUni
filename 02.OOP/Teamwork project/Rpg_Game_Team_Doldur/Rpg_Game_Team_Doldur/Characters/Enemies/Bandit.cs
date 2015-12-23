namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    using System.Drawing;

    public class Bandit : Enemy
    {
        private const int BanditDamage = 20;
        private const int BanditHealth = 150;
        private static readonly Image Img = Properties.Resources.Bandits;

        public Bandit(Position position)
            : base(position, BanditHealth, BanditDamage, Img)
        {
        }
    }
}