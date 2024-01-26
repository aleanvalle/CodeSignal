namespace SortByHeight
{
    internal class Program
    {
        int[] SortByHeight(int[] a)
        {
            Dictionary<int, int> tressPos = new Dictionary<int, int>();
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == -1)
                {
                    tressPos[i] = a[i];
                }
            }
            var orderedHeights = a.Order().ToList();
            orderedHeights.RemoveAll(x => x == -1);
            foreach (var kv in tressPos)
            {
                orderedHeights.Insert(kv.Key, kv.Value);
            }
            return orderedHeights.ToArray();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] heights1 = [-1, 150, 190, 170, -1, -1, 160, 180];
            Console.WriteLine("result: " + string.Join(", ", a.SortByHeight(heights1)));
        }
    }
}
