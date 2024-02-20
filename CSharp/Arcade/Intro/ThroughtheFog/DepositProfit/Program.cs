namespace DepositProfit
{
    public class Program
    {
        int CalculateGrowthRate(int deposit, int rate, int threshold)
        {
            double PERCENTAGE = 100.0;
            int years = 0;
            double percentageRate;
            while(deposit < threshold)
            {
                percentageRate = (rate / PERCENTAGE);
                deposit = (int) (deposit * ++percentageRate);
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
