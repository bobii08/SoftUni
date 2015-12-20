namespace Blobs.Models.Characters
{
    using Common;
    using Interfaces;

    public abstract class Unit : IUnit
    {
        private string name;
        protected int health;
        private int damage;
        private int initialHealth;
        private int initialDamage;

        protected Unit(string name, int health, int damage)
        {
            this.Name = name;
            this.Health = health; // TODO: might be a problem
            this.Damage = damage;
            this.InitialHealth = health;
            this.InitialDamage = damage;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringIsNullOrWhitespace(value, "name");
                this.name = value;
            }
        }

        public abstract int Health { get; set; }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                Validator.CheckIfIntNumberIsNegative(value, "damage");
                if (value < this.InitialDamage)
                {
                    this.damage = this.InitialDamage;
                }
                else
                {
                    this.damage = value;
                }
            }
        }

        public abstract void Attack(IUnit unit);

        public int InitialHealth
        {
            get { return this.initialHealth; }
            private set
            {
                Validator.CheckIfIntNumberIsNonPositive(value, "initialHealth");
                this.initialHealth = value;
            }
        }

        public int InitialDamage
        {
            get { return this.initialDamage; }
            private set
            {
                Validator.CheckIfIntNumberIsNegative(value, "initialDamage");
                this.initialDamage = value;
            }
        }

        public bool IsDead { get; protected set; }

        public override string ToString()
        {
            if (this.IsDead)
            {
                return string.Format("{0} {1} KILLED", this.GetType().Name, this.Name);
            }
            return string.Format("{0} {1}: {2} HP, {3} Damage", this.GetType().Name, this.Name, this.Health, this.Damage);
        }
    }
}
