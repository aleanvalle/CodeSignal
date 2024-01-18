namespace AlmostIncreasingSequence
{
    internal class Program
    {
        bool AlmostIncreasingSequence(int[] sequence)
        {
            if (sequence.Length == 2)
            {
                return true;
            }
            else
            {
                int removedOfSequence = 0;
                for (int i = 0; i < sequence.Length; i++)
                {
                    List<int> shortSequence = sequence.ToList();
                    shortSequence.RemoveAt(i);
                    for(int j = 0; j < shortSequence.Count; j++)
                    {
                        if(j + 1 < shortSequence.Count & removedOfSequence == 0)
                        {
                            if (shortSequence[j] >= shortSequence[j + 1])
                            {
                                removedOfSequence++;
                            }
                        }
                    }
                    if (removedOfSequence == 0)
                    {
                        i = sequence.Length;
                    }
                    else if (i + 1 < sequence.Length)
                    {
                        removedOfSequence = 0;
                    }
                }
                return removedOfSequence == 0;
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
            Console.WriteLine("b: "+a.AlmostIncreasingSequence(b));
            Console.WriteLine("c: "+a.AlmostIncreasingSequence(c));
            Console.WriteLine("d: "+a.AlmostIncreasingSequence(d));
            Console.WriteLine("e: "+a.AlmostIncreasingSequence(e));
            Console.WriteLine("f: "+a.AlmostIncreasingSequence(f));
        }
    }
}
