namespace LateRide.Test
{
    public class UnitTest1
    {
        LateRide.Program program = new LateRide.Program();
        int n;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 240;
            expectedValue = 4;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 808;
            expectedValue = 14;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 1439;
            expectedValue = 19;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 0;
            expectedValue = 0;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 23;
            expectedValue = 5;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 8;
            expectedValue = 8;
            actualValue = program.LateRide(n);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}