using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // var p = new Program();
            // Program.Main(args);

            // var numbers = new[] { 12.7, 17.2, 14.3 };
            // numbers[0] = 12.7;
            // numbers[1] = 17.2;
            // numbers[2] = 14.3;
            // var result = numbers[0];
            // result += numbers[1];
            // result += numbers[2];
            // var x = 34.1;
            // double y = 10.3;
            // double result = x + y;
            // // Console.WriteLine(result);
            // cw tab shortcut to get System.Console.WriteLine

            Book book = new Book("Debbie's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(101);
            book.AddGrade(12.7);
            book.AddGrade(17.2);
            book.AddGrade(14.3);
            book.ShowStatistics();


            // List<double> grades = new List<double>() { 12.7, 17.2, 14.3 };
            // grades.Add(55.8);

            // var gradesSize = grades.Count;
            // var highGrade = double.MinValue;
            // var lowGrade = double.MaxValue;
            // var result = 0.0;
            // foreach (double number in grades)
            // {
            //     // if (number > highGrade)
            //     // {
            //     //     highGrade = number;
            //     // }
            //     highGrade = Math.Max(number, highGrade);
            //     lowestGrade = Math.Min(number, lowGrade);
            //     result += number;
            // }
            // result /= gradesSize;

            // // :N1 allows to float to 1 decimal place :N3 to 3 decimal places
            // Console.WriteLine($"The average grade is {result:N1}");
            // System.Console.WriteLine($"Lowest grade is {lowGrade}");
            // System.Console.WriteLine($"Highest grade is {highGrade}");

            if (args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0] + "!");
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
