using System;
using System.Globalization;
using SimpleConsoleApp;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
        }

        [Fact]
        public void GivenTwoNumbers_WhenAdded_ThenCorrectAnswer()
        {
            var expected = 15;
            var calculator = new Calculator();

            var actual = calculator.Add(10, 5);

            Assert.Equal(expected, actual);
        }

        [Fact(Skip = "")]
        public void CurrencyTest1()
        {
            var expected = @"A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost £12.28";
            
            //From spec
            var actual = $"A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost {12.28:C}";

            Assert.Equal(expected, actual);
        }

        [Fact(Skip = "")]
        public void CurrencyTest2()
        {
            var expected = @"A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost £12.28";

            //From spec
            var actual = $"A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost {12.28:C}";

            var stringsMatch = expected.Equals(actual, StringComparison.CurrentCulture);

            Assert.True(stringsMatch);
        }

        [Fact]
        public void CurrencyTest3()
        {
            var expected = "A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost \u00A312.28";

            //From spec
            var actual = $"A Short stay from 07/09/2017 16:50:00 to 09/09/2017 19:15:00 would cost {12.28:C}";

            Assert.Equal(expected, actual);
        }
    }
}
