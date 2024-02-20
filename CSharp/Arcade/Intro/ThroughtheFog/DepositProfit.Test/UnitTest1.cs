namespace DepositProfit.Test
{
    public class UnitTest1
    {
        DepositProfit.Program depositProfit;

        public UnitTest1()
        {
            depositProfit = new DepositProfit.Program();
        }

        [Fact]
        public void Test1()
        {
            int deposit = 100;
            int rate = 20;
            int threshold = 170;
            int expectedValue = 3;
            int actualValue = depositProfit.DepositProfit(deposit, rate, threshold);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            int deposit = 100;
            int rate = 1;
            int threshold = 101;
            int expectedValue = 1;
            int actualValue = depositProfit.DepositProfit(deposit, rate, threshold);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            int deposit = 1;
            int rate = 100;
            int threshold = 64;
            int expectedValue = 6;
            int actualValue = depositProfit.DepositProfit(deposit, rate, threshold);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            int deposit = 20;
            int rate = 20;
            int threshold = 50;
            int expectedValue = 6;
            int actualValue = depositProfit.DepositProfit(deposit, rate, threshold);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            int deposit = 50;
            int rate = 25;
            int threshold = 100;
            int expectedValue = 4;
            int actualValue = depositProfit.DepositProfit(deposit, rate, threshold);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}