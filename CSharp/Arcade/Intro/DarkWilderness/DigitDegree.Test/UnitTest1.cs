namespace DigitDegree.Test
{
    public class UnitTest1
    {
        DigitDegree.Program program = new DigitDegree.Program();
        int n;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            n = 5;
            expectedValue = 0;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            n = 100;
            expectedValue = 1;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            n = 91;
            expectedValue = 2;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            n = 99;
            expectedValue = 2;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            n = 1000000000;
            expectedValue = 1;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            n = 9;
            expectedValue = 0;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            n = 73;
            expectedValue = 2;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            n = 877;
            expectedValue = 2;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            n = 777773;
            expectedValue = 3;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            n = 304;
            expectedValue = 1;
            actualValue = program.DigitDegree(n);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}