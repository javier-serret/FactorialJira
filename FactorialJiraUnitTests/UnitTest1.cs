using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialJira;

namespace FactorialJira
{
    [TestClass]
    public class FactorialUnitTests
    {

        [TestMethod]
        public void Factorial_0()
        {
            Assert.AreEqual(1, Class1.Factorial(0));
        }

        [TestMethod]
        public void Factorial_1()
        {
            Assert.AreEqual(1, Class1.Factorial(1));
        }

        [TestMethod]
        public void Factorial_6()
        {
            Assert.AreEqual(720, Class1.Factorial(6));
        }

        [TestMethod]
        public void Factorial_11()
        {
            Assert.AreEqual(39916800, Class1.Factorial(11));
        }

        [TestMethod]
        public void Factorial_12()
        {
            Assert.AreEqual(479001600, Class1.Factorial(12));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Factorial_negative_1()
        {
            Class1.Factorial(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Factorial_13()
        {
            Class1.Factorial(13);
        }
    }
}

