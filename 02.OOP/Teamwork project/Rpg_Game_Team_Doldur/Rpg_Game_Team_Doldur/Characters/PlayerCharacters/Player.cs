namespace Rpg_Game_Team_Doldur.Characters.PlayerCharacters
{
    using System;
    using System.Drawing;
    using Interfaces;

    public abstract class Player : Character, IPlayer
    {
        private string name;
        private int energyPoints;
        private int healingPoints;

        protected Player(Position position, int health, int damage, string name, int energyPoints, Image image, IWeapon weapon, int healingPoints)
            : base(position, health, damage, image)
        {
            this.Name = name;
            this.EnergyPoints = energyPoints;
            this.Weapon = weapon;
            this.healingPoints = healingPoints;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Character name can`t be empty");
                }
                this.name = value;
            }
        }

        public int EnergyPoints
        {
            get { return this.energyPoints; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Energy points can`t be negative");
                }

                this.energyPoints = value;
            }
        }

        public void Move(int x, int y)
        {
            Point currLoc = new Point(this.SpritePictureBox.Location.X, this.SpritePictureBox.Location.Y);
            this.SpritePictureBox.Location = new Point(currLoc.X + x, currLoc.Y + y);
            this.Position = new Position(currLoc.X + x, currLoc.Y + y);
        }

        public void Heal()
        {
            this.Health += this.healingPoints;
        }

        public IWeapon Weapon { get; private set; }

        public override void Attack(ICharacter enemy)
        {
            this.Health = this.Weapon.ResultedHealth(this);
            var resultedDamage = this.Weapon.ResultedDamage(this);
            enemy.Health -= resultedDamage;
        }
    }
}
