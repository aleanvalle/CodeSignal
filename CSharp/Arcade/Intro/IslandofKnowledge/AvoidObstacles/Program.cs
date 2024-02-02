namespace AvoidObstacles
{
    internal class Program
    {

        int AvoidObstacles(int[] inputArray)
        {
            HashSet<int> freeSpaces = new HashSet<int>();
            if(inputArray.Length > 2) 
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] != inputArray.Max() && inputArray[i] != inputArray.Min())
                    {
                        if (!inputArray.Contains(inputArray[i] + 1))
                        {
                            freeSpaces.Add(inputArray[i] + 1);
                        }
                        if (!inputArray.Contains(inputArray[i] - 1))
                        {
                            freeSpaces.Add(inputArray[i] - 1);
                        }
                    }
                }
                List<int> freeSpacesToJump = freeSpaces.ToList();
                freeSpacesToJump.RemoveAll(x => inputArray.Contains(x + x));
                return freeSpacesToJump.Min();
            }
            else
            {
                if(inputArray.Min() + inputArray.Min() == inputArray.Max())
                {
                    return inputArray.Min() + 1;
                }
                else
                {
                    return inputArray.Max() + 1;
                }
            }
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
