using System.Diagnostics;

namespace AlmostIncreasingSequence
{
    internal class Program
    {
        bool StrictlyIncreasing_SortedSet(int[] sequence)
        {
            SortedSet<int> newSequence = new SortedSet<int>(sequence);
            var newSequenceOrdered = newSequence.ToArray();
            return newSequenceOrdered.SequenceEqual(sequence);
        }

        bool StrictlyIncreasing(int[] sequence, int previousMin = int.MinValue, int previousMax = int.MaxValue, int iteration = 0)
        {
            if(iteration != -1 && sequence.Length != 0)
            {
                int firstPos = 0;
                int lastPos = sequence.Length - 1;
                int all_except_last = lastPos;
                int all_except_first = firstPos + 1;
                int currentMin = sequence.Min();
                int currentMax = sequence.Max();
                int currentMinFirst = sequence.ToList().IndexOf(currentMin);
                int currentMinLast = sequence.ToList().LastIndexOf(currentMin);
                int currentMaxFirst = sequence.ToList().IndexOf(currentMax);
                int currentMaxLast = sequence.ToList().LastIndexOf(currentMax);
                bool previousMaxIsBigger = currentMax < previousMax;
                bool previousMinIsSmaller = currentMin > previousMin;
                bool currentMinIsUnique = currentMinFirst == currentMinLast;
                bool currentMaxIsUnique = currentMaxFirst == currentMaxLast;
                bool currentMinIsFirst = currentMinFirst == firstPos;
                bool currentMaxIsLast = currentMaxLast == lastPos;
                bool currentExtremesAreUnique = currentMinIsUnique && currentMaxIsUnique;
                bool currentExtremesAreExtremes = currentMinIsFirst && currentMaxIsLast;
                if (currentExtremesAreUnique && currentExtremesAreExtremes && previousMaxIsBigger && previousMinIsSmaller)
                {
                    var newSequence = sequence.Take(all_except_last).Skip(all_except_first).ToArray();
                    previousMax = currentMax;
                    previousMin = currentMin;
                    iteration++;
                    return StrictlyIncreasing(newSequence, previousMin, previousMax, iteration);
                }
                else
                {
                    iteration = -1;
                    return StrictlyIncreasing(sequence, previousMin, previousMax, iteration);
                }
            }
            return iteration > 0;
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
            int[] g = { 1, 2, 1, 2 };
            int[] h = { 1, 1, 2, 3, 4, 4 };
            int[] i = { 1, 1, 1, 2, 3 };
            int[] j = { 2, 50, 100 };
            int[] k = { 2, 14};
            long startTime_SortedSet = Stopwatch.GetTimestamp();
            Console.WriteLine("b_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(b));
            Console.WriteLine("c_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(c));
            Console.WriteLine("d_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(d));
            Console.WriteLine("e_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(e));
            Console.WriteLine("f_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(f));
            Console.WriteLine("g_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(g));
            Console.WriteLine("h_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(h));
            Console.WriteLine("i_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(i));
            Console.WriteLine("j_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(j));
            Console.WriteLine("k_strictly_Sorted_set: " + a.StrictlyIncreasing_SortedSet(k));
            TimeSpan elapsedTime_SortedSet = Stopwatch.GetElapsedTime(startTime_SortedSet);
            Console.WriteLine("////////////////////////////");
            long startTime = Stopwatch.GetTimestamp();
            Console.WriteLine("b_strictly: " + a.StrictlyIncreasing(b));
            Console.WriteLine("c_strictly: " + a.StrictlyIncreasing(c));
            Console.WriteLine("d_strictly: " + a.StrictlyIncreasing(d));
            Console.WriteLine("e_strictly: " + a.StrictlyIncreasing(e));
            Console.WriteLine("f_strictly: " + a.StrictlyIncreasing(f));
            Console.WriteLine("g_strictly: " + a.StrictlyIncreasing(g));
            Console.WriteLine("h_strictly: " + a.StrictlyIncreasing(h));
            Console.WriteLine("i_strictly: " + a.StrictlyIncreasing(i));
            Console.WriteLine("j_strictly: " + a.StrictlyIncreasing(j));
            Console.WriteLine("k_strictly: " + a.StrictlyIncreasing(k));
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("b_almost: " + a.AlmostIncreasingSequence(b));
            Console.WriteLine("c_almost: " + a.AlmostIncreasingSequence(c));
            Console.WriteLine("d_almost: " + a.AlmostIncreasingSequence(d));
            Console.WriteLine("e_almost: " + a.AlmostIncreasingSequence(e));
            Console.WriteLine("f_almost: " + a.AlmostIncreasingSequence(f));
            Console.WriteLine("g_almost: " + a.AlmostIncreasingSequence(g));
            Console.WriteLine("h_almost: " + a.AlmostIncreasingSequence(h));
            Console.WriteLine("i_almost: " + a.AlmostIncreasingSequence(i));
            Console.WriteLine("j_almost: " + a.AlmostIncreasingSequence(j));
            Console.WriteLine("k_almost: " + a.AlmostIncreasingSequence(k));
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Time of strictly: " + elapsedTime.TotalSeconds);
            Console.WriteLine("Time of strictly_SortedSet: " + elapsedTime_SortedSet.TotalSeconds);
        }
    }
}