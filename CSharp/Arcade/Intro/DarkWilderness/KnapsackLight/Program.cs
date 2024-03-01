using System.Linq.Expressions;

namespace KnapsackLight
{
    public class Program
    {
        public int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW) 
        {
            if(maxW < weight1 && maxW < weight2)
            {
                return 0;
            }
            else if(maxW >= weight1 + weight2)
            {
                return value1 + value2;
            }
            else if(maxW >= weight1 && maxW >= weight2)
            {
                return Math.Max(value1, value2);
            }
            else if(maxW >= weight1 && maxW < weight2)
            {
                return value1;
            }
            else
            {
                return value2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
