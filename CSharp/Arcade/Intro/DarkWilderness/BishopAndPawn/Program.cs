namespace BishopAndPawn
{
    public class Program
    {
        Dictionary<char, int> chessColumnsToInt = new Dictionary<char, int>()
        {
            { 'a', 0 },
            { 'b', 1 },
            { 'c', 2 },
            { 'd', 3 },
            { 'e', 4 },
            { 'f', 5 },
            { 'g', 6 },
            { 'h', 7 },
        };

        Dictionary<char, int> chessRowsToInt = new Dictionary<char, int>()
        {
            { '1', 0 },
            { '2', 1 },
            { '3', 2 },
            { '4', 3 },
            { '5', 4 },
            { '6', 5 },
            { '7', 6 },
            { '8', 7 },
        };

        Dictionary<int, char> IntToChessColumns = new Dictionary<int, char>()
        {
            { 0, 'a' },
            { 1, 'b' },
            { 2, 'c' },
            { 3, 'd' },
            { 4, 'e' },
            { 5, 'f' },
            { 6, 'g' },
            { 7, 'h' },
        };

        Dictionary<int, char> IntToChessRows = new Dictionary<int, char>()
        {
            { 0, '1' },
            { 1, '2' },
            { 2, '3' },
            { 3, '4' },
            { 4, '5' },
            { 5, '6' },
            { 6, '7' },
            { 7, '8' },
        };

        int GetIntColumn(char c)
        {
            return chessColumnsToInt[c];
        }

        int GetIntRow(char c)
        {
            return chessRowsToInt[c];
        }

        char GetChessColumn(int i)
        {
            return IntToChessColumns[i];
        }

        char GetChessRow(int i)
        {
            return IntToChessRows[i];
        }

        bool CanAdvanceLeft(string bishop)
        {
            return GetIntColumn(bishop[0]) - 1 > 0 && GetIntRow(bishop[1]) + 1 < 8;
        }

        bool CanAdvanceRight(string bishop)
        {
            return GetIntColumn(bishop[0]) + 1 < 8 && GetIntRow(bishop[1]) + 1 < 8;
        }

        bool CanRetreatLeft(string bishop)
        {
            return GetIntColumn(bishop[0]) - 1 > 0 && GetIntRow(bishop[1]) - 1 > 0;
        }

        bool CanRetreatRight(string bishop)
        {
            return GetIntColumn(bishop[0]) + 1 < 8 && GetIntRow(bishop[1]) - 1 > 0;
        }

        string AdvanceLeft(string bishop)
        {
            return (GetChessColumn(GetIntColumn(bishop[0]) - 1) + GetChessRow(GetIntRow(bishop[1]) + 1)).ToString();
        }

        string AdvanceRight(string bishop)
        {
            return (GetChessColumn(GetIntColumn(bishop[0]) + 1) + GetChessRow(GetIntRow(bishop[1]) + 1)).ToString();
        }

        string RetreatLeft(string bishop)
        {
            return (GetChessColumn(GetIntColumn(bishop[0]) - 1) + GetChessRow(GetIntRow(bishop[1]) - 1)).ToString();
        }

        string RetreatRight(string bishop)
        {
            return (GetChessColumn(GetIntColumn(bishop[0]) + 1) + GetChessRow(GetIntRow(bishop[1]) - 1)).ToString();
        }

        void Attack(string bishop, string pawn, bool captured)
        {
            string originalBishopPosition = bishop;
            while (CanAdvanceRight(bishop))
            {
                if (AdvanceRight(bishop).Equals(pawn))
                {
                    captured = true;
                    break;
                }
                else
                {
                    bishop = AdvanceRight(bishop);
                }
            }
            bishop = originalBishopPosition;
            while (CanAdvanceLeft(bishop) && !captured)
            {
                if (AdvanceLeft(bishop).Equals(pawn))
                {
                    captured = true;
                    break;
                }
                else
                {
                    bishop = AdvanceLeft(bishop);
                }
            }
            bishop = originalBishopPosition;
            while (CanRetreatRight(bishop) && !captured)
            {
                if (RetreatRight(bishop).Equals(pawn))
                {
                    captured = true;
                    break;
                }
                else
                {
                    bishop = RetreatRight(bishop);
                }
            }
            bishop = originalBishopPosition;
            while (CanRetreatLeft(bishop) && !captured)
            {
                if (RetreatLeft(bishop).Equals(pawn))
                {
                    captured = true;
                    break;
                }
                else
                {
                    bishop = RetreatLeft(bishop);
                }
            }
            return;
        }

        public bool BishopAndPawn(string bishop, string pawn)
        {
            if(bishop[0] == pawn[0] || bishop[1] == pawn[1])
            {
                return false;
            }
            else
            {
                bool captured = false;
                Attack(bishop, pawn, captured);
                return captured;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
