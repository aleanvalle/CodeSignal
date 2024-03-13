namespace IsDigit.Test
{
    public class UnitTest1
    {
        IsDigit.Program program = new IsDigit.Program();
        char symbol;
        bool expectedValue;
        bool actualValue;

        [Fact]
        public void Test1()
        {
            symbol = '0';
            expectedValue = true;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            symbol = '-';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            symbol = 'o';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            symbol = '1';
            expectedValue = true;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            symbol = '2';
            expectedValue = true;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            symbol = '!';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            symbol = '@';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            symbol = '+';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            symbol = '6';
            expectedValue = true;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            symbol = '(';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test11()
        {
            symbol = ')';
            expectedValue = false;
            actualValue = program.IsDigit(symbol);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}