using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
    public class Resource : IResource
    {
        private int quantity;

        public Resource(ResourceType type, int quantity)
        {
            this.Quantity = quantity;
            this.Type = type;
        }

        public ResourceType Type { get; private set; } // TODO: add validation

        public int Quantity
        {
            get { return this.quantity; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("quantity", "Quantity of resources should be non-negative.");
                }
                this.quantity = value;
            }
        }
    }
}
