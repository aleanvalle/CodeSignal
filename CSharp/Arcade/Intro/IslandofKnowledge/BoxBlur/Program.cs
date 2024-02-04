namespace BoxBlur
{
    internal class Program
    {
        int printMatrix(int[][] arr)
        {
            int rowLength = arr.Length;
            int colLength = arr[0].Length;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", arr[j]));
                }
                Console.Write(string.Format("{0} ", arr[i]));
            }
            Console.ReadLine();
            return 0;
        }

        int[][] BoxBlur(int[][] image)
        {
            double sum = 0;
            for (int i = 0; i < image.Length; i++)
            {
                for(int j = 0; j < image[i].Length; j++)
                {
                    sum += image[i][j];
                }
            }
            double result = Math.Floor(sum / (image.Length * image[0].Length));
            return new int[][] { new int[] { Convert.ToInt32(result) } };
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[][] b = { 
                new int[] { 1, 1, 1},
                new int[] { 1, 7, 1},
                new int[] { 1, 1, 1} 
            };
            int[][] c = { 
                new int[] { 7, 4, 0, 1},
                new int[] { 5, 6, 2, 2},
                new int[] { 6, 10, 7, 8},
                new int[] { 1, 4, 2, 0}
            };
            Console.WriteLine("b: " + a.printMatrix(a.BoxBlur(b)));
            Console.WriteLine("c: " + a.printMatrix(a.BoxBlur(c)));
        }
    }
}
