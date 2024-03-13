namespace LineEncoding.Test
{
    public class UnitTest1
    {
        LineEncoding.Program program = new LineEncoding.Program();
        string s = "";
        string expectedValue = "";
        string actualValue = "";

        [Fact]
        public void Test1()
        {
            s = "aabbbc";
            expectedValue = "2a3bc";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            s = "abbcabb";
            expectedValue = "a2bca2b";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            s = "abcd";
            expectedValue = "abcd";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            s = "zzzz";
            expectedValue = "4z";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            s = "wwwwwwwawwwwwww";
            expectedValue = "7wa7w";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            s = "ccccccccccccccc";
            expectedValue = "15c";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            s = "qwertyuioplkjhg";
            expectedValue = "qwertyuioplkjhg";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            s = "ssiiggkooo";
            expectedValue = "2s2i2gk3o";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            s = "adfaaa";
            expectedValue = "adf3a";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            s = "bbjaadlkjdl";
            expectedValue = "2bj2adlkjdl";
            actualValue = program.LineEncoding(s);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}