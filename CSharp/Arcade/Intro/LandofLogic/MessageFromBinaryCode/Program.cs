namespace MessageFromBinaryCode
{
    public class Program
    {
        char ConvertBinaryStringToChar(string aByte)
        {
            int EXPONENT = 7;
            double sum = 0;
            for(int i = 0; i < aByte.Length; i++) 
            {
                if (aByte[i] == '1')
                {
                    sum += Math.Pow(2, EXPONENT);
                }
                EXPONENT--;
            }
            return (char) sum;
        }

        public string MessageFromBinaryCode(string code)
        {
            string aByte = "";
            string hiddenMessage = "";
            for(int i = 0; i < code.Length; i++)
            {
                if (aByte.Length == 8)
                {
                    hiddenMessage += ConvertBinaryStringToChar(aByte);
                    aByte = "";
                }
                aByte += code[i];
                if (i + 1 == code.Length)
                {
                    hiddenMessage += ConvertBinaryStringToChar(aByte);
                }
            }
            return hiddenMessage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
