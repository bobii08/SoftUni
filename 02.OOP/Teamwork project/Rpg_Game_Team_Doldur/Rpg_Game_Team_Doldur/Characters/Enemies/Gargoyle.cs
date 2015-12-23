namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    using System.Drawing;

    public class Gargoyle : Enemy
    {
        private const int GargoyleDamage = 30;
        private const int GargoyleHealth = 200;
        private static readonly Image Img = Properties.Resources.Gargoyle;

        public Gargoyle(Position position)
            : base(position, GargoyleHealth, GargoyleDamage, Img)
        {
        }
    }
}