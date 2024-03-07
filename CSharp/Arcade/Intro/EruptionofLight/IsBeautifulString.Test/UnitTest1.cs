namespace IsBeautifulString.Test
{
    public class UnitTest1
    {
        IsBeautifulString.Program program = new IsBeautifulString.Program();
        string inputString = "";
        bool expectedValue;
        bool actualValue;

        [Fact]
        public void Test1()
        {
            inputString = "bbbaacdafe";
            expectedValue = true;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            inputString = "aabbb";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            inputString = "bbc";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            inputString = "bbbaa";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            inputString = "abcdefghijklmnopqrstuvwxyzz";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            inputString = "abcdefghijklmnopqrstuvwxyz";
            expectedValue = true;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            inputString = "abcdefghijklmnopqrstuvwxyzqwertuiopasdfghjklxcvbnm";
            expectedValue = true;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            inputString = "fyudhrygiuhdfeis";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            inputString = "zaa";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            inputString = "zyy";
            expectedValue = false;
            actualValue = program.IsBeautifulString(inputString);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}