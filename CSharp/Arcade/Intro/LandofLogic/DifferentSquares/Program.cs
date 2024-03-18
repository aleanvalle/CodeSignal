namespace DifferentSquares
{
    public class Program
    {
        public int DifferentSquares(int[][] matrix)
        {
            HashSet<string> squares = new HashSet<string>();
            string square = "";
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for(int col = 0; col < matrix[row].Length - 1; col++)
                {
                    square += matrix[row][col].ToString() + matrix[row][col + 1].ToString() + matrix[row + 1][col].ToString() + matrix[row + 1][col + 1].ToString();
                    squares.Add(square);
                    square = "";
                }
            }
            return squares.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
