namespace MaxMultiple
{
    public class Program
    {
        public int MaxMultiple(int divisor, int bound)
        {
            while(bound % divisor != 0 && bound > 0)
            {
                bound--;
            }
            return bound;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
