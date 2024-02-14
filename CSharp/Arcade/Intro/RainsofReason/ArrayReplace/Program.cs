namespace ArrayReplace
{
    internal class Program
    {
        int Replace(int elementInCollection, int elementToReplace, int substitutionElem)
        {
            if(elementInCollection == elementToReplace)
            {
                return substitutionElem;
            }
            else
            {
                return elementInCollection;
            }
        }

        int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select(elem => Replace(elem, elemToReplace, substitutionElem)).ToArray();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            PrettyMultiArray.Program b = new PrettyMultiArray.Program();
            //(inputArray, elemToReplace, substitutionElem)
            (int[], int, int) c = ([1, 2, 1], 1, 3);
            (int[], int, int) d = ([1, 2, 3, 4, 5], 3, 0);
            (int[], int, int) e = ([1, 1, 1], 1, 10);
            (int[], int, int) f = ([1, 2, 1, 2, 1], 2, 1);
            (int[], int, int) g = ([1, 2, 1, 2, 1], 2, 2);
            (int[], int, int) h = ([3, 1], 3, 9);
            (int[], int, int) i = ([10, 10], 0, 9);
            (int[], int, int) j = ([2, 1], 3, 9);
            Console.WriteLine("c: " + b.PrintArray(a.ArrayReplace(c.Item1, c.Item2, c.Item3)));
            Console.WriteLine("d: " + b.PrintArray(a.ArrayReplace(d.Item1, d.Item2, d.Item3)));
            Console.WriteLine("e: " + b.PrintArray(a.ArrayReplace(e.Item1, e.Item2, e.Item3)));
            Console.WriteLine("f: " + b.PrintArray(a.ArrayReplace(f.Item1, f.Item2, f.Item3)));
            Console.WriteLine("g: " + b.PrintArray(a.ArrayReplace(g.Item1, g.Item2, g.Item3)));
            Console.WriteLine("h: " + b.PrintArray(a.ArrayReplace(h.Item1, h.Item2, h.Item3)));
            Console.WriteLine("i: " + b.PrintArray(a.ArrayReplace(i.Item1, i.Item2, i.Item3)));
            Console.WriteLine("j: " + b.PrintArray(a.ArrayReplace(j.Item1, j.Item2, j.Item3)));
        }
    }
}
