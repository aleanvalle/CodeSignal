namespace DigitDegree
{
    public class Program
    {
        int SumTheDigits(char[] inputArray)
        {
            return inputArray.Select(x => Convert.ToInt32(x.ToString())).Sum();
        }

        char[] DigitsToCharArray(int n)
        {
            return n.ToString().ToCharArray();
        }

        public int DigitDegree(int n)
        {
            char[] nArray = DigitsToCharArray(n);
            int degree = 0;
            if(nArray.Length == 1)
            {
                return degree;
            }
            else
            {
                degree++;
                while (SumTheDigits(nArray) > 9)
                {
                    nArray = DigitsToCharArray(SumTheDigits(nArray));
                    degree++;
                }
                /*
                int remainder = FromCharArrayToInt(nArray);
                while (remainder > 9)
                {
                    remainder = FromCharArrayToInt(FromIntToCharArray(remainder));
                    degree++;
                }
                */
            }
            return degree;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
