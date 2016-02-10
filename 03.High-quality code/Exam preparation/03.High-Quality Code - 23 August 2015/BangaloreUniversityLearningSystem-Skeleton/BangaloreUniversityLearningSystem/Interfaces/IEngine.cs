namespace BangaloreUniversityLearningSystem.Interfaces
{
    public interface IEngine
    {
        IBangaloreUniversityData Database { get; }

        IUser CurrentUser { get; }

        void Run();
    }
}