using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.Characters;
using _03.GameEngine_TheSlum.Interfaces;
using _03.GameEngine_TheSlum.Items;

namespace _03.GameEngine_TheSlum.GameEngine
{
    public class ExtendedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            string commandName = inputParams[0];
            switch (commandName)
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        public new void AddItem(string[] inputParams)
        {
            string characterId = inputParams[1];
            string item = inputParams[2];
            string itemId = inputParams[3];
            var character = this.GetCharacterById(characterId);

            switch (item)
            {
                case "axe":
                    character.AddToInventory(new Axe(itemId));
                    break;
                case "pill":
                    character.AddToInventory(new Pill(itemId));
                    break;
                case "injection":
                    character.AddToInventory(new Injection(itemId));
                    break;
                case "shield":
                    character.AddToInventory(new Shield(itemId));
                    break;
                default: base.AddItem(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterType = inputParams[1];
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            string team = inputParams[5];
            switch (characterType)
            {
                case "mage":
                    var mage = new Mage(id, x, y, (Team)Enum.Parse(typeof(Team), team));
                    this.characterList.Add(mage);
                    break;
                case "warrior":
                    var warrior = new Warrior(id, x, y, (Team)Enum.Parse(typeof(Team), team));
                    this.characterList.Add(warrior);
                    break;
                case "healer":
                    var healer = new Healer(id, x, y, (Team)Enum.Parse(typeof(Team), team));
                    this.characterList.Add(healer);
                    break;
                default:
                    base.CreateCharacter(inputParams);
                    break;
            }
        }
    }
}
