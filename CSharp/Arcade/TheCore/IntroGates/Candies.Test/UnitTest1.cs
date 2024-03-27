namespace Candies.Test
{
    public class UnitTest1
    {
        Candies.Program program = new Candies.Program();
        int n;
        int m;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 3;
            m = 10;
            expectedValue = 9;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 1;
            m = 2;
            expectedValue = 2;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 10;
            m = 5;
            expectedValue = 0;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 4;
            m = 4;
            expectedValue = 4;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 4;
            m = 15;
            expectedValue = 12;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 9;
            m = 100;
            expectedValue = 99;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            n = 8;
            m = 2;
            expectedValue = 0;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            n = 3;
            m = 3;
            expectedValue = 3;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            n = 7;
            m = 10;
            expectedValue = 7;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            n = 3;
            m = 23;
            expectedValue = 21;
            actualValue = program.Candies(n, m);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}