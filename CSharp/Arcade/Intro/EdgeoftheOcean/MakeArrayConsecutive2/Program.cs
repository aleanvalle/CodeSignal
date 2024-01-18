namespace MakeArrayConsecutive2
{
    internal class Program
    {
        int MakeArrayConsecutive2(int[] intArray)
        {
            int min_statue = intArray.Min();
            int max_statue = intArray.Max();
            int statuesLeft = 0;
            for(int i = min_statue; i < max_statue; i++) 
            {
                int next_statue = i + 1;
                if(!Array.Exists(intArray, statue => statue == next_statue))
                {
                    statuesLeft++;
                }
            }
            return statuesLeft;
        }
        static void Main(string[] args)
        {
            var lista = new int[] { 6, 2, 3, 8 };
            var lista2 = new int[] { 9, 6, 3, 12 };
            var lista3 = new int[] { 1, 2, 3, 4 };
            var lista4 = new int[] { 0, 3 };
            Program a = new Program();
            Console.WriteLine("4, 5, 7; total: " + a.MakeArrayConsecutive2(lista));
            Console.WriteLine("4, 5, 7, 8, 10, 11; total: " + a.MakeArrayConsecutive2(lista2));
            Console.WriteLine("nada; total: " + a.MakeArrayConsecutive2(lista3));
            Console.WriteLine("1, 2; total: " + a.MakeArrayConsecutive2(lista4));
            Console.WriteLine("formulasa: " + (lista.Max() - lista.Min() - lista.Length + 1));
            
        }
    }
}
