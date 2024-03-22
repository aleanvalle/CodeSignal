namespace Sudoku
{
    public class Program
    {
        int VALID_SUDOKU = 45;
        int UNIQUE_AMOUNT = 9;

        bool ValidRowSum(int[][] grid)
        {
            int rowSum = 0;
            for (int row = 0; row < grid.Length; row++)
            {
                rowSum += grid[row][0] + grid[row][1] + grid[row][2] 
                        + grid[row][3] + grid[row][4] + grid[row][5] 
                        + grid[row][6] + grid[row][7] + grid[row][8];
                if(rowSum != VALID_SUDOKU)
                {
                    return false;
                }
                rowSum = 0;
            }
            return true;
        }

        bool ValidColSum(int[][] grid)
        {
            int colSum = 0;
            for (int col = 0; col < grid[0].Length; col++)
            {
                colSum += grid[0][col] + grid[1][col] + grid[2][col]
                        + grid[3][col] + grid[4][col] + grid[5][col]
                        + grid[6][col] + grid[7][col] + grid[8][col];
                if (colSum != VALID_SUDOKU)
                {
                    return false;
                }
                colSum = 0;
            }
            return true;
        }

        bool ValidSubgridSum(int[][] grid)
        {
            int sumSubgrids = 0;
            for (int row = 0; row < grid.Length - 2; row += 3)
            {
                for (int col = 0; col < grid[row].Length - 2; col += 3)
                {
                    sumSubgrids += grid[row][col]
                                + grid[row][col + 1] 
                                + grid[row][col + 2]
                                + grid[row + 1][col] 
                                + grid[row + 1][col + 1] 
                                + grid[row + 1][col + 2]
                                + grid[row + 2][col] 
                                + grid[row + 2][col + 1] 
                                + grid[row + 2][col + 2];
                    if (sumSubgrids != VALID_SUDOKU)
                    {
                        return false;
                    }
                    sumSubgrids = 0;
                }
            }
            return true;
        }

        bool RowIsUnique(int[][] grid)
        {
            HashSet<int> uniqueRow = new HashSet<int>();
            for (int row = 0; row < grid.Length; row++)
            {
                uniqueRow.Add(grid[row][0]);
                uniqueRow.Add(grid[row][1]);
                uniqueRow.Add(grid[row][2]);
                uniqueRow.Add(grid[row][3]); 
                uniqueRow.Add(grid[row][4]);  
                uniqueRow.Add(grid[row][5]);
                uniqueRow.Add(grid[row][6]);  
                uniqueRow.Add(grid[row][7]);  
                uniqueRow.Add(grid[row][8]);               
                if (uniqueRow.Count != UNIQUE_AMOUNT)
                {
                    return false;
                }
                uniqueRow.Clear();
            }
            return true;
        }

        bool ColIsUnique(int[][] grid)
        {
            HashSet<int> uniqueCol = new HashSet<int>();
            for (int col = 0; col < grid[0].Length; col++)
            {
                uniqueCol.Add(grid[0][col]);
                uniqueCol.Add(grid[1][col]);
                uniqueCol.Add(grid[2][col]);
                uniqueCol.Add(grid[3][col]);
                uniqueCol.Add(grid[4][col]);
                uniqueCol.Add(grid[5][col]);
                uniqueCol.Add(grid[6][col]);
                uniqueCol.Add(grid[7][col]);
                uniqueCol.Add(grid[8][col]);
                if (uniqueCol.Count != UNIQUE_AMOUNT)
                {
                    return false;
                }
                uniqueCol.Clear();
            }
            return true;
        }

        bool SubgridIsUnique(int[][] grid)
        {
            HashSet<int> uniqueSubgrid = new HashSet<int>();
            for (int row = 0; row < grid.Length - 2; row += 3)
            {
                for (int col = 0; col < grid[row].Length - 2; col += 3)
                {
                    uniqueSubgrid.Add(grid[row][col]);
                    uniqueSubgrid.Add(grid[row][col + 1]);
                    uniqueSubgrid.Add(grid[row][col + 2]);
                    uniqueSubgrid.Add(grid[row + 1][col]);
                    uniqueSubgrid.Add(grid[row + 1][col + 1]);
                    uniqueSubgrid.Add(grid[row + 1][col + 2]);
                    uniqueSubgrid.Add(grid[row + 2][col]);
                    uniqueSubgrid.Add(grid[row + 2][col + 1]);
                    uniqueSubgrid.Add(grid[row + 2][col + 2]);
                    if (uniqueSubgrid.Count != UNIQUE_AMOUNT)
                    {
                        return false;
                    }
                    uniqueSubgrid.Clear();
                }
            }
            return true;
        }

        public bool Sudoku(int[][] grid)
        {
            if (!ValidRowSum(grid)) return false; 
            if (!ValidColSum(grid)) return false;  
            if (!ValidSubgridSum(grid)) return false;
            if (!RowIsUnique(grid)) return false;
            if (!ColIsUnique(grid)) return false;
            if (!SubgridIsUnique(grid)) return false;
            else return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
