using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    public class Battery
    {
        private string name;
        private int cells;
        private double batteryLife;

        public Battery(string name, int cells, double batteryLife)
        {
            this.Name = name;
            this.Cells = cells;
            this.BatteryLife = batteryLife;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "name of battery cannot be null");
                }
                this.name = value;
            }
        }

        public int Cells
        {
            get { return this.cells; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("cells", "cells cannot be non-positive numbers");
                }
                this.cells = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("battery life cannot be non-positive number");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nCells: {1}\nBattery life: {2} hours", this.Name, this.Cells, this.BatteryLife);
        }
    }
}
