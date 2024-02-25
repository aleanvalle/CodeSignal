namespace ExtractEachKth
{
    public class Program
    {
        int[] CreateKths(int k, int arrayLength)
        {
            int MINUS = -1;
            List<int> Kths = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                Kths.Add(i * k + MINUS);
            }
            return Kths.Where(x => x >= 0 && x < arrayLength).ToArray();
        }

        public int[] ExtractEachKth(int[] inputArray, int k)
        {
            int[] kths = CreateKths(k, inputArray.Length);
            List<int> inputList = new List<int>(inputArray);
            for(int i = kths.Length - 1; i >= 0; i--)
            {
                inputList.RemoveAt(kths[i]);
            }
            return inputList.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
