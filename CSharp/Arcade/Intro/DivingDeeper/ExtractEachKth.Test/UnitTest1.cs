namespace ExtractEachKth.Test
{
    public class UnitTest1
    {
        ExtractEachKth.Program extractEachKth;

        public UnitTest1()
        {
            extractEachKth = new ExtractEachKth.Program();
        }

        [Fact]
        public void Test1()
        {
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;
            int[] expectedValue = { 1, 2, 4, 5, 7, 8, 10 };
            int[] actualValue = extractEachKth.ExtractEachKth(inputArray, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            int[] inputArray = { 1, 1, 1, 1, 1 };
            int k = 1;
            int[] expectedValue = { };
            int[] actualValue = extractEachKth.ExtractEachKth(inputArray, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            int[] inputArray = { 1, 2, 1, 2, 1, 2, 1, 2 };
            int k = 2;
            int[] expectedValue = { 1, 1, 1, 1 };
            int[] actualValue = extractEachKth.ExtractEachKth(inputArray, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            int[] inputArray = { 1, 2, 1, 2, 1, 2, 1, 2 };
            int k = 10;
            int[] expectedValue = { 1, 2, 1, 2, 1, 2, 1, 2 };
            int[] actualValue = extractEachKth.ExtractEachKth(inputArray, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            int[] inputArray = { 2, 4, 6, 8, 10 };
            int k = 2;
            int[] expectedValue = { 2, 6, 10 };
            int[] actualValue = extractEachKth.ExtractEachKth(inputArray, k);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}