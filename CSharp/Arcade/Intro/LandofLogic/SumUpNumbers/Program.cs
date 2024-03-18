namespace SumUpNumbers
{
    public class Program
    {
        bool IsDigit(char character)
        {
            return character >= '0' && character <= '9';
        }

        public int SumUpNumbers(string inputString)
        {
            int sum = 0;
            string currentNumber = "";
            for(int i = 0; i < inputString.Length; i++)
            {
                if (IsDigit(inputString[i]))
                {
                    currentNumber += inputString[i];
                }
                else
                {
                    if(currentNumber.Length > 0)
                    {
                        sum += Convert.ToInt32(currentNumber);
                    }
                    currentNumber = "";
                }
            }
            if(currentNumber.Length > 0)
            {
                sum += Convert.ToInt32(currentNumber);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
