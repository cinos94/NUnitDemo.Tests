using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitDemo.Tests
{
        [TestFixture]
        public class CalculatorTests
        {
            [Test]
            public void Add_Always_ReturnsExpectedResult()
            {
                var systemUnderTest = new Calculator();
                Assert.That(systemUnderTest.Add(1, 2), Is.EqualTo(3));
            }
        }
}
