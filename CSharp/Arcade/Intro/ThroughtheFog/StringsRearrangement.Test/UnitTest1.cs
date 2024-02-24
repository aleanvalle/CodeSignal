namespace StringsRearrangement.Test
{
    public class UnitTest1
    {
        StringsRearrangement.Program stringsRearrangement;

        public UnitTest1()
        {
            stringsRearrangement = new StringsRearrangement.Program();
        }

        [Fact]
        public void Test1()
        {
            string[] inputArray = { "aba", "bbb", "bab" };
            bool expectedValue = false;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            string[] inputArray = { "ab", "bb", "aa" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            string[] inputArray = { "q", "q" };
            bool expectedValue = false;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            string[] inputArray = { "zzzzab", "zzzzbb", "zzzzaa" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            string[] inputArray = { "ab", "ad", "ef", "eg" };
            bool expectedValue = false;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            string[] inputArray = { "abc", "bef", "bcc", "bec", "bbc", "bdc" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            string[] inputArray = { "abc", "abx", "axx", "abc" };
            bool expectedValue = false;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            string[] inputArray = { "abc", "abx", "axx", "abx", "abc" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            string[] inputArray = { "f", "g", "a", "h" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            string[] inputArray = { "ff", "gf", "af", "ar", "hf" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test11()
        {
            string[] inputArray = { "a", "b", "c" };
            bool expectedValue = true;
            bool actualValue = stringsRearrangement.StringsRearrangement(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}