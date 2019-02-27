using System;
using System.IO;

namespace Grades
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExsistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                        _name = value;

                    }


                }


                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Name Cant Be Null");
                }



            }
        }
        public event NameChangedDelegate NameChanged;
        protected string _name;
        private string _name1;
        public string tempname
        {
            get
            {
                return _name1;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name1 = value;
                }
                else
                {

                    throw new ArgumentException("Name Cant Be Null");
                }
            }
        }
        public float tempgrade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (float.IsNaN(value))
                {
                    throw new FormatException("Enter valid grade");
                }
                if (!float.IsNaN(value))
                {
                    _grade = value;
                }

            }
        }
        public float Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (!float.IsNaN(value))
                {
                    _grade = value;
                    AddGrade(_grade);
                }
                if (float.IsNaN(value))
                {
                    throw new FormatException("Enter valid grade");
                }

            }

        }
        public string endkey;
        private float _grade;

    }


}