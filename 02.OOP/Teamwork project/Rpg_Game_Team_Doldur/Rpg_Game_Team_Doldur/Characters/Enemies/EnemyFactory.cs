namespace Rpg_Game_Team_Doldur.Characters.Enemies
{
    using System;

    public class EnemyFactory
    {
        public Enemy CreateEnemy(string type, Position position)
        {
            switch (type)
            {
                case "Bandit":
                    return new Bandit(position);
                case "Gargoyle":
                    return new Gargoyle(position);
                default:
                    return null; // TODO: need fixing if there is time
                    throw new ArgumentException("There is no such enemy type.");
            }
        }
    }
}
