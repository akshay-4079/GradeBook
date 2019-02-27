using System;
using Xunit;

namespace Grades.Tests.Types
{
    public class TypeTest
    {
        [Fact]
        public void VariablesHoldaReference()
        {
          GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();
            g1.Name="Akshays Book";
            Assert.Equal(g1.Name, g2.Name);
        }


        [Fact]
        public void ReferenceTypesPassByValue()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            GiveBookAName(g2);
            Assert.Equal("A GradeBook", g1.Name);
        }
        private void GiveBookAName(GradeBook book)
        {
            book.Name="A GradeBook";
        }

        [Fact]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.NotEqual(x1, x2);

        }
        [Fact]
        public void StringComparisons()
        {
            string name1 = "Axe";
            string name2 = "axe";
            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.Equal(result, true);

        }



    }

}
