namespace MatrixElementsSum
{
    internal class Program
    {
        int MatrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix[0].Length; i++)
            {
                bool haunted = false;
                for (int j = 0; j < matrix.Length; j++)
                {
                    if(matrix[j][i] != 0 && !haunted)
                    {
                        sum += matrix[j][i];
                    }
                    else
                    {
                        haunted = true;
                    }
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[][] b = [ 
                [0, 1, 1, 2],
                [0, 5, 0, 0],
                [2, 0, 3, 3]
            ];
            int[][] c = [
                [1, 1, 1, 0],
                [0, 5, 0, 1],
                [2, 1, 3, 10]
            ];
            Console.WriteLine("result: " + a.MatrixElementsSum(b));
            Console.WriteLine("result: " + a.MatrixElementsSum(c));
        }
    }
}
