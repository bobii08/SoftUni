using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core.Interfaces;
using Empires.Models;
using Empires.Models.Interfaces;

namespace Empires.Core
{
    public class CommandExecuter : IExecute
    {
        private IDatabase database;

        public CommandExecuter(IDatabase database)
        {
            this.database = database;
        }

        public string ExecuteCommand(string[] commandArgs)
        {
            string commandResult = string.Empty;
            switch (commandArgs[0])
            {
                case "build":
                    this.ExecuteBuildCommand(commandArgs);
                    break;
                case "skip":
                    this.ExecuteSkipCommand();
                    break;
                case "empire-status":
                    commandResult = this.ExecuteEmpireStatusCommand();
                    break;
                default:
                    throw new InvalidOperationException("There is no such command");
            }

            this.CheckCreateResourceOrUnit();

            return commandResult;
        }

        private string ExecuteEmpireStatusCommand()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Treasury:");
            if (!this.database.Resources.Any())
            {
                result.AppendLine("--Gold: " + 0);
                result.AppendLine("--Steel: " + 0);
            }
            else
            {
                result.AppendLine("--Gold: " + (this.database.Resources.ContainsKey("Gold") ? this.database.Resources["Gold"].ToString() : "0"));
                result.AppendLine("--Steel: " + (this.database.Resources.ContainsKey("Steel") ? this.database.Resources["Steel"].ToString() : "0"));
            }

            result.AppendLine("Buildings:");
            if (!this.database.Buildings.Any())
            {
                result.AppendLine("N/A");
            }
            else
            {
                foreach (var b in this.database.Buildings)
                {
                    result.AppendLine(b.ToString());
                }
            }

            result.AppendLine("Units:");
            if (!this.database.Units.Any())
            {
                result.AppendLine("N/A");
            }
            else
            {
                foreach (var unitCountInfo in this.database.Units)
                {
                    var element = unitCountInfo;
                    result.AppendLine("--" + element.Key + ": " + element.Value);
                }
            }

            this.ExecuteTurnsPassed(null);
            return result.ToString();
        }

        private void ExecuteSkipCommand()
        {
            this.ExecuteTurnsPassed(null);
        }

        private void ExecuteBuildCommand(string[] commandArgs)
        {
            switch (commandArgs[1])
            {
                case "barracks":
                    var barracks = new Barracks(); // factory should do this
                    this.database.AddBuilding(barracks);
                    this.ExecuteTurnsPassed(barracks);
                    break;
                case "archery":
                    var archery = new Archery();
                    this.database.AddBuilding(archery);
                    this.ExecuteTurnsPassed(archery);
                    break;
                default:
                    throw new InvalidOperationException("There is no such building.");
            }
        }

        private void ExecuteTurnsPassed(IBuilding building)
        {
            foreach (var b in this.database.Buildings)
            {
                if (b != building)
                {
                    b.BuildingTurnsPassed++;
                }
            }
        }

        private void CheckCreateResourceOrUnit()
        {
            foreach (var b in this.database.Buildings)
            {
                if (b.BuildingTurnsPassed % b.TurnsForResourceCreation == 0 && b.BuildingTurnsPassed != 0)
                {
                    var resource = b.ProduceResource();
                    this.database.AddResource(resource.Type.ToString(), resource.Quantity);
                }

                if (b.BuildingTurnsPassed % b.TurnsForUnitCreation == 0 && b.BuildingTurnsPassed != 0)
                {
                    var unit = b.ProduceUnit();
                    this.database.AddUnit(unit.GetType().Name);
                }
            }
        }
    }
}
