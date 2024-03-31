namespace PhoneCall.Test
{
    public class UnitTest1
    {
        PhoneCall.Program program = new PhoneCall.Program();
        int min1;
        int min2_10;
        int min11;
        int s;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            min1 = 3;
            min2_10 = 1;
            min11 = 2;
            s = 20;
            expectedValue = 14;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            min1 = 2;
            min2_10 = 2;
            min11 = 1;
            s = 2;
            expectedValue = 1;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            min1 = 10;
            min2_10 = 1;
            min11 = 2;
            s = 22;
            expectedValue = 11;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            min1 = 2;
            min2_10 = 2;
            min11 = 1;
            s = 24;
            expectedValue = 14;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            min1 = 1;
            min2_10 = 2;
            min11 = 1;
            s = 6;
            expectedValue = 3;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            min1 = 10;
            min2_10 = 10;
            min11 = 10;
            s = 8;
            expectedValue = 0;
            actualValue = program.PhoneCall(min1, min2_10, min11, s);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}