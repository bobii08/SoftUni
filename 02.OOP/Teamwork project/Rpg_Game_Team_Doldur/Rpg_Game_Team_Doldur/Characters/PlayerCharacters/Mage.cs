namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    using System.Drawing;
    using Weapons;

    public class Mage : Player
    {
         private const int InitialDamage = 20;
         private const int InitialHealth = 150;
         private const int InitialEnergyPoints = 350;
         private const int HealingPoints = 70;
         private static readonly Image Img = Properties.Resources.Mage;
       
        public Mage(Position position, string name)
             : base(position, InitialHealth, InitialDamage, name, InitialEnergyPoints, Img, new Wand(), HealingPoints)
        {
           
        }
    }
}
