using Microsoft.VisualStudio.TestTools.UnitTesting;
using JVBWebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JVBWebApp.Helpers;
using Moq;

namespace JVBWebApp.Controllers.Tests
{
    [TestClass()]
    public class PrimeNumbersControllerTests
    {
        private readonly Mock<IPrimeNumbersGetter> _getter;
        private readonly PrimeNumbersController _sut;
        public PrimeNumbersControllerTests()
        {
            _getter = new Mock<IPrimeNumbersGetter>();
            _sut = new PrimeNumbersController(_getter.Object);
        }

        [TestMethod()]
        public void ShouldThrowExceptionIfGetterIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new PrimeNumbersController(null));
        }

        [TestMethod()]
        public void GetPrimeNumbersBeforeGivenTest()
        {
            var lists = _sut.GetPrimeNumbersBeforeGiven(5);

            _getter.Verify(m => m.GetPrimeNumbersBeforeGivenNumber(5), Times.Once);
        }
    }
}