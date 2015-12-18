using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Core.Interfaces
{
    public interface IDatabase
    {
        IEnumerable<IBuilding> Buildings { get; }
        IDictionary<string, int> Resources { get; }
        IDictionary<string, int> Units { get; }
        void AddBuilding(IBuilding building);
        void AddResource(string resourceType, int quantity);
        void AddUnit(string unitType);
    }
}
