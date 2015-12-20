namespace Blobs.Core.Factories
{
    using Interfaces;
    using Models.Characters;

    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(string name, int health, int damage, IBehavior behaviorType, IAttack attackType)
        {
            var blob = new Blob(name, health, damage, behaviorType, attackType);

            return blob;
        }
    }
}
