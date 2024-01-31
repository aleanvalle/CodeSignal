namespace ArrayMaximalAdjacentDifference
{
    internal class Program
    {
        int ArrayMaximalAdjacentDifference(int[] inputArray)
        {
            int maximum = inputArray.Max();
            HashSet<int> adjacents = new HashSet<int>();
            for(int i = 0; i < inputArray.Length; i++)
            {
                if(i == 0)
                {
                    if(inputArray[i] == maximum && inputArray[i + 1] < maximum)
                    {
                        adjacents.Add(inputArray[i + 1]);
                    }
                }
                else if(i < inputArray.Length - 1)
                {
                    if (inputArray[i] == maximum)
                    {
                        if (inputArray[i + 1] < maximum)
                        {
                            adjacents.Add(inputArray[i + 1]);
                        }
                        if (inputArray[i - 1] < maximum)
                        {
                            adjacents.Add(inputArray[i - 1]);
                        }
                    }
                }
                else
                {
                    if (inputArray[i] == maximum && inputArray[i - 1] < maximum)
                    {
                        adjacents.Add(inputArray[i - 1]);
                    }
                }
            }
            if(adjacents.Count == 0)
            {
                adjacents.Add(maximum);
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
            int[] i = [2, 15, 15, 15, -1, 15, 15, 15, 1, 15];
            Console.WriteLine("b: " + a.ArrayMaximalAdjacentDifference(b));
            Console.WriteLine("c: " + a.ArrayMaximalAdjacentDifference(c));
            Console.WriteLine("d: " + a.ArrayMaximalAdjacentDifference(d));
            Console.WriteLine("e: " + a.ArrayMaximalAdjacentDifference(e));
            Console.WriteLine("f: " + a.ArrayMaximalAdjacentDifference(f));
            Console.WriteLine("g: " + a.ArrayMaximalAdjacentDifference(g));
            Console.WriteLine("h: " + a.ArrayMaximalAdjacentDifference(h));
            Console.WriteLine("i: " + a.ArrayMaximalAdjacentDifference(i));
        }
    }
}
