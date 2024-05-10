using NUnit.Framework;

namespace TestsMyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int a = 5;
            int b = 5;

            int output = MyMath.Operations.Add(a, b);

            Assert.That(output, Is.EqualTo(10));
        }
    }
}