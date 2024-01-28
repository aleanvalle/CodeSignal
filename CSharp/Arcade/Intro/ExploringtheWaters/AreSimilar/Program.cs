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
            int errCount = 0;
            if (SimilarityCheck(a, b))
            {
                for(int k=0; k < a.Length; k++)
                {
                    if (a[k] != b[k])
                    {
                        errCount++;
                        if (errCount > 2)
                        {
                            k = a.Length;
                        }
                    }
                }
                return errCount <= 2;
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
            int[] e1 = [832, 998, 148, 570, 533, 561, 894, 147, 455, 279];
            int[] e2 = [832, 570, 148, 998, 533, 561, 455, 147, 894, 279];
            Console.WriteLine("result: " + a.SimilarityCheck(b1, b2));
            Console.WriteLine("result: " + a.SimilarityCheck(c1, c2));
            Console.WriteLine("result: " + a.SimilarityCheck(d1, d2));
            Console.WriteLine("result: " + a.SimilarityCheck(e1, e2));
            Console.WriteLine("//////////////");
            Console.WriteLine("result: " + a.AreSimilar(b1, b2));
            Console.WriteLine("result: " + a.AreSimilar(c1, c2));
            Console.WriteLine("result: " + a.AreSimilar(d1, d2));
            Console.WriteLine("result: " + a.AreSimilar(e1, e2));
        }
    }
}