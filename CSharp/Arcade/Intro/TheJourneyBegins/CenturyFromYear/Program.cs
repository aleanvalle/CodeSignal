namespace CenturyFromYear
{
    internal class Program
    {
        bool CenturyFromYear(int number)
        {
            return (number % 4 == 0) & (number % 100 != 0 | number % 400 == 0);
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.CenturyFromYear(1900));
        }
    }
}
