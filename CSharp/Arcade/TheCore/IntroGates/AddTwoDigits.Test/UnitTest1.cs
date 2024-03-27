namespace AddTwoDigits.Test
{
    public class UnitTest1
    {
        AddTwoDigits.Program program = new AddTwoDigits.Program();
        int n;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 29;
            expectedValue = 11;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 48;
            expectedValue = 12;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 10;
            expectedValue = 1;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 25;
            expectedValue = 7;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 52;
            expectedValue = 7;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 99;
            expectedValue = 18;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            n = 44;
            expectedValue = 8;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            n = 50;
            expectedValue = 5;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            n = 39;
            expectedValue = 12;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            n = 26;
            expectedValue = 8;
            actualValue = program.AddTwoDigits(n);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}