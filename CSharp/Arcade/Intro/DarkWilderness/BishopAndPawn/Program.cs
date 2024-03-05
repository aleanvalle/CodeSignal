namespace BishopAndPawn
{
    public class Program
    {
        Dictionary<char, int> chessColumnsAndRowsToInt = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'b', 1 },
            { 'c', 2 },
            { 'd', 3 },
            { 'e', 4 },
            { 'f', 5 },
            { 'g', 6 },
            { 'h', 7 },
            { '1', 0 },
            { '2', 1 },
            { '3', 2 },
            { '4', 3 },
            { '5', 4 },
            { '6', 5 },
            { '7', 6 },
            { '8', 7 },
        };

        int ConvertChessColumnOrRowToInt(char c)
        {
            return chessColumnsAndRowsToInt[c];
        }

        int ConvertToInitialPosition(int i)
        {
            return i - i;
        }

        public bool BishopAndPawn(string bishop, string pawn)
        {
            int chessBound = 8;
            int bishopColumn = ConvertChessColumnOrRowToInt(bishop[0]);
            int bishopRow = ConvertChessColumnOrRowToInt(bishop[1]);
            int pawnColumn = ConvertChessColumnOrRowToInt(pawn[0]);
            int pawnRow = ConvertChessColumnOrRowToInt(pawn[1]);
            if(bishopColumn == pawnColumn || bishopRow == pawnRow)
            {
                return false;
            }
            else
            {
                for(int i = ConvertToInitialPosition(bishopRow); i < chessBound; i++)
                {
                    //for(int j = ConvertToInitialPosition())
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
