namespace PalindromeRearranging
{
    internal class Program
    {
        int PalindromeCheck(int errorCounter, string word)
        {
            if (word != new String(word.Reverse().ToArray()))
            {
                errorCounter++;
            }
            return errorCounter;
        }

        Dictionary<char, int> CountAllLetters(string word)
        {
            Dictionary<char, int> dictOfA = word.OrderByDescending(x => x)
                .GroupBy(x => x)
                .Where(x => x.Count() > 0)
                .ToDictionary(x => x.Key, x => x.Count());
            return dictOfA;
        }

        (string, int, char) PalindromeConstructor((string, int, char) palindromeConstructor, Dictionary<char, int> allLetters)
        {
            foreach (char k in allLetters.Keys)
            {
                int amountOfK = allLetters[k];
                if (amountOfK % 2 != 0)
                {
                    palindromeConstructor.Item2 += 1;
                    palindromeConstructor.Item3 = k;
                }
                palindromeConstructor.Item1 += new string(k, amountOfK / 2);
            }
            return palindromeConstructor;
        }

        bool PalindromeRearranging(string inputString)
        {
            int palindromeNotFound = PalindromeCheck(0, inputString);
            (string, int, char) palindromeConstructor = ("", 0, ' ');
            if (palindromeNotFound == 1)
            {
                var allLetters = CountAllLetters(inputString);
                palindromeConstructor = PalindromeConstructor(palindromeConstructor, allLetters);
                if(palindromeConstructor.Item2 >= 2)
                {
                    return false;
                }
                palindromeConstructor = PalindromeConstructor(palindromeConstructor, allLetters.Reverse().ToDictionary());
                if(palindromeConstructor.Item2 == 1)
                {
                    int half = palindromeConstructor.Item1.Length / 2;
                    char lastLetter = palindromeConstructor.Item3;
                    palindromeConstructor.Item1.Insert(half, lastLetter.ToString());
                }
            }
            return PalindromeCheck(palindromeNotFound, palindromeConstructor.Item1) == 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
