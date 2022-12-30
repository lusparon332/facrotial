using System;
using Xunit;
using System.Diagnostics;
using Factorial.Func;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        { 
            var n = 10;

            int result = factorial(n);
            int expected = 3819000;

            Assert.Equal(expected, result);
        }
    }
}
