namespace Blobs.Models.AttackTypes
{
    using Interfaces;

    public class BlobplodeAttack : IBlobplodeAttack
    {
        public void ApplyAttackEffect(IUnit unit)
        {
            if (unit.Health == 1)
            {
                return;
            }

            unit.Health = unit.Health - (unit.Health / 2);
        }

        public int ResultedDamage(IUnit unit)
        {
            return unit.Damage * 2;
        }
    }
}
