namespace AllLongestStrings
{
    internal class Program
    {
        string[] AllLongestStrings(string[] inputArray)
        {
            int maxLength = inputArray.Select(x => x.Length).ToArray().Max();
            return inputArray.Where(x => x.Length == maxLength).ToArray();
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            string[] b = ["aba", "aa", "ad", "vcd", "aba"];
            Console.WriteLine("result: " + string.Join(", ", a.AllLongestStrings(b)));
        }
    }
}
