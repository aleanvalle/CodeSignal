namespace AlmostIncreasingSequence
{
    internal class Program
    {
        bool StrictlyIncreasing(int[] sequence, int previous_maximum = int.MaxValue, int iteration = 0)
        {
            int last_int = sequence.Last();
            int max_int = sequence.Max();
            int all_except_last = sequence.Length - 1;
            if (sequence.Length > 1 & iteration >= 0)
            {
                if (max_int < previous_maximum & max_int == last_int)
                {
                    var newSequence = sequence.Take(all_except_last).ToArray();
                    previous_maximum = max_int;
                    iteration++;
                    return StrictlyIncreasing(newSequence, previous_maximum, iteration);
                }
                else
                {
                    iteration = -1;
                    return StrictlyIncreasing(sequence, max_int, iteration);
                }
            }
            else
            {
                return iteration >= 0;
            }
                

        }
        bool AlmostIncreasingSequence(int[] sequence)
        {
            var checks = new List<bool>();
            if (sequence.Length == 2)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < sequence.Length; i++)
                {
                    List<int> shortSequence = sequence.ToList();
                    shortSequence.RemoveAt(i);
                    bool is_strictly_increasing = StrictlyIncreasing(shortSequence.ToArray());
                    checks.Add(is_strictly_increasing);
                }
                return checks.Any(x => x);
            }
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = { 1, 3, 2, 1 };
            int[] c = { 1, 3, 2 };
            int[] d = { 1, 2, 3, 4, 6 };
            int[] e = { 2, 3, 4, 100, 95, 102 };
            int[] f = { 5, 2, 4, 1, 95, 102 };
            Console.WriteLine("b_strictly: " + a.StrictlyIncreasing(b));
            Console.WriteLine("c_strictly: " + a.StrictlyIncreasing(c));
            Console.WriteLine("d_strictly: " + a.StrictlyIncreasing(d));
            Console.WriteLine("e_strictly: " + a.StrictlyIncreasing(e));
            Console.WriteLine("f_strictly: " + a.StrictlyIncreasing(f));
            Console.WriteLine("b_almost: " + a.AlmostIncreasingSequence(b));
            Console.WriteLine("c_almost: " + a.AlmostIncreasingSequence(c));
            Console.WriteLine("d_almost: " + a.AlmostIncreasingSequence(d));
            Console.WriteLine("e_almost: " + a.AlmostIncreasingSequence(e));
            Console.WriteLine("f_almost: " + a.AlmostIncreasingSequence(f));
        }
    }
}
