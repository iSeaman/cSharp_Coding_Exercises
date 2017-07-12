using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_0_Test()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("", fb.fizzBuzz(0));
        }

        [TestMethod]
        public void FizzBuzz_101_Test()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("", fb.fizzBuzz(101));
        }

        [TestMethod]
        public void FizzBuzz_Obvious_Cases_Test()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("Fizz", fb.fizzBuzz(3));
            Assert.AreEqual("Buzz", fb.fizzBuzz(5));
            Assert.AreEqual("Fizz", fb.fizzBuzz(6));
            Assert.AreEqual("Fizz", fb.fizzBuzz(9));
            Assert.AreEqual("FizzBuzz", fb.fizzBuzz(15));
            Assert.AreEqual("FizzBuzz", fb.fizzBuzz(45));
        }

        [TestMethod]
        public void FizzBuzz_NonFizzBuzz_Nums_Test()
        {
            FizzBuzz fb = new FizzBuzz();
            Assert.AreEqual("2", fb.fizzBuzz(2));
            Assert.AreEqual("7", fb.fizzBuzz(7));
            Assert.AreEqual("17", fb.fizzBuzz(17));
            Assert.AreEqual("Fizz", fb.fizzBuzz(34));
            Assert.AreEqual("Buzz", fb.fizzBuzz(53));
            Assert.AreEqual("86", fb.fizzBuzz(86));
        }
    }
}
