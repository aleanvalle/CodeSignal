namespace KnapsackLight.Test
{
    public class UnitTest1
    {
        KnapsackLight.Program program;
        int value1;
        int weight1;
        int value2;
        int weight2;
        int maxW;
        int expectedValue;
        int actualValue;

        public UnitTest1()
        {
            program = new KnapsackLight.Program();
        }

        [Fact]
        public void Test1()
        {
            value1 = 10;
            weight1 = 5;
            value2 = 6;
            weight2 = 4;
            maxW = 8;
            expectedValue = 10;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            value1 = 10;
            weight1 = 5;
            value2 = 6;
            weight2 = 4;
            maxW = 9;
            expectedValue = 16;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            value1 = 5;
            weight1 = 3;
            value2 = 7;
            weight2 = 4;
            maxW = 6;
            expectedValue = 7;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            value1 = 10;
            weight1 = 2;
            value2 = 11;
            weight2 = 3;
            maxW = 1;
            expectedValue = 0;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            value1 = 15;
            weight1 = 2;
            value2 = 20;
            weight2 = 3;
            maxW = 2;
            expectedValue = 15;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            value1 = 2;
            weight1 = 5;
            value2 = 3;
            weight2 = 4;
            maxW = 5;
            expectedValue = 3;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            value1 = 4;
            weight1 = 3;
            value2 = 3;
            weight2 = 4;
            maxW = 4;
            expectedValue = 4;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            value1 = 3;
            weight1 = 5;
            value2 = 3;
            weight2 = 8;
            maxW = 10;
            expectedValue = 3;
            actualValue = program.KnapsackLight(value1, weight1, value2, weight2, maxW);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}