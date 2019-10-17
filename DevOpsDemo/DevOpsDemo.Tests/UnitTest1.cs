using NUnit.Framework;

namespace DevOpsDemo.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Pass()
        {
            Assert.Pass();
        }

        [Test]
        public void Fail()
        {
            Assert.Fail();
        }
    }
}