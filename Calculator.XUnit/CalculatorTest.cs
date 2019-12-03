using System;
using Xunit;

namespace Calculator.XUnit
{
    public class CalculatorTest
    {
        //[Fact]
        [Theory]
        [InlineData(2,3,5)]
        [InlineData(20, 11, 31)]
        [InlineData(1.5, 7.4, 8.9)]
        public void GivenTwoValues_WhenPerformingAddOperation_ThenShouldReturnTheSum(double x, double y, double expected)
        {
            //Arrenge
            //double expected = 2;
            //double x = 1;
            //double y = 1;

            //Act
            var result = Calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenTwoValues_WhenPerformingSubstractOperation_ThenShouldReturnTheDifference()
        {
            //Arrenge
            double expected = 0;
            double x = 1;
            double y = 1;

            //Act
            var result = Calculator.Substract(x, y);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenTwoValues_WhenPerformingMultiplyOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expected = 3;
            double x = 1;
            double y = 3;

            //Act
            var result = Calculator.Multipliy(x, y);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GivenTwoValues_WhenPerformingDivisionOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expected = 2;
            double x = 4;
            double y = 2;

            //Act
            var result = Calculator.Divide(x, y);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
