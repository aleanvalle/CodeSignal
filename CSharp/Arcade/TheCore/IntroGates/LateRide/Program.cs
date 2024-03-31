namespace LateRide
{
    public class Program
    {
        public int LateRide(int n)
        {
            int firstDigit = (n / 60) / 10;
            int secondDigit = (n / 60) % 10;
            int thirdDigit = (n % 60) / 10;
            int fourthDigit = (n % 60) % 10;
            return firstDigit + secondDigit + thirdDigit + fourthDigit;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
