namespace StringsRearrangement
{
    public class Program
    {
        bool IsOdd(int number)
        {
            return number % 2 == 1;
        }

        void Swap(string[] elementsToPermute, int a, int b)
        {
            string temp = elementsToPermute[a];
            elementsToPermute[a] = elementsToPermute[b];
            elementsToPermute[b] = temp;
        }

        string[][] StringPermutation(string[] elementsToPermute, int n)
        {
            List<List<string>> permutations = new List<List<string>>();
            if(n == 1)
            {
                permutations.Add(elementsToPermute.ToList());
                return permutations.Select(l => l.ToArray()).ToArray();
            }
            int[] index = new int[n];
            for(int i = 0; i < n; i++)
            {
                index[i] = 0;
            }
            permutations.Add(elementsToPermute.ToList());
            for(int i = 1; i < n;) 
            {
                if (index[i] < i)
                {
                    if (IsOdd(i))
                    {
                        Swap(elementsToPermute, i, index[i]);
                    }
                    else
                    {
                        Swap(elementsToPermute, i, 0);
                    }
                    permutations.Add(elementsToPermute.ToList());
                    index[i]++;
                    i = 1;
                }
                else
                {
                    index[i++] = 0;
                }
            }
            return permutations.Select(l => l.ToArray()).ToArray();
        }

        bool AreCharEqual(char character1, char character2)
        {
            return character1.Equals(character2);
        }

        bool DiffersInOneChar(string string1, string string2)
        {
            List<bool> matchingCharacters = new List<bool>();
            for(int i  = 0; i < string1.Length; i++)
            {
                matchingCharacters.Add(AreCharEqual(string1[i], string2[i]));
            }
            return matchingCharacters.Count(b => !b) == 1;
        }

        bool StringsDifferConsecutivelyInOneChar(string[] inputArray)
        {
            List<bool> matchingArray = new List<bool>();
            for(int i = 0; i < inputArray.Length - 1; i++)
            {
                matchingArray.Add(DiffersInOneChar(inputArray[i], inputArray[i + 1]));
            }
            return matchingArray.All(b => b);
        }

        bool StringsRearrangement(string[] inputArray)
        { 
            if(!StringsDifferConsecutivelyInOneChar(inputArray))
            {
                //continue later...
            }
            return true;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            PrettyMultiArray.Program prettyMultiArray = new PrettyMultiArray.Program();
            string[] b = {"aba", "bbb", "bab"};
            prettyMultiArray.PrintMatrix(a.StringPermutation(b, b.Length));
        }
    }
}
