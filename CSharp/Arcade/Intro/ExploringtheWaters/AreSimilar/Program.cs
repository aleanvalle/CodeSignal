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

        Dictionary<int, Tuple<int, int>> FindPair(int elemInA, int posElemA, int[] b)
        {
            var dict = new Dictionary<int, Tuple<int, int>>();
            for (int posElemB = 0; posElemB <= b.Length; posElemB++)
            {
                if (elemInA == b[posElemB])
                {
                    //return new Tuple<int, int, int>(elem, posElem, j);
                    dict[elemInA] = new Tuple<int, int>(posElemA, posElemB);
                }
            }
            return dict;
        }

        bool AreSimilar(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            else
            {
                return true;
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
