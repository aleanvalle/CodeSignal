namespace MaxMultiple.Test
{
    public class UnitTest1
    {
        MaxMultiple.Program program = new MaxMultiple.Program();
        int divisor;
        int bound;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            divisor = 3;
            bound = 10;
            expectedValue = 9;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            divisor = 2;
            bound = 7;
            expectedValue = 6;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            divisor = 10;
            bound = 50;
            expectedValue = 50;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            divisor = 7;
            bound = 100;
            expectedValue = 98;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            divisor = 7;
            bound = 20;
            expectedValue = 14;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            divisor = 5;
            bound = 13;
            expectedValue = 10;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            divisor = 8;
            bound = 88;
            expectedValue = 88;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            divisor = 10;
            bound = 100;
            expectedValue = 100;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            divisor = 2;
            bound = 5;
            expectedValue = 4;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            divisor = 3;
            bound = 5;
            expectedValue = 3;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test11()
        {
            divisor = 9;
            bound = 11;
            expectedValue = 9;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test12()
        {
            divisor = 8;
            bound = 15;
            expectedValue = 8;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test13()
        {
            divisor = 9;
            bound = 60;
            expectedValue = 54;
            actualValue = program.MaxMultiple(divisor, bound);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}