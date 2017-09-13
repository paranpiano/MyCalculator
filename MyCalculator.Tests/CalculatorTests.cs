using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddSimple()
        {
            //arrange
            var calculator = new Calculator();
            //act
            int sum = calculator.Add(1, 3);
            //assert
            Assert.AreEqual(sum, 4);
        }

        [TestMethod]
        public void DivideSimple()
        {
            //arrange
            var calculator = new Calculator();
            //act
            int quotent = calculator.Devide(10, 5);
            //assert
            Assert.AreEqual(quotent, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZero()
        {
            //arrange
            var calculator = new Calculator();
            //act
            int quotent = calculator.Devide(10, 0);
            //assert
            //Assert.AreEqual(quotent, 2);
        }
    }
}
