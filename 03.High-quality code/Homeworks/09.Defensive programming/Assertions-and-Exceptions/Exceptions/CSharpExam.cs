using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;

    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get { return this.score; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("score", "Score cannot be negative");
            }

            this.score = value;
        }
    }

    public override ExamResult GetExamResult()
    {
        if (this.Score < MinGrade || this.Score > MaxGrade)
        {
            throw new ArgumentOutOfRangeException("score", "Score must be between 0 and 100");
        }

        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
