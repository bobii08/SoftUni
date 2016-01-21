using System;
using System.Reflection.Emit;

public class SimpleMathExam : Exam
{
    private const int NumberOfTotalProblems = 10;
    private const int MinGrade = 2;
    private const int MaxGrade = 6;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get { return this.problemsSolved; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("problemsSolved", "Solved problems cannot be less than 0");
            }

            if (value > NumberOfTotalProblems)
            {
                throw new ArgumentOutOfRangeException("problemsSolved", 
                    string.Format("Solved problems cannot be more than {0}", NumberOfTotalProblems));
            }

            this.problemsSolved = value;
        }
    }

    public override ExamResult GetExamResult()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, MinGrade, MaxGrade, "Bad result: nothing done.");
        }
        else if (1 <= this.ProblemsSolved || this.ProblemsSolved <= 5)
        {
            return new ExamResult(4, MinGrade, MaxGrade, "Average result.");
        }
        else if (5 <= this.ProblemsSolved && this.ProblemsSolved <= 8)
        {
            return new ExamResult(5, MinGrade, MaxGrade, "Very good result.");
        }

        return new ExamResult(6, MinGrade, MaxGrade, "Excellent result");
    }
}
