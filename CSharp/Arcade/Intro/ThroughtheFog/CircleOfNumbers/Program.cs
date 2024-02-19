namespace CircleOfNumbers
{
    public class Program
    {
        int CircularOpposite(int n, int firstNumber)
        {
            int half = n / 2;
            Dictionary<int, int> lowerAndUpperHalfs = new Dictionary<int, int>();
            int upper = half;
            int lower = 0;
            for(int l = 0; l < half; l++)
            {
                lowerAndUpperHalfs[l] = upper;
                upper++;
            }
            for(int h = half; h < n; h++)
            {
                lowerAndUpperHalfs[h] = lower;
                lower++;
            }
            return lowerAndUpperHalfs[firstNumber];
        }

        public int CircleOfNumbers(int n, int firstNumber)
        {
            return CircularOpposite(n, firstNumber);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
