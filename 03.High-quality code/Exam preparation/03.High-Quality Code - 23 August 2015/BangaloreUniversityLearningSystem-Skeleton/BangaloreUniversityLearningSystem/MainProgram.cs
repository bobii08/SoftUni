namespace BangaloreUniversityLearningSystem
{
    using BangaloreUniversityLearningSystem.Core;
    using BangaloreUniversityLearningSystem.Data;

    public class MainProgram
    {
        public static void Main()
        {
            var database = new BangaloreUniversityData();
            var engine = new Engine(database);
            engine.Run();
        }
    }
}