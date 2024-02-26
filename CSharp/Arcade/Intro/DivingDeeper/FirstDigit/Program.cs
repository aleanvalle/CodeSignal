namespace FirstDigit
{
    public class Program
    {
        bool IsDigit(char character)
        {
            string DIGITS = "0123456789";
            return DIGITS.ToCharArray().Contains(character);
        }

        public char FirstDigit(string inputString)
        {
            List<char> inputList = new List<char>(inputString.ToCharArray());
            return inputList.Where(c => IsDigit(c)).FirstOrDefault();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
