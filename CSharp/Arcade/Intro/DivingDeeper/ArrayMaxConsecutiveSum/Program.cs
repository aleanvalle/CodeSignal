namespace ArrayMaxConsecutiveSum
{
    public class Program
    {
        int[][] CreateKArrays(int[] inputArray, int k)
        {
            int j = 0;
            bool incompletedIterations = true;
            List<int> inputList = new List<int>(inputArray);
            List<List<int>> kElements = new List<List<int>>();
            while(incompletedIterations)
            {
                kElements.Add(new List<int>());
                for (int i = inputList.Count - 1; i >= -1; i--)
                {
                    if (kElements[j].Count == k)
                    {
                        if(i == -1)
                        {
                            incompletedIterations = false;
                            break;
                        }
                        inputList = inputList.SkipLast(1).ToList();
                        j++;
                        break;
                    }
                    else
                    {
                        kElements[j].Add(inputList[i]);
                    }
                }
            }
            return kElements.Select(x => x.ToArray()).ToArray();
        }

        public int ArrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int[][] arraysToSum = CreateKArrays(inputArray, k);
            return arraysToSum.Select(x => x.Sum()).Max();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
