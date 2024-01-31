namespace ArrayMaximalAdjacentDifference
{
    internal class Program
    {
        int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int maximum = inputArray.Max();
            int maximumPos = inputArray.ToList().IndexOf(maximum);
            List<int> adjacents;
            if(maximumPos > 0 && maximumPos < inputArray.Length - 1)
            {
                adjacents = new List<int>() { inputArray[maximumPos - 1], inputArray[maximumPos + 1] };
            }
            else if (maximumPos == inputArray.Length - 1)
            {
                adjacents = new List<int>() { inputArray[maximumPos - 1] };
            }
            else
            {
                adjacents = new List<int>() { inputArray[maximumPos + 1] };
            }
            return maximum - adjacents.Min();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = [2, 4, 1, 0];
            int[] c = [1, 1, 1, 1];
            int[] d = [-1, 4, 10, 3, -2];
            int[] e = [10, 11, 13];
            int[] f = [-2, -2, -2, -2, -2];
            int[] g = [-1, 1, -3, -4];
            int[] h = [-14, 15, -15];
            Console.WriteLine("b: " + a.ArrayMaximalAdjacentDifference(b));
            Console.WriteLine("c: " + a.ArrayMaximalAdjacentDifference(c));
            Console.WriteLine("d: " + a.ArrayMaximalAdjacentDifference(d));
            Console.WriteLine("e: " + a.ArrayMaximalAdjacentDifference(e));
            Console.WriteLine("f: " + a.ArrayMaximalAdjacentDifference(f));
            Console.WriteLine("g: " + a.ArrayMaximalAdjacentDifference(g));
            Console.WriteLine("h: " + a.ArrayMaximalAdjacentDifference(h));
        }
    }
}
