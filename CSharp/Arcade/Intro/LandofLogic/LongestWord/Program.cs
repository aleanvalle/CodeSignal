namespace LongestWord
{
    public class Program
    {
        bool IsEnglishCharacter(char character)
        {
            return (character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z');
        }

        public string LongestWord(string text)
        {
            string currentWord = "";
            string longestWord = "";
            for(int i = 0; i < text.Length; i++)
            {
                if (IsEnglishCharacter(text[i]))
                {
                    currentWord += text[i];
                }
                else
                {
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }
                    currentWord = "";
                }
            }
            if (longestWord.Length == 0 || currentWord.Length > longestWord.Length)
            {
                return currentWord;
            }
            return longestWord;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
