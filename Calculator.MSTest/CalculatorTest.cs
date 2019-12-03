using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.MSTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void GivenTwoValues_WhenPerformingAddOperation_ThenShouldReturnTheSum()
        {
            //Arrenge
            double expectet = 2;
            double x = 1;
            double y = 1;

            //Act
            var result = Calculator.Add(x, y);

            //Assert
            Assert.AreEqual(expectet, result);
        }

        [TestMethod]
        public void GivenTwoValues_WhenPerformingSubstractOperation_ThenShouldReturnTheDifference()
        {
            //Arrenge
            double expectet = 0;
            double x = 1;
            double y = 1;

            //Act
            var result = Calculator.Substract(x, y);

            //Assert
            Assert.AreEqual(expectet, result);
        }

        [TestMethod]
        public void GivenTwoValues_WhenPerformingMultiplyOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expectet = 3;
            double x = 1;
            double y = 3;

            //Act
            var result = Calculator.Multipliy(x, y);

            //Assert
            Assert.AreEqual(expectet, result);
        }

        [TestMethod]
        public void GivenTwoValues_WhenPerformingDivisionOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expectet = 2;
            double x = 4;
            double y = 2;

            //Act
            var result = Calculator.Divide(x, y);

            //Assert
            Assert.AreEqual(expectet, result);
        }
    }
}
