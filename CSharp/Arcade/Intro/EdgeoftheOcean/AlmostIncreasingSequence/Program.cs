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
            if (sequence.Length > 0 && iteration >= 0)
            {
                int currentMin = sequence.Min();
                int currentMax = sequence.Max();
                int firstPos = 0;
                int lastPos = sequence.Length - 1;
                int currentMinFirst = sequence.ToList().IndexOf(currentMin);
                int currentMinLast = sequence.ToList().LastIndexOf(currentMin);
                int currentMaxFirst = sequence.ToList().IndexOf(currentMax);
                int currentMaxLast = sequence.ToList().LastIndexOf(currentMax);
                int all_except_last = lastPos;
                int all_except_first = firstPos;
                bool currentMinIsUnique = currentMinFirst == currentMinLast;
                bool currentMaxIsUnique = currentMaxFirst == currentMaxLast;
                bool currentMinIsFirst = currentMinFirst == firstPos;
                bool currentMaxIsLast = currentMaxLast == lastPos;
                bool currentExtremesAreUnique = currentMinIsUnique && currentMaxIsUnique;
                bool currentExtremesAreExtremes = currentMinIsFirst && currentMaxIsLast;
                bool previousMaxIsBigger = currentMax < previousMax;
                bool previousMinIsSmaller = currentMin > previousMin;
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
            else
            {
                return iteration > 0;
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
            int[] g = { 1, 2, 1, 2 };
            int[] h = { 1, 1, 2, 3, 4, 4 };
            int[] i = { 1, 1, 1, 2, 3 };
            long startTime_SortedSet = Stopwatch.GetTimestamp();
            Console.WriteLine("b_strictly_new: " + a.StrictlyIncreasing_SortedSet(b));
            Console.WriteLine("c_strictly_new: " + a.StrictlyIncreasing_SortedSet(c));
            Console.WriteLine("d_strictly_new: " + a.StrictlyIncreasing_SortedSet(d));
            Console.WriteLine("e_strictly_new: " + a.StrictlyIncreasing_SortedSet(e));
            Console.WriteLine("f_strictly_new: " + a.StrictlyIncreasing_SortedSet(f));
            Console.WriteLine("g_strictly_new: " + a.StrictlyIncreasing_SortedSet(g));
            Console.WriteLine("h_strictly_new: " + a.StrictlyIncreasing_SortedSet(h));
            Console.WriteLine("i_strictly_new: " + a.StrictlyIncreasing_SortedSet(i));
            TimeSpan elapsedTime_SortedSet = Stopwatch.GetElapsedTime(startTime_SortedSet);
            Console.WriteLine("////////////////////////////");
            long startTime = Stopwatch.GetTimestamp();
            Console.WriteLine("b_strictly_old: " + a.StrictlyIncreasing(b));
            Console.WriteLine("c_strictly_old: " + a.StrictlyIncreasing(c));
            Console.WriteLine("d_strictly_old: " + a.StrictlyIncreasing(d));
            Console.WriteLine("e_strictly_old: " + a.StrictlyIncreasing(e));
            Console.WriteLine("f_strictly_old: " + a.StrictlyIncreasing(f));
            Console.WriteLine("g_strictly_old: " + a.StrictlyIncreasing(g));
            Console.WriteLine("h_strictly_old: " + a.StrictlyIncreasing(h));
            Console.WriteLine("i_strictly_old: " + a.StrictlyIncreasing(i));
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
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Time of strictly: " + elapsedTime.TotalSeconds);
            Console.WriteLine("Time of strictly_SortedSet: " + elapsedTime_SortedSet.TotalSeconds);
        }
    }
}