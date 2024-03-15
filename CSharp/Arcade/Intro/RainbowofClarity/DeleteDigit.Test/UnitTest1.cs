namespace DeleteDigit.Test
{
    public class UnitTest1
    {
        DeleteDigit.Program program = new DeleteDigit.Program();
        int n;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 152;
            expectedValue = 52;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 1001;
            expectedValue = 101;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 10;
            expectedValue = 1;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 222219;
            expectedValue = 22229;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 109;
            expectedValue = 19;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 222250;
            expectedValue = 22250;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            n = 44435;
            expectedValue = 4445;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            n = 12;
            expectedValue = 2;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            n = 218616;
            expectedValue = 28616;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            n = 861452;
            expectedValue = 86452;
            actualValue = program.DeleteDigit(n);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}