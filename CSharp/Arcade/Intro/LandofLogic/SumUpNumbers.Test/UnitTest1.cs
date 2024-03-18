namespace SumUpNumbers.Test
{
    public class UnitTest1
    {
        SumUpNumbers.Program program = new SumUpNumbers.Program();
        string inputString = "";
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            inputString = "2 apples, 12 oranges";
            expectedValue = 14;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            inputString = "123450";
            expectedValue = 123450;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            inputString = "Your payment method is invalid";
            expectedValue = 0;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            inputString = "no digits at all";
            expectedValue = 0;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            inputString = "there are some (12) digits 5566 in this 770 string 239";
            expectedValue = 6587;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            inputString = "42+781";
            expectedValue = 823;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            inputString = "abc abc 4 abc 0 abc";
            expectedValue = 4;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            inputString = "abcdefghijklmnopqrstuvwxyz1AbCdEfGhIjKlMnOpqrstuvwxyz23,74 -";
            expectedValue = 98;
            actualValue = program.SumUpNumbers(inputString);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}