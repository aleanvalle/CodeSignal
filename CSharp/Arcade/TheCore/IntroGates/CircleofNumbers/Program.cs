namespace CircleofNumbers
{
    public class Program
    {
        public int CircleofNumbers(int n, int firstNumber)
        {
            return (firstNumber + n / 2) % n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
