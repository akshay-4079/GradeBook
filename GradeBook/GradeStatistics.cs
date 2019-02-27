using System;
namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            MaxGrade = 0;
            MinGrade = float.MaxValue;
        }
        public float AverageGrade;
        public float MaxGrade;
        public float MinGrade;
        public string LetterGrade
        {
            get
            {
               
                string result;
               
               if (AverageGrade >= 90)
                {
                    result = "A";
                }
                 else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
               else if (AverageGrade >= 60)
                {
                    result = "D"; 

                 }
                else
                {
                    result = "F";
                    }
                return result;
            }
        
        }
      
    }

}

