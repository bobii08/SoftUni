namespace Blobs.Core
{
    using System.Collections.Generic;
    using Interfaces;

    public class GameData : IGameData
    {
        private readonly ICollection<IBlob> blobs = new List<IBlob>();

        public IEnumerable<IBlob> Blobs
        {
            get { return this.blobs; }
        }

        public void AddBlob(IBlob blob)
        {
            this.blobs.Add(blob);
        }
    }
}
