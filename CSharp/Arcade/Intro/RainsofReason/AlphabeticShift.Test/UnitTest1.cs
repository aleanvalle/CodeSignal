namespace AlphabeticShift.Test
{
    public class UnitTest1
    {
        AlphabeticShift.Program alphabeticShift;
        string test1;
        string test2;
        string test3;
        string test4;
        string test5;

        public UnitTest1()
        {
            alphabeticShift = new AlphabeticShift.Program();
            test1 = "crazy";
            test2 = "z";
            test3 = "aaaabbbccd";
            test4 = "fuzzy";
            test5 = "codesignal";
        }

        [Fact]
        public void Test1()
        {
            string actualValue = alphabeticShift.AlphabeticShift(test1);
            string expectedValue = "dsbaz";
            Assert.Equal(actualValue, expectedValue);
        }

        [Fact]
        public void Test2()
        {
            string actualValue = alphabeticShift.AlphabeticShift(test2);
            string expectedValue = "a";
            Assert.Equal(actualValue, expectedValue);
        }

        [Fact]
        public void Test3()
        {
            string actualValue = alphabeticShift.AlphabeticShift(test3);
            string expectedValue = "bbbbcccdde";
            Assert.Equal(actualValue, expectedValue);
        }

        [Fact]
        public void Test4()
        {
            string actualValue = alphabeticShift.AlphabeticShift(test4);
            string expectedValue = "gvaaz";
            Assert.Equal(actualValue, expectedValue);
        }

        [Fact]
        public void Test5()
        {
            string actualValue = alphabeticShift.AlphabeticShift(test5);
            string expectedValue = "dpeftjhobm";
            Assert.Equal(actualValue, expectedValue);
        }
    }
}