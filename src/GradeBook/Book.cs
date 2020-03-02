using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
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

        public void ShowStatistics()
        {
            calculateAverage();
            MaxAndMin();

        }

        public void calculateAverage()
        {
            double result = 0;
            int gradeSize = this.grades.Count;
            foreach (double grade in this.grades)
            {
                result += grade;
            }
            result /= gradeSize;
            Console.WriteLine(result);
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