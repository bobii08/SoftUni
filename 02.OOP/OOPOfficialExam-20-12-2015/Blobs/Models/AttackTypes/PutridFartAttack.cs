namespace Blobs.Models.AttackTypes
{
    using Interfaces;

    public class PutridFartAttack : IPutridFartAttack
    {
        public void ApplyAttackEffect(IUnit unit)
        {
            // Empty method because there is no effect of this attack
        }

        public int ResultedDamage(IUnit unit)
        {
            return unit.Damage;
        }
    }
}
