namespace DifferentSymbolsNaive.Test
{
    public class UnitTest1
    {
        DifferentSymbolsNaive.Program program;

        public UnitTest1()
        {
            program = new DifferentSymbolsNaive.Program();
        }

        [Fact]
        public void Test1()
        {
            string s = "cabca";
            int expectedValue = 3;
            int actualValue = program.DifferentSymbolsNaive(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            string s = "aba";
            int expectedValue = 2;
            int actualValue = program.DifferentSymbolsNaive(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            string s = "ccccccccccc";
            int expectedValue = 1;
            int actualValue = program.DifferentSymbolsNaive(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            string s = "bcaba";
            int expectedValue = 3;
            int actualValue = program.DifferentSymbolsNaive(s);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            string s = "codesignal";
            int expectedValue = 10;
            int actualValue = program.DifferentSymbolsNaive(s);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}