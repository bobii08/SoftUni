namespace Blobs.Models.BehaviorTypes
{
    using Interfaces;

    public class InflatedBehavior : IInflatedBehavior
    {
        private const int HealthReduction = 10;

        public void TriggerBehavior(IUnit unit)
        {
            this.IsActivated = true;
            unit.Health += 50;
        }

        public bool IsActivated { get; private set; }

        public void ApplyBehaviorEffect(IUnit unit)
        {
            unit.Health -= HealthReduction;
        }
    }
}
