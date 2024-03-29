namespace CircleofNumbers.Test
{
    public class UnitTest1
    {
        CircleofNumbers.Program program = new CircleofNumbers.Program();
        int n;
        int firstNumber;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 10;
            firstNumber = 2;
            expectedValue = 7;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 10;
            firstNumber = 7;
            expectedValue = 2;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 4;
            firstNumber = 1;
            expectedValue = 3;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 6;
            firstNumber = 3;
            expectedValue = 0;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 18;
            firstNumber = 6;
            expectedValue = 15;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 12;
            firstNumber = 10;
            expectedValue = 4;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            n = 18;
            firstNumber = 5;
            expectedValue = 14;
            actualValue = program.CircleofNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}