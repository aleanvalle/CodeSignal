namespace DifferentSymbolsNaive
{
    public class Program
    {
        public int DifferentSymbolsNaive(string s)
        {
            List<char> sList = new List<char>(s);
            List<char> temp = new List<char>();
            for(int i = 0; i < sList.Count; i++)
            {
                if (!temp.Contains(sList[i]))
                {
                    temp.Add(sList[i]);
                }
            }
            return temp.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
