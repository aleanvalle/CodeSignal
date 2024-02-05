namespace BoxBlur
{
    internal class Program
    {
        string printMatrix(int[][] arr)
        {
            int rowLength = arr.Length;
            int colLength = arr[0].Length;
            Console.Write("[");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("[");
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}", arr[i][j]));
                }
                Console.Write("], \n");
            }
            Console.Write("]");
            return "end";
        }

        int CorneredBlur(int[][] image, (int,int) leftUpperCornerGenerator)
        {
            double sum = 0;
            sum += image[leftUpperCornerGenerator.Item1][leftUpperCornerGenerator.Item2] + image[leftUpperCornerGenerator.Item1][leftUpperCornerGenerator.Item2 + 1] + image[leftUpperCornerGenerator.Item1][leftUpperCornerGenerator.Item2 + 2]
                   + image[leftUpperCornerGenerator.Item1 + 1][leftUpperCornerGenerator.Item2] + image[leftUpperCornerGenerator.Item1 + 1][leftUpperCornerGenerator.Item2 + 1] + image[leftUpperCornerGenerator.Item1 + 1][leftUpperCornerGenerator.Item2 + 2]
                   + image[leftUpperCornerGenerator.Item1 + 2][leftUpperCornerGenerator.Item2] + image[leftUpperCornerGenerator.Item1 + 2][leftUpperCornerGenerator.Item2 + 1] + image[leftUpperCornerGenerator.Item1 + 2][leftUpperCornerGenerator.Item2 + 2];
            double result = Math.Floor(sum / 9);
            return Convert.ToInt32(result);
        }

        int[][] BoxBlur(int[][] image)
        {
            int ZERO = 0;
            if (image.Length == 3 && image[0].Length == 3)
            {
                return new int[][] { new int[] { CorneredBlur(image, (ZERO, ZERO)) } };
            }
            else
            {
                int xLimit = image[0].Length - 1;
                int yLimit = image.Length - 1;
                int leftUpper = CorneredBlur(image, (ZERO, ZERO));
                int rightUpper = CorneredBlur(image, (ZERO, yLimit - 2));
                int leftLower = CorneredBlur(image, (xLimit - 2, ZERO));
                int rightLower = CorneredBlur(image, (xLimit - 2, yLimit - 2));
                return new int[][] { 
                    new int[] { leftUpper, rightUpper },
                    new int[] { leftLower, rightLower },
                };
            }
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
            Console.WriteLine(" b: " + a.printMatrix(a.BoxBlur(b)));
            Console.WriteLine(" c: " + a.printMatrix(a.BoxBlur(c)));
        }
    }
}
