namespace LargestNumber.Test
{
    public class UnitTest1
    {
        LargestNumber.Program program = new LargestNumber.Program();
        int n;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 2;
            expectedValue = 99;
            actualValue = program.LargestNumber(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 1;
            expectedValue = 9;
            actualValue = program.LargestNumber(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 7;
            expectedValue = 9999999;
            actualValue = program.LargestNumber(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 4;
            expectedValue = 9999;
            actualValue = program.LargestNumber(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 3;
            expectedValue = 999;
            actualValue = program.LargestNumber(n);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}