using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace JVBWebApp.Helpers.Tests
{
    [TestClass()]
    public class PrimeNumbersGetterTests
    {
        [TestMethod()]
        public void GetPrimeNumbersBefore5()
        {
            var sut = new PrimeNumbersGetter();

            var primeNumbersBefore5 = sut.GetPrimeNumbersBeforeGivenNumber(5);
            Assert.IsNotNull(primeNumbersBefore5);

            var expectedCollection = new List<int> { 1, 2, 3 };
            Assert.AreEqual(expectedCollection.Count, primeNumbersBefore5.Count());
            foreach (var expectedItem in expectedCollection)
            {
                Assert.IsTrue(primeNumbersBefore5.Any(t => t == expectedItem));
            }
        }

        [TestMethod()]
        public void GetPrimeNumbersBefore14()
        {
            var sut = new PrimeNumbersGetter();

            var primeNumbersBefore14 = sut.GetPrimeNumbersBeforeGivenNumber(14);
            Assert.IsNotNull(primeNumbersBefore14);

            var expectedCollection = new List<int> { 1, 2, 3, 5, 7, 11, 13 };
            Assert.AreEqual(expectedCollection.Count, primeNumbersBefore14.Count());
            foreach (var expectedItem in expectedCollection)
            {
                Assert.IsTrue(primeNumbersBefore14.Any(t => t == expectedItem));
            }
        }
    }
}