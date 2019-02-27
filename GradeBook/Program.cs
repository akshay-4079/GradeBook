using System;
using System.IO;

namespace Grades
{
    class Program
    {
        public static string key;

        static void Main(string[] args)
        {
            GradeTracker book = CreateGradeBook();
            book.NameChanged += OnNameChanged;
            GetBookName(book);
            book.Name = book.tempname;
            AddGrades(book);
            WriteResults(book);
            DisplayResults(book);

        }

        private static GradeTracker CreateGradeBook()
        {
            Console.WriteLine("Press any Key to invoke Throwaway Grade, Press Enter for Normal");
            key = Console.ReadLine();
            if (key == null)
            {
                return new GradeBook();
            }
            else
            {
                return new ThrowAwayGrade();
            }
        }

        private static void DisplayResults(GradeTracker book)
        {
            Console.WriteLine(book.Name);
            GradeStatistics stats = book.ComputeStatistics();

            WriteResults("Average", stats.AverageGrade);
            WriteResults("Maximum", stats.MaxGrade);
            WriteResults("Minimum", stats.MinGrade);
            WriteResults("Grade", stats.LetterGrade);
        }

        private static void WriteResults(GradeTracker book)
        {
            using (StreamWriter outputfile = File.CreateText($"{book.Name}.txt"))
            {
                book.WriteGrades(outputfile);
                outputfile.Close();
            }
        }

        private static void AddGrades(GradeTracker book)
        {
            do
            {

                try
                {

                    Console.WriteLine("Enter  Grades");
                    book.tempgrade = float.Parse(Console.ReadLine());
                    if (book.tempgrade >= 0 && book.tempgrade <= 100 )
                    {
                        book.Grade = book.tempgrade;
                    }

                    else
                    {
                        Console.WriteLine("Enter right grade");
                    }
                    Console.WriteLine("Press any key to end");
                    book.endkey = Console.ReadLine();
                }


            

                catch (FormatException  ex)
                {

                    Console.WriteLine(ex.Message);

                }
            }
            while (book.endkey == "");
        
        }
    

        private static void GetBookName(GradeTracker book)
        {
            do
            {

                try
                {

                    Console.WriteLine("Enter a Name");
                    book.tempname = Console.ReadLine();

                  
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
   
            }
            while (book.tempname == null);
           
        }

        static void WriteResults(string description,float result)
        {
            Console.WriteLine(description+ ":" + result);

        }
        static void WriteResults(string description, string result)
        {
            Console.WriteLine(description + ":" + result);

        }
        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"GradeBook Name Changed from {args.ExsistingName} to { args.NewName}");
        }

    }
}
