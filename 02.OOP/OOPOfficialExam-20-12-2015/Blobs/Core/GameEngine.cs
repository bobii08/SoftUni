namespace Blobs.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class GameEngine : IGameEngine
    {
        private readonly IInputReader inputReader;
        private readonly IOutputWriter outputWriter;
        private readonly IBlobFactory blobFactory;
        private readonly IGameData gameData;

        private bool reportEvents = false;

        public GameEngine(IInputReader inputReader, IOutputWriter outputWriter, IBlobFactory blobFactory, IGameData gameData)
        {
            this.inputReader = inputReader;
            this.outputWriter = outputWriter;
            this.blobFactory = blobFactory;
            this.gameData = gameData;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.inputReader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBlobs();
            }
        }

        private void ExecuteCommand(string[] input)
        {
            string commandName = input[0];
            switch (commandName)
            {
                case "report-events":
                    this.reportEvents = true;
                    break;
                case "create":
                    this.ExecuteCreateBlobCommand(input);
                    break;
                case "attack":
                    this.ExecuteAttackBlobCommand(input);
                    break;
                case "pass":
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                default:
                    throw new InvalidOperationException("There is no such command.");
            }
        }

        private void UpdateBlobs()
        {
            foreach (IBlob blob in this.gameData.Blobs)
            {
                blob.Update();
            }
        }

        private void ExecuteStatusCommand()
        {
            foreach (IBlob blob in this.gameData.Blobs)
            {
                this.outputWriter.WriteLine(blob.ToString());
            }
        }

        private void ExecuteAttackBlobCommand(string[] input)
        {
            var attackerName = input[1];
            var targetName = input[2];

            var attacker = this.gameData.Blobs.FirstOrDefault(b => b.Name == attackerName);
            if (attacker == null)
            {
                throw new ArgumentNullException("attacker", "There is no such blob in the database");
            }

            var target = this.gameData.Blobs.FirstOrDefault(b => b.Name == targetName);
            if (target == null)
            {
                throw new ArgumentNullException("target", "There is no such blob in the database");
            }

            if (!attacker.IsDead && !target.IsDead)
            {
                attacker.Attack(target);
            }
        }

        private void ExecuteCreateBlobCommand(string[] input)
        {
            var unitName = input[1];
            int unitHealth = int.Parse(input[2]);
            int unitDamage = int.Parse(input[3]);
            var behaviorTypeString = input[4] + "Behavior";
            var attackTypeString = input[5] + "Attack";

            var behaviorType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == behaviorTypeString);
            if (behaviorType == null)
            {
                throw new ArgumentException("Unknown behavior type.");
            }

            var behavior = (IBehavior)Activator.CreateInstance(behaviorType);

            var attackType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == attackTypeString);
            if (attackType == null)
            {
                throw new ArgumentException("Unknown attack type.");
            }

            var attack = (IAttack)Activator.CreateInstance(attackType);

            var blob = this.blobFactory.CreateBlob(unitName, unitHealth, unitDamage, behavior, attack);
            
            this.gameData.AddBlob(blob);

            if (this.reportEvents == true)
            {
                blob.OnToggledBehavior += this.ToggleResource;
                blob.OnBlobKilled += this.BlobKilled;   
            }
        }

        private void ToggleResource(object sender, EventArgs e)
        {
            var blob = sender as IBlob;
            var message = string.Format("Blob {0} toggled {1}", blob.Name, blob.Behavior.GetType().Name);
            this.outputWriter.WriteLine(message);
        }

        private void BlobKilled(object sender, EventArgs e)
        {
            var blob = sender as IBlob;
            var message = string.Format("Blob {0} was killed", blob.Name);
            this.outputWriter.WriteLine(message);
        }
    }
}
