using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        String name;
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            int gradeSize = this.grades.Count;
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in this.grades)
            {
                result.Average += grade;
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
            }
            result.Average /= gradeSize;
            return result;
        }

        public double calculateAverage()
        {
            double result = 0;
            int gradeSize = this.grades.Count;
            foreach (double grade in this.grades)
            {
                result += grade;
            }
            result /= gradeSize;
            Console.WriteLine(result);
            return result;
        }

        public void MaxAndMin()
        {
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;

            foreach (double grade in this.grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
            }

            System.Console.WriteLine(lowGrade);
            System.Console.WriteLine(highGrade);

        }

    }
}