namespace Add
{
    internal class Program
    {
        int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.Add(5, 105));
        }
    }
}
