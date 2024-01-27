namespace AlternatingSums
{
    internal class Program
    {
        int[] AlternatingSums(int[] a)
        {
            List<int> team1 = new List<int>();
            List<int> team2 = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if((i + 1) % 2 == 0)
                {
                    team2.Add(a[i]);
                }
                else
                {
                    team1.Add(a[i]);
                }
            }
            return new int[] { team1.Sum(), team2.Sum() };
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = [50, 60, 60, 45, 70];
            Console.WriteLine("result: " + string.Join(", ", a.AlternatingSums(b)));
        }
    }
}
