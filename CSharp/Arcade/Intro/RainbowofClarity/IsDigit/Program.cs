namespace IsDigit
{
    public class Program
    {
        string DIGITS = "0123456789";

        public bool IsDigit(char symbol)
        {
            for(int i = 0; i < DIGITS.Length; i++)
            {
                if(symbol == DIGITS[i])
                {
                    return true;
                }
            }
            return false;     
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
