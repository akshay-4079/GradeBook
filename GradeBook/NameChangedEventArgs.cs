using System;
namespace Grades
{
    public class NameChangedEventArgs:EventArgs
    {
        public string ExsistingName { get; set; }
        public string NewName { get; set; }
    }
}
