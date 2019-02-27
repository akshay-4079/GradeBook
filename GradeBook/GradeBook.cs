using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook:GradeTracker
    {
        public GradeBook()
        {

            _name = "Akshay";
           
            grades = new List<float>();


        }


        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.MaxGrade = Math.Max(grade, stats.MaxGrade);
                stats.MinGrade = Math.Min(grade, stats.MinGrade);
                sum += grade;

            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }
        public override void WriteGrades(TextWriter destination)
        {
            destination.WriteLine($"{ Name}");
            if (Program.key == "")
            {
                destination.WriteLine("Without Updgradation");

            }
            else
            {
                destination.WriteLine("With Upgradation");
            }
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine($"Subject {i + 1}:{grades[i]}");

            }
            GradeStatistics stats = ComputeStatistics();
            destination.WriteLine($"Average : {stats.AverageGrade}");
            destination.WriteLine($"Highest : {stats.MaxGrade}");
            destination.WriteLine($"Lowest : {stats.MinGrade}");
        }



        public override void  AddGrade(float grade)
        {
            grades.Add(grade);
        }

       protected List<float> grades;
      
       
    }
}
