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
    }
}