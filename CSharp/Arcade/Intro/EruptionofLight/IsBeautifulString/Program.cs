namespace IsBeautifulString
{
    public class Program
    {
        static string ENGLISHALFABET = "abcdefghijklmnopqrstuvwxyz";
        List<char> englishChars = new List<char>(ENGLISHALFABET);

        Dictionary<char, int> CountLetters(string inputString)
        {
            Dictionary<char, int> lettersCount = new Dictionary<char, int>();
            for(int i = 0; i < englishChars.Count; i++)
            {
                int counter = 0;
                for(int j = 0; j < inputString.Length; j++)
                {
                    if (inputString[j] == englishChars[i])
                    {
                        counter++;
                    }
                }
                lettersCount[englishChars[i]] = counter;
            }
            return lettersCount;
        }

        bool IsBeautiful(Dictionary<char, int> lettersCount)
        {
            int previousAmount = 0;
            bool isBeautiful = true;
            for(int i = 0; i < englishChars.Count; i++)
            {
                if (i == 0)
                {
                    previousAmount = lettersCount[englishChars[i]];
                }
                else if(i > 0)
                {
                    if (previousAmount >= lettersCount[englishChars[i]])
                    {
                        previousAmount = lettersCount[englishChars[i]];
                    }
                    else
                    {
                        isBeautiful = false;
                        break;
                    }
                }
            }
            return isBeautiful;
        }

        public bool IsBeautifulString(string inputString)
        {
            return IsBeautiful(CountLetters(inputString));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
