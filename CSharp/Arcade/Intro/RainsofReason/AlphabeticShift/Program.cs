namespace AlphabeticShift
{
    public class Program
    {
        char ShiftToNextLetter(char character)
        {
            Dictionary<char, char> enAlphabetNextShift = new Dictionary<char, char>()
            {
                { 'a', 'b' },
                { 'b', 'c' },
                { 'c', 'd' },
                { 'd', 'e' },
                { 'e', 'f' },
                { 'f', 'g' },
                { 'g', 'h' },
                { 'h', 'i' },
                { 'i', 'j' },
                { 'j', 'k' },
                { 'k', 'l' },
                { 'l', 'm' },
                { 'm', 'n' },
                { 'n', 'o' },
                { 'o', 'p' },
                { 'p', 'q' },
                { 'q', 'r' },
                { 'r', 's' },
                { 's', 't' },
                { 't', 'u' },
                { 'u', 'v' },
                { 'v', 'w' },
                { 'w', 'x' },
                { 'x', 'y' },
                { 'y', 'z' },
                { 'z', 'a' },
            };
            return enAlphabetNextShift[character];
        }

        public string AlphabeticShift(string inputString)
        {
            char[] shiftedString = inputString.ToLower().ToCharArray();
            return new string(shiftedString.Select(c => ShiftToNextLetter(c)).ToArray());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
