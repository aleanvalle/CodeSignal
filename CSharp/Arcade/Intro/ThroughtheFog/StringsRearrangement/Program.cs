namespace StringsRearrangement
{
    public class Program
    {
        Permutations.Program permutations = new Permutations.Program();
        Prettier.Program prettier = new Prettier.Program();

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

        public bool StringsRearrangement(string[] inputArray)
        {
            string[][] stringPermutation = permutations.GetPermutations(inputArray, inputArray.Length);
            List<bool> validRearrangements = new List<bool>();
            for(int i = 0; i < stringPermutation.Length; i++)
            {
                validRearrangements.Add(StringsDifferConsecutivelyInOneChar(stringPermutation[i]));
            }
            return validRearrangements.Any(b => b);
        }

        void Main(string[] args)
        {
            Program a = new Program();
            string[] b = {"aba", "bbb", "bab"};
            prettier.PrintMatrix(a.permutations.GetPermutations(b, b.Length));
        }
    }
}
