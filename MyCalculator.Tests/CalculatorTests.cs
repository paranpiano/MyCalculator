using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;

namespace MyCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [TestCategory("SimpleMath")]
        //[Ignore]
        [Priority(0)]
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
        [TestCategory("SimpleMath")]
        [Priority(0)]
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
        [TestCategory("Exception")]
        [ExpectedException(typeof(DivideByZeroException))]
        [Priority(1)]
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
