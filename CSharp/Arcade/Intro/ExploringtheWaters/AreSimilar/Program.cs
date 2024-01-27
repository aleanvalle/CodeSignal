using System.IO.Pipes;

namespace AreSimilar
{
    internal class Program
    {
        bool SimilarityCheck(int[] a, int[] b)
        {
            Dictionary<int, int> dictOfA = a.OrderBy(x => x)
                .GroupBy(x => x)
                .Where(x => x.Count() > 0)
                .ToDictionary(x => x.Key, x => x.Count());
            Dictionary<int, int> dictOfB = b.OrderBy(x => x)
                .GroupBy(x => x)
                .Where(x => x.Count() > 0)
                .ToDictionary(x => x.Key, x => x.Count());
            return dictOfA.SequenceEqual(dictOfB);
        }

        bool AreSimilar(int[] a, int[] b)
        {
            if (SimilarityCheck(a, b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b1 = [1, 2, 3];
            int[] b2 = [1, 2, 3];
            int[] c1 = [1, 2, 3];
            int[] c2 = [2, 1, 3];
            int[] d1 = [1, 2, 2];
            int[] d2 = [2, 1, 1];
            Console.WriteLine("result: " + a.SimilarityCheck(b1, b2));
            Console.WriteLine("result: " + a.SimilarityCheck(c1, c2));
            Console.WriteLine("result: " + a.SimilarityCheck(d1, d2));
            Console.WriteLine("//////////////");
            Console.WriteLine("result: " + a.AreSimilar(b1, b2));
            Console.WriteLine("result: " + a.AreSimilar(c1, c2));
            Console.WriteLine("result: " + a.AreSimilar(d1, d2));
        }
    }
}
