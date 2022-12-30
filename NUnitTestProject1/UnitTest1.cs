using NUnit.Framework;
using Factorial;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int n = 5;
            int result = Fact.factorial(n);
            int expected = 120;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void Test2()
        {
            int n = 0;
            int result = Fact.factorial(n);
            int expected = 1;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void Test3()
        {
            int n = 1;
            int result = Fact.factorial(n);
            int expected = 1;
            Assert.AreEqual(result, expected);
        }
    }
}