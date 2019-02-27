using System;
using Grades;
using Xunit;

namespace Grades.Tests
{
    
    public class GradeBookTest
    {
        [Fact]
        public void ComputeHighestGrade()
        {
            GradeBook book=new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);
            GradeStatistics result =book.ComputeStatistics();
            Assert.Equal(90, result.MaxGrade);
        }
        [Fact]
        public void ComputeLowetGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);
            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(10, result.MinGrade);
        }
        [Fact]
        public void ComputeAvgGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);
            book.AddGrade(20);
            GradeStatistics result = book.ComputeStatistics();
            Assert.Equal(40, result.AverageGrade);
        }
    }   
}
