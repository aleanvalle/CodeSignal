namespace SpiralNumbers
{
    public class Program
    {
        int[][] RectangularArrayForJaggedArray(int n)
        {
            int[][] jaggedArrayAsRectangularArray = new int[n][];
            for (int row=0; row < jaggedArrayAsRectangularArray.Length; row++)
            {
                jaggedArrayAsRectangularArray[row] = new int[n];
            }
            return jaggedArrayAsRectangularArray;
        }

        public int[][] SpiralNumbers(int n)
        {
            int[][] spiralNumbers = RectangularArrayForJaggedArray(n);
            int rowLength = n;
            int colLength = n;
            int currentRow = 0;
            int currentCol = 0;
            int step = 1;
            while(currentRow < rowLength && currentCol < colLength)
            {
                for(int col = currentCol; col < colLength; col++)
                {
                    spiralNumbers[currentRow][col] = step;
                    step++;
                }
                currentRow++;
                for(int row = currentRow; row < rowLength; row++)
                {
                    spiralNumbers[row][colLength - 1] = step;
                    step++;
                }
                colLength--;
                for(int col = colLength - 1; col >= currentCol; col--)
                {
                    spiralNumbers[rowLength - 1][col] = step;
                    step++;
                }
                rowLength--;
                for(int row = rowLength - 1; row >= currentRow; row--)
                {
                    spiralNumbers[row][currentCol] = step;
                    step++;
                }
                currentCol++;
            }
            return spiralNumbers;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
