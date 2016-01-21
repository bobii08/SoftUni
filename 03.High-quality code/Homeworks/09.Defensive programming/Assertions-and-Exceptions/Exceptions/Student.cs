using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("firstName", "First name cannot be null or whitespace.");
            }

            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("lastName", "Last name cannot be null or whitespace.");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams { get; set; }

    public IList<ExamResult> GetExamResults()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("exams", "Exams cannot be null or empty.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("The student must have passed at least 1 exam", "exams");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].GetExamResult());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("exams", "Exams cannot be null or empty.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("The student must have passed at least 1 exam", "exams");
        }

        double[] examScores = new double[this.Exams.Count];
        IList<ExamResult> examResults = GetExamResults();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScores[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScores.Average();
    }
}
