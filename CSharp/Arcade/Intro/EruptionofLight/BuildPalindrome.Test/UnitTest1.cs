namespace BuildPalindrome.Test
{
    public class UnitTest1
    {
        BuildPalindrome.Program program = new BuildPalindrome.Program();
        string st = "";
        string expectedValue = "";
        string actualValue = "";

        [Fact]
        public void Test1()
        {
            st = "abcdc";
            expectedValue = "abcdcba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            st = "ababab";
            expectedValue = "abababa";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            st = "abba";
            expectedValue = "abba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            st = "abaa";
            expectedValue = "abaaba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            st = "aaaaba";
            expectedValue = "aaaabaaaa";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            st = "abc";
            expectedValue = "abcba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            st = "kebab";
            expectedValue = "kebabek";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            st = "abccba";
            expectedValue = "abccba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            st = "abcabc";
            expectedValue = "abcabcbacba";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            st = "cbdbedffcg";
            expectedValue = "cbdbedffcgcffdebdbc";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test11()
        {
            st = "euotmn";
            expectedValue = "euotmnmtoue";
            actualValue = program.BuildPalindrome(st);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}