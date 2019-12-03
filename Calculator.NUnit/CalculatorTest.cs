﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.NUnit
{
    class CalculatorTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        [Test]
        public void GivenTwoValues_WhenPerformingAddOperation_ThenShouldReturnTheSum()
        {
            //Arrenge
            double expected = 2;
            double x = 1;
            double y = 1;

            //Act
            var result = Calculator.Add(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenTwoValues_WhenPerformingSubstractOperation_ThenShouldReturnTheDifference()
        {
            //Arrenge
            double expected = 0;
            double x = 1;
            double y = 1;

            //Act
            var result = Calculator.Substract(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenTwoValues_WhenPerformingMultiplyOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expected = 3;
            double x = 1;
            double y = 3;

            //Act
            var result = Calculator.Multipliy(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GivenTwoValues_WhenPerformingDivisionOperation_ThenShouldReturnTheNewValue()
        {
            //Arrenge
            double expected = 2;
            double x = 4;
            double y = 2;

            //Act
            var result = Calculator.Divide(x, y);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
