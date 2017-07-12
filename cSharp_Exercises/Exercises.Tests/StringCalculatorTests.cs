using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void StringCalculator_Step1()
        //Testing for strings of 1, 2, 3, or 4 numbers
        {
            StringCalculator sc = new StringCalculator();
            Assert.AreEqual(0, sc.Add(""));
            Assert.AreEqual(57321, sc.Add("57321"));
            Assert.AreEqual(13633742, sc.Add("57321, 13576421"));
            Assert.AreEqual(13633743, sc.Add("57321, 13576421, 1"));
            Assert.AreEqual(13633745, sc.Add("57321, 13576421, 1, 2"));
        }

        [TestMethod]
        public void StringCalculator_Step2()
        //Testing for strings of 4 or unlimited numbers
        {
            StringCalculator sc = new StringCalculator();
            Assert.AreEqual(13633745, sc.Add("57321, 13576421, 1, 2"));
            Assert.AreEqual(55, sc.Add("1,2,3,4,5,6,7,8,9,10"));
        }

        [TestMethod]
        public void StringCalculator_Step3()
        //Testing for entry of 1, 2, or 3 newline[s]
        { 
            StringCalculator sc = new StringCalculator();
            Assert.AreEqual(13633745, sc.Add("57321\n13576421, 1\n2"));
            Assert.AreEqual(13633745, sc.Add("57321, 13576421\n1, 2"));
            Assert.AreEqual(13633745, sc.Add("57321\n13576421\n1\n2"));
        }

        [TestMethod]
        public void StringCalculator_Step4()
        //Testing for delimiter
        {
            StringCalculator sc = new StringCalculator();
            Assert.AreEqual(10, sc.Add("//!\n1!2!3!4"));
            Assert.AreEqual(10, sc.Add("//!\n1\n2!3\n4"));
        }
    }
}
