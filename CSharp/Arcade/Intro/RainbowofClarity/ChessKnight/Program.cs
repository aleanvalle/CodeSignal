namespace ChessKnight
{
    public class Program
    {
        int MATRIX_LOWER_LIMIT = 0;
        int MATRIX_UPPER_LIMIT = 7;
        Dictionary<char, int> chessPositionToMatrixPosition = new Dictionary<char, int>()
        {
            {'a', 0 },
            {'b', 1 },
            {'c', 2 },
            {'d', 3 },
            {'e', 4 },
            {'f', 5 },
            {'g', 6 },
            {'h', 7 },
            {'1', 0 },
            {'2', 1 },
            {'3', 2 },
            {'4', 3 },
            {'5', 4 },
            {'6', 5 },
            {'7', 6 },
            {'8', 7 },
        };

        bool CanAdvanceLeftWide(int col, int row)
        {
            return col - 2 >= MATRIX_LOWER_LIMIT && row + 1 <= MATRIX_UPPER_LIMIT;
        }

        bool CanAdvanceLeftNarrow(int col, int row)
        {
            return col - 1 >= MATRIX_LOWER_LIMIT && row + 2 <= MATRIX_UPPER_LIMIT;
        }

        bool CanAdvanceRightWide(int col, int row)
        {
            return col + 2 <= MATRIX_UPPER_LIMIT && row + 1 <= MATRIX_UPPER_LIMIT;
        }

        bool CanAdvanceRightNarrow(int col, int row)
        {
            return col + 1 <= MATRIX_UPPER_LIMIT && row + 2 <= MATRIX_UPPER_LIMIT;
        }

        bool CanRetreatLeftWide(int col, int row)
        {
            return col - 2 >= MATRIX_LOWER_LIMIT && row - 1 >= MATRIX_LOWER_LIMIT;
        }

        bool CanRetreatLeftNarrow(int col, int row)
        {
            return col - 1 >= MATRIX_LOWER_LIMIT && row - 2 >= MATRIX_LOWER_LIMIT;
        }

        bool CanRetreatRightWide(int col, int row)
        {
            return col + 2 <= MATRIX_UPPER_LIMIT && row - 1 >= MATRIX_LOWER_LIMIT;
        }

        bool CanRetreatRightNarrow(int col, int row)
        {
            return col + 1 <= MATRIX_UPPER_LIMIT && row - 2 >= MATRIX_LOWER_LIMIT;
        }

        public int ChessKnight(string cell)
        {
            int validMoves = 0;
            int column = chessPositionToMatrixPosition[cell[0]];
            int row = chessPositionToMatrixPosition[cell[1]];
            if(CanAdvanceLeftWide(column, row))
            {
                validMoves++;
            }
            if (CanAdvanceLeftNarrow(column, row))
            {
                validMoves++;
            }
            if (CanAdvanceRightWide(column, row))
            {
                validMoves++;
            }
            if (CanAdvanceRightNarrow(column, row))
            {
                validMoves++;
            }
            if (CanRetreatLeftWide(column, row))
            {
                validMoves++;
            }
            if (CanRetreatLeftNarrow(column, row))
            {
                validMoves++;
            }
            if (CanRetreatRightWide(column, row))
            {
                validMoves++;
            }
            if (CanRetreatRightNarrow(column, row))
            {
                validMoves++;
            }
            return validMoves;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
