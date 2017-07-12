using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class PrimeFactorizationTests
    {
        [TestMethod]
        public void Factorize_Negative1_Rtrns_Empty_Array_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { }, pm.Factorize(-1));
        }

        [TestMethod]
        public void Factorize1_Rtrns_Empty_Array_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { }, pm.Factorize(1));
        }

        [TestMethod]
        public void Factorize2_Rtrns_2_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 2 }, pm.Factorize(2));
        }

        [TestMethod]
        public void Factorize3_Rtrns_3_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 3 }, pm.Factorize(3));
        }

        [TestMethod]
        public void Factorize6_Rtrns_2_3_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 2, 3 }, pm.Factorize(6));
        }

        [TestMethod]
        public void Factorize7_Rtrns_7_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 7 }, pm.Factorize(7));
        }

        [TestMethod]
        public void Factorize8_Rtrns_2_2_2_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 2, 2, 2 }, pm.Factorize(8));
        }

        [TestMethod]
        public void Factorize_More_Prime_Nums_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 11 }, pm.Factorize(11));
            CollectionAssert.AreEqual(new int[] { 13 }, pm.Factorize(13));
            CollectionAssert.AreEqual(new int[] { 17 }, pm.Factorize(17));
            CollectionAssert.AreEqual(new int[] { 193 }, pm.Factorize(193));
            CollectionAssert.AreEqual(new int[] { 5209 }, pm.Factorize(5209));
            CollectionAssert.AreEqual(new int[] { 7919 }, pm.Factorize(7919));
        }

        [TestMethod]
        public void Factorize_More_NonPrime_Nums_Test()
        {
            PrimeFactorization pm = new PrimeFactorization();
            CollectionAssert.AreEqual(new int[] { 3, 7 }, pm.Factorize(21));
            CollectionAssert.AreEqual(new int[] { 3,3,11 }, pm.Factorize(99));
            CollectionAssert.AreEqual(new int[] { 2,2,2,2,2,2,2,2 }, pm.Factorize(256));
            CollectionAssert.AreEqual(new int[] { 2,2,7,73 }, pm.Factorize(2044));
            CollectionAssert.AreEqual(new int[] { 7,11,101 }, pm.Factorize(7777));
            CollectionAssert.AreEqual(new int[] { 2,2,2,2,2,2,2,2,2,2,2,2,2 }, pm.Factorize(8192));
        }
    }
}
