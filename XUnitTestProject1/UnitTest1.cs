using System;
using SimpleConsoleApp;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GivenTwoNumbers_WhenAdded_ThenCorrectAnswer()
        {
            var expected = 15;
            var calculator = new Calculator();

            var actual = calculator.Add(10, 5);

            Assert.Equal(expected, actual);
        }
    }
}
