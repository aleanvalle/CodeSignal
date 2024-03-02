namespace LongestDigitsPrefix
{
    public class Program
    {
        string DIGITS = "0123456789";
        
        bool isDigit(char character)
        {
            return DIGITS.Contains(character);
        }

        public string LongestDigitsPrefix(string inputString)
        {
            List<char> inputList = new List<char>(inputString.ToCharArray());
            string longestPrefixWithDigits = "";
            for (int i = 0; i < inputList.Count; i++)
            {
                if (isDigit(inputList[i]))
                {
                    longestPrefixWithDigits += inputList[i];
                }
                else
                {
                    break;
                }
            }
            return longestPrefixWithDigits;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
