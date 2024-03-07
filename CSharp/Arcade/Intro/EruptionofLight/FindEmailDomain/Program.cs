namespace FindEmailDomain
{
    public class Program
    {
        char ATSIGN = '@';

        public string FindEmailDomain(string address)
        {
            return address.Substring(address.LastIndexOf(ATSIGN) + 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
