namespace CheckPalindrome
{
    internal class Program
    {
        bool CheckPalindrome(string word)
        {
            return word == new string(word.Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("anilina is:  "+ a.CheckPalindrome("anilina"));
            Console.WriteLine("pepe is:  "+ a.CheckPalindrome("pepe"));
            Console.WriteLine("abba is:  "+ a.CheckPalindrome("abba"));
        }
    }
}
