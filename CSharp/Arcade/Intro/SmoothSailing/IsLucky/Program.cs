namespace IsLucky
{
    internal class Program
    {
        bool IsLucky(int n)
        {
            int limit = n.ToString().Length;
            int half = limit / 2;
            var firstPart = n.ToString().ToList().Take(limit - half);
            var secondPart = n.ToString().ToList().Skip(half);
            var firstNumPart = firstPart.Select(x => int.Parse(x.ToString()));
            var secondNumPart = secondPart.Select(x => int.Parse(x.ToString()));
            return firstNumPart.Sum() == secondNumPart.Sum();
        } 

        static void Main(string[] args)
        {
            Program a = new Program();
            int n1 = 1230;
            int n2 = 239017;
            Console.WriteLine("result: " + a.IsLucky(n1));
            Console.WriteLine("result: " + a.IsLucky(n2));
        }
    }
}
