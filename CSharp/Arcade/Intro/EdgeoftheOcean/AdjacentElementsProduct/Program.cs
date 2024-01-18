namespace AdjacentElementsProduct
{
    internal class Program
    {
        int AdjacentElementsProduct(int[] inputArray)
        {
            int largestProduct = -1001;
            for (int i = 0; i < inputArray.Length; i++) 
            { 
                if(i + 1 < inputArray.Length)
                {
                    int nextProduct = inputArray[i] * inputArray[i + 1];
                    if (nextProduct > largestProduct)
                    {
                        largestProduct = nextProduct;
                    }
                }
            }
            return largestProduct;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = { 5, -6, 7, 3, 2, 4 };
            Console.WriteLine(a.AdjacentElementsProduct(b));
        }
    }
}
