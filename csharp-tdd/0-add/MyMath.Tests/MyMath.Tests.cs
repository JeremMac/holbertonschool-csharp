using NUnit.Framework;

namespace TestsMyMath.Tests
{
    [TestFixture]
    public class Tests
    {
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