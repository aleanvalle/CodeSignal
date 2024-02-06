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
                    if (j + 1 != colLength)
                    {
                        Console.Write(",");
                    }
                    
                }
                Console.Write("]");
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
            int xLimit = image[0].Length - 1;
            int yLimit = image.Length - 1;
            if (image.Length == 3 && image[0].Length == 3)
            {
                return new int[][] { new int[] { CorneredBlur(image, (ZERO, ZERO)) } };
            }
            else if(image.Length == 4 && image[0].Length == 3 || image.Length == 3 && image[0].Length == 4)
            {
                return new int[][] { new int[] { CorneredBlur(image, (ZERO, ZERO)), CorneredBlur(image, (ZERO, xLimit - 2)) } };
            }
            else
            {
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
                new int[] { 0, 18, 9},
                new int[] { 27, 9, 0},
                new int[] { 81, 63, 45}
            };

            int[][] d = {
                new int[] { 36, 0, 18, 9},
                new int[] { 27, 54, 9, 0},
                new int[] { 81, 63, 72, 45}
            };
            int[][] e = { 
                new int[] { 7, 4, 0, 1},
                new int[] { 5, 6, 2, 2},
                new int[] { 6, 10, 7, 8},
                new int[] { 1, 4, 2, 0}
            };
            int[][] f = {
                new int[] { 36, 0, 18, 9, 9, 45, 27},
                new int[] { 27, 0, 54, 9, 0, 63, 90},
                new int[] { 81, 63, 72, 45, 18, 27, 0},
                new int[] { 0, 0, 9, 81, 27, 18, 45},
                new int[] { 45, 45, 27, 27, 90, 81, 72},
                new int[] { 45, 18, 9, 0, 9, 18, 45},
                new int[] { 27, 81, 36, 63, 63, 72, 81}
            };
            int[][] g = {
                new int[] { 36, 0, 18, 9, 9, 45, 27},
                new int[] { 27, 0, 254, 9, 0, 63, 90},
                new int[] { 81, 255, 72, 45, 18, 27, 0},
                new int[] { 0, 0, 9, 81, 27, 18, 45},
                new int[] { 45, 45, 227, 227, 90, 81, 72},
                new int[] { 45, 18, 9, 255, 9, 18, 45},
                new int[] { 27, 81, 36, 127, 255, 72, 81}
            };
            Console.WriteLine(" b: " + a.printMatrix(a.BoxBlur(b)));
            Console.WriteLine(" c: " + a.printMatrix(a.BoxBlur(c)));
            Console.WriteLine(" d: " + a.printMatrix(a.BoxBlur(d)));
            Console.WriteLine(" e: " + a.printMatrix(a.BoxBlur(e)));
            Console.WriteLine(" f: " + a.printMatrix(a.BoxBlur(f)));
            Console.WriteLine(" g: " + a.printMatrix(a.BoxBlur(g)));
        }
    }
}
