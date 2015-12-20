namespace Blobs.Models.BehaviorTypes
{
    using Interfaces;

    public class AggressiveBehavior : IAggressiveBehavior
    {
        private const int DamageReduction = 5;

        public void TriggerBehavior(IUnit unit)
        {
            this.IsActivated = true;
            unit.Damage *= 2;
        }

        public bool IsActivated { get; private set; }

        public void ApplyBehaviorEffect(IUnit unit)
        {
            if (unit.Damage - DamageReduction < unit.InitialDamage)
            {
                return;
            }

            unit.Damage -= DamageReduction;
        }
    }
}
