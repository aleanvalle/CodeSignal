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
            Dictionary<char, int> dictOfA = word.OrderBy(x => x)
                .GroupBy(x => x)
                .Where(x => x.Count() > 0)
                .ToDictionary(x => x.Key, x => x.Count());
            return dictOfA.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
        }

        (string, int, char) PalindromeConstructor((string, int, char) palindromeConstructor, Dictionary<char, int> allLetters)
        {
            int oddCounter = 0;
            for(int index = 0; index < allLetters.Count; index++)
            {
                KeyValuePair<char, int> letterCount = allLetters.ElementAt(index);
                int amountOfK = letterCount.Value;
                if (amountOfK % 2 != 0)
                {
                    oddCounter += 1;
                    palindromeConstructor.Item3 = letterCount.Key;
                }
                palindromeConstructor.Item1 += new string(letterCount.Key, amountOfK / 2);
                if(oddCounter == 2)
                {
                    index = allLetters.Count;
                    palindromeConstructor.Item2 = oddCounter;
                }
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
                if(palindromeConstructor.Item2 == 2)
                {
                    return false;
                }
                palindromeConstructor = PalindromeConstructor(palindromeConstructor, allLetters.Reverse().ToDictionary(x => x.Key, y => y.Value));
                if(palindromeConstructor.Item2 == 1)
                {
                    int half = palindromeConstructor.Item1.Length / 2;
                    char lastLetter = palindromeConstructor.Item3;
                    palindromeConstructor.Item1 = palindromeConstructor.Item1.Insert(half, lastLetter.ToString());
                }
                return PalindromeCheck(palindromeNotFound, palindromeConstructor.Item1) == 1;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string b = "aabb";
            string c = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabc";
            string d = "abbcabb";
            string e = "zyyzzzzz";
            string f = "z";
            string g = "zaa";
            string h = "abca";
            string i = "abcad";
            string j = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbccccaaaaaaaaaaaaa";
            string k = "abdhuierf";
            Console.WriteLine("b: " + a.PalindromeRearranging(b));
            Console.WriteLine("c: " + a.PalindromeRearranging(c));
            Console.WriteLine("d: " + a.PalindromeRearranging(d));
            Console.WriteLine("e: " + a.PalindromeRearranging(e));
            Console.WriteLine("f: " + a.PalindromeRearranging(f));
            Console.WriteLine("g: " + a.PalindromeRearranging(g));
            Console.WriteLine("h: " + a.PalindromeRearranging(h));
            Console.WriteLine("i: " + a.PalindromeRearranging(i));
            Console.WriteLine("j: " + a.PalindromeRearranging(j));
            Console.WriteLine("k: " + a.PalindromeRearranging(k));
        }
    }
}
