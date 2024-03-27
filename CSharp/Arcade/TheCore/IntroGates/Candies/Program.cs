namespace Candies
{
    public class Program
    {
        public int Candies(int n, int m)
        {
            while(m % n != 0 && m > 0)
            {
                m--;
            }
            return m;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
