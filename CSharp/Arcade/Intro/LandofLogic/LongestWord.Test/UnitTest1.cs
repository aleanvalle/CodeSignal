namespace LongestWord.Test
{
    public class UnitTest1
    {
        LongestWord.Program program = new LongestWord.Program();
        string text = "";
        string expectedValue = "";
        string actualValue = "";

        [Fact]
        public void Test1()
        {
            text = "Ready, steady, go!";
            expectedValue = "steady";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            text = "Ready[[[, steady, go!";
            expectedValue = "steady";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            text = "ABCd";
            expectedValue = "ABCd";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            text = "To be or not to be";
            expectedValue = "not";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            text = "You are the best!!!!!!!!!!!! CodeFighter ever!";
            expectedValue = "CodeFighter";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            text = "a , ba";
            expectedValue = "ba";
            actualValue = program.LongestWord(text);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}