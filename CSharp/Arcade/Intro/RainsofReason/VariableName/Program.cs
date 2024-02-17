namespace VariableName
{
    internal class Program
    {
        string Digits()
        {
            return "0123456789";
        }

        bool IsCharacterOfVariableName(char character)
        {
            string underscore = "_";
            string englishLetters = "abcdefghijklmnopqrstuvwxyz";
            string variableName = underscore + Digits() + englishLetters;
            return variableName.ToCharArray().Contains(character);
        }

        bool VariableName(string name)
        {
            char[] arrName = name.ToLower().ToCharArray();
            if (Digits().ToCharArray().Contains(arrName[0]))
            {
                return false;
            }
            else
            {
                return arrName.Select(c => IsCharacterOfVariableName(c)).ToArray().All(b => b);
            }
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string test1 = "var_1__Int";
            string test2 = "qq-q";
            string test3 = "2w2";
            string test4 = " variable";
            string test5 = "va[riable0";
            string test6 = "variable0";
            string test7 = "a";
            string test8 = "_Aas_23";
            string test9 = "a a_2";
            string test10 = "0ss";
            string[] tests = { test1, test2, test3, test4, test5, test6, test7, test8, test9, test10 };
            for(int i = 0; i < tests.Length; i++)
            {
                Console.WriteLine($"Test {i + 1}: {a.VariableName(tests[i])}\tElement: {tests[i]}");
            }
        }
    }
}
