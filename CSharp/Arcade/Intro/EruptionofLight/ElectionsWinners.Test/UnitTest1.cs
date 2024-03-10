namespace ElectionsWinners.Test
{
    public class UnitTest1
    {
        ElectionsWinners.Program program = new ElectionsWinners.Program();
        int[] votes = new int[5];
        int k;
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            votes = [2, 3, 5, 2];
            k = 3;
            expectedValue = 2;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            votes = [1, 3, 3, 1, 1];
            k = 0;
            expectedValue = 0;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            votes = [5, 1, 3, 4, 1];
            k = 0;
            expectedValue = 1;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            votes = [1, 1, 1, 1];
            k = 1;
            expectedValue = 4;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            votes = [1, 1, 1, 1];
            k = 0;
            expectedValue = 0;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            votes = [3, 1, 1, 3, 1];
            k = 2;
            expectedValue = 2;
            actualValue = program.ElectionsWinners(votes, k);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}