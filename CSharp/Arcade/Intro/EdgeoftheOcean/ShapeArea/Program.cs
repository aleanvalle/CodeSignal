namespace ShapeArea
{
    internal class Program
    {
        public int ShapeArea(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return 4 * n + ShapeArea(n - 1) - 4;
            }

        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("1:" + a.ShapeArea(1));
            Console.WriteLine("2:" + a.ShapeArea(2));
            Console.WriteLine("3:" + a.ShapeArea(3));
        }
    }
}
