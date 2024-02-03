namespace AvoidObstacles
{
    internal class Program
    {
        int AvoidObstacles(int[] inputArray)
        {
            List<int> jumps = new List<int>();
            for(int i = 2; i < 11;)
            {
                if(inputArray.Any(x => x % i == 0))
                {
                    i++;
                }
                else
                {
                    jumps.Add(i);
                    i++;
                }
            }
            return jumps.Min();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = [5, 3, 6, 7, 9];
            int[] c = [2, 3];
            int[] d = [1, 4, 10, 6, 2];
            int[] e = [1000, 999];
            int[] f = [19, 32, 11, 23];
            int[] g = [5, 8, 9, 13, 14];
            Console.WriteLine("b: " + a.AvoidObstacles(b));
            Console.WriteLine("c: " + a.AvoidObstacles(c));
            Console.WriteLine("d: " + a.AvoidObstacles(d));
            Console.WriteLine("e: " + a.AvoidObstacles(e));
            Console.WriteLine("f: " + a.AvoidObstacles(f));
            Console.WriteLine("g: " + a.AvoidObstacles(g));
        }
    }
}
