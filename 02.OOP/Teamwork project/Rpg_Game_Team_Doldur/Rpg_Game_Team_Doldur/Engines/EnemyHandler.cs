namespace Rpg_Game_Team_Doldur.Engines
{
    using System.Collections.Generic;
    using System.IO;
    using Characters.Enemies;

    public class EnemyHandler
    {
        private IList<Enemy> enemyList;
        public EnemyHandler()
        {
            this.enemyList = new List<Enemy>();
        }

        public IEnumerable<Enemy> EnemyList
        {
            get { return this.enemyList; }
        }

        public void LoadEnemies(string map)
        {
            var enemyFactory = new EnemyFactory();
            this.enemyList = new List<Enemy>();
            StreamReader reader = new StreamReader(@"..\..\Resources\Maps\ShadowMountains\EnemiesLocation\" + map + ".txt");
            string[] enemySprites = new string[3];
            enemySprites[0] = "None";
            enemySprites[1] = "Bandit";
            enemySprites[2] = "Gargoyle";

            int y = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                
                for (int x = 0; x < line.Length; x++)
                {
                    int lineX = line[x] - '0';
                    Enemy enemy = enemyFactory.CreateEnemy(enemySprites[lineX], new Position(x*40,y*40));
                    if(enemy != null)
                    { 
                        this.enemyList.Add(enemy);
                    }
                }

                y++;
            }

            reader.Close();
        }
     }
 }

