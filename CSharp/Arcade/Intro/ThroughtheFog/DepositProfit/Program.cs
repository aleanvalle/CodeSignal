namespace DepositProfit
{
    public class Program
    {
        int CalculateGrowthRate(int deposit, int rate, int threshold)
        {
            double PERCENTAGE = 100.0;
            int years = 0;
            double percentageRate;
            double newDeposit = deposit;
            while(newDeposit < threshold)
            {
                percentageRate = (rate / PERCENTAGE);
                newDeposit = newDeposit * ++percentageRate;
                years++;
            }
            return years;
        }

        public int DepositProfit(int deposit, int rate, int threshold)
        {
            return CalculateGrowthRate(deposit, rate, threshold);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
