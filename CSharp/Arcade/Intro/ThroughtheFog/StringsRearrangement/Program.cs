namespace StringsRearrangement
{
    public class Program
    {
        bool AreCharEqual(char character1, char character2)
        {
            return character1.Equals(character2);
        }

        bool AreStringsAlmostEqual(string string1, string string2)
        {
            List<bool> matchingCharacters = new List<bool>();
            for(int i  = 0; i < string1.Length; i++)
            {
                matchingCharacters.Add(AreCharEqual(string1[i], string2[i]));
            }
            return matchingCharacters.Count(b => !b) <= 1;
        }

        bool IsStringArrayAlmostEqual(string[] strings)
        {
            List<bool> matchingArray = new List<bool>();
            for(int i = 0; i < strings.Length - 1; i++)
            {
                matchingArray.Add(AreStringsAlmostEqual(strings[i], strings[i + 1]));
            }
            return matchingArray.All(b => b);
        }

        bool StringsRearrangement(string[] strings)
        {
            if(!IsStringArrayAlmostEqual(strings))
            {
                //do something
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
