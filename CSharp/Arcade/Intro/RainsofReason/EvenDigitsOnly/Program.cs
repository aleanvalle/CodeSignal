namespace EvenDigitsOnly
{
    internal class Program
    {
        bool digitIsEven(int n)
        {
            return n % 2 == 0;
        }

        bool EvenDigitsOnly(int n)
        {
            return n.ToString().ToCharArray().Select(c => digitIsEven(int.Parse(c.ToString()))).ToArray().All(b => b);
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int b = 248622;
            int c = 642386;
            int d = 248842;
            int e = 1;
            int f = 8;
            int g = 2462487;
            int h = 468402800;
            int i = 2468428;
            int j = 5468428;
            int k = 7468428;
            Console.WriteLine("b: " + a.EvenDigitsOnly(b));
            Console.WriteLine("c: " + a.EvenDigitsOnly(c));
            Console.WriteLine("d: " + a.EvenDigitsOnly(d));
            Console.WriteLine("e: " + a.EvenDigitsOnly(e));
            Console.WriteLine("f: " + a.EvenDigitsOnly(f));
            Console.WriteLine("g: " + a.EvenDigitsOnly(g));
            Console.WriteLine("h: " + a.EvenDigitsOnly(h));
            Console.WriteLine("i: " + a.EvenDigitsOnly(i));
            Console.WriteLine("j: " + a.EvenDigitsOnly(j));
            Console.WriteLine("k: " + a.EvenDigitsOnly(k));
        }
    }
}
