using Blobs.Core;
using Blobs.Core.Factories;
using Blobs.Interfaces;
using Blobs.IO;

namespace Blobs
{
    public class BlobsProgram
    {
        public static void Main()
        {
            IInputReader inputReader = new ConsoleReader();
            IOutputWriter outputWriter = new ConsoleWriter();
            IBlobFactory blobFactory = new BlobFactory();
            IGameData gameData = new GameData();

            IGameEngine gameEngine = new GameEngine(inputReader, outputWriter, blobFactory, gameData);
            gameEngine.Run();
        }
    }
}
