namespace ElectionsWinners
{
    public class Program
    {
        int CountWinners(int[] votes, int k)
        {
            int winnerCount = 0;
            int anotherMax = -1;
            for(int i = 0; i < votes.Length; i++)
            {
                if (k == 0 && votes[i] == votes.Max())
                {
                    if (anotherMax == -1)
                    {
                        anotherMax = votes[i];
                    }
                    else if (anotherMax == votes[i])
                    {
                        break;
                    }
                }
                else if (anotherMax != -1 && i + 1 == votes.Length)
                {
                    winnerCount++;
                }
                else if (votes[i] + k > votes.Max())
                {
                    winnerCount++;
                }
            }
            return winnerCount;
        }

        public int ElectionsWinners(int[] votes, int k)
        {
            return CountWinners(votes, k);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
