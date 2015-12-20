namespace Blobs.Models.Characters
{
    using System;
    using Common;
    using Interfaces;
    using EventHandlers;

    public class Blob : Unit, IBlob
    {
        public event ToggledBehaviorEventHandler OnToggledBehavior;
        public event BlobKilledEventHandler OnBlobKilled;


        private bool healthHasBeenInitialized;
        private bool behaviorHasJustBeenActivated = true;

        public Blob(string name, int health, int damage, IBehavior behaviorType, IAttack attackType)
            : base(name, health, damage)
        {
            this.Behavior = behaviorType;
            this.AttackType = attackType;
        }

        // by making this property private I ensure that the Blob's behavior can be set only once - in the constructor, and that the blob can have only one behavior
        public IBehavior Behavior { get; private set; }
        // by making this property private I ensure that the Blob's attack type can be set only once - in the constructor, and that the blob can have only one behavior
        public IAttack AttackType { get; private set; }

        public override int Health // TODO: might be a problem
        {
            get { return this.health; }
            set
            {
                if (!this.healthHasBeenInitialized)
                {
                    Validator.CheckIfIntNumberIsNonPositive(value, "health");
                    this.health = value;
                    this.healthHasBeenInitialized = true;
                }

                if (value <= 0)
                {
                    this.health = 0;
                    if (!this.Behavior.IsActivated)
                    {
                        this.Behavior.TriggerBehavior(this);
                        if (this.OnToggledBehavior != null)
                        {
                            this.OnToggledBehavior(this, new EventArgs());                            
                        }
                    }
                    else
                    {
                        if (this.OnBlobKilled != null)
                        {
                            this.OnBlobKilled(this, new EventArgs());                            
                        }
                        this.IsDead = true;
                    }
                }
                else if (value <= (this.InitialHealth / 2))
                {
                    this.health = value;

                    if (!this.Behavior.IsActivated)
                    {
                        this.Behavior.TriggerBehavior(this);
                        if (this.OnToggledBehavior != null)
                        {
                            this.OnToggledBehavior(this, new EventArgs());
                        }
                    }
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public override void Attack(IUnit target)
        {
            this.AttackType.ApplyAttackEffect(this);
            var attackDamage = this.AttackType.ResultedDamage(this);
            target.Health -= attackDamage;
        }

        public void Update()
        {
            if (this.Behavior.IsActivated)
            {
                if (this.behaviorHasJustBeenActivated)
                {
                    this.behaviorHasJustBeenActivated = false;
                    return;
                }
                this.Behavior.ApplyBehaviorEffect(this);
            }
        }
    }
}
