namespace LongestDigitsPrefix.Test
{
    public class UnitTest1
    {
        LongestDigitsPrefix.Program program = new LongestDigitsPrefix.Program();
        string inputString;
        string expectedValue;
        string actualValue;

        [Fact]
        public void Test1()
        {
            inputString = "123aa1";
            expectedValue = "123";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            inputString = "0123456789";
            expectedValue = "0123456789";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            inputString = " 3) always check for whitespaces";
            expectedValue = "";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            inputString = "12abc34";
            expectedValue = "12";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            inputString = "the output is 42";
            expectedValue = "";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            inputString = "aaaaaaa";
            expectedValue = "";
            actualValue = program.LongestDigitsPrefix(inputString);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}