using System;
using Xunit;


namespace GradeBook.Test
{
    public class BookTest
    {

        [Fact]
        public void CanGEtAverageGrades()
        {
            //Given
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //When
            var result = book.GetStatistics();
            //Then
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);

        }
    }
}
