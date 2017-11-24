using NUnit.Framework;

namespace UnitTesting.GettingStarted.Tests
{
    [TestFixture]
    public class HelloNunit
    {
        [Test]
        public void TestHelloNunit()
        {
            Assert.That(true, Is.False);
        }
    }
}