namespace ChessBoardCellColor
{
    public class Program
    {
        static List<char> horizontalAxis = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        static List<char> verticalAxis = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8' };
        static string BLACK = "Black";
        static string WHITE = "White";
        static Dictionary<char, Dictionary<char, string>> chessBoard = new Dictionary<char, Dictionary<char, string>>()
        {
            {   horizontalAxis[0], new Dictionary<char, string>()
                {   
                    { verticalAxis[0], BLACK },
                    { verticalAxis[1], WHITE }, 
                    { verticalAxis[2], BLACK }, 
                    { verticalAxis[3], WHITE }, 
                    { verticalAxis[4], BLACK }, 
                    { verticalAxis[5], WHITE }, 
                    { verticalAxis[6], BLACK }, 
                    { verticalAxis[7], WHITE }, 
                }
            },
            {   horizontalAxis[1], new Dictionary<char, string>()
                {
                    { verticalAxis[0], WHITE },
                    { verticalAxis[1], BLACK },
                    { verticalAxis[2], WHITE },
                    { verticalAxis[3], BLACK },
                    { verticalAxis[4], WHITE },
                    { verticalAxis[5], BLACK },
                    { verticalAxis[6], WHITE },
                    { verticalAxis[7], BLACK },
                }
            },
            {   horizontalAxis[2], new Dictionary<char, string>()
                {
                    { verticalAxis[0], BLACK },
                    { verticalAxis[1], WHITE },
                    { verticalAxis[2], BLACK },
                    { verticalAxis[3], WHITE },
                    { verticalAxis[4], BLACK },
                    { verticalAxis[5], WHITE },
                    { verticalAxis[6], BLACK },
                    { verticalAxis[7], WHITE },
                }
            },
            {   horizontalAxis[3], new Dictionary<char, string>()
                {
                    { verticalAxis[0], WHITE },
                    { verticalAxis[1], BLACK },
                    { verticalAxis[2], WHITE },
                    { verticalAxis[3], BLACK },
                    { verticalAxis[4], WHITE },
                    { verticalAxis[5], BLACK },
                    { verticalAxis[6], WHITE },
                    { verticalAxis[7], BLACK },
                }
            },
            {   horizontalAxis[4], new Dictionary<char, string>()
                {
                    { verticalAxis[0], BLACK },
                    { verticalAxis[1], WHITE },
                    { verticalAxis[2], BLACK },
                    { verticalAxis[3], WHITE },
                    { verticalAxis[4], BLACK },
                    { verticalAxis[5], WHITE },
                    { verticalAxis[6], BLACK },
                    { verticalAxis[7], WHITE },
                }
            },
            {   horizontalAxis[5], new Dictionary<char, string>()
                {
                    { verticalAxis[0], WHITE },
                    { verticalAxis[1], BLACK },
                    { verticalAxis[2], WHITE },
                    { verticalAxis[3], BLACK },
                    { verticalAxis[4], WHITE },
                    { verticalAxis[5], BLACK },
                    { verticalAxis[6], WHITE },
                    { verticalAxis[7], BLACK },
                }
            },
            {   horizontalAxis[6], new Dictionary<char, string>()
                {
                    { verticalAxis[0], BLACK },
                    { verticalAxis[1], WHITE },
                    { verticalAxis[2], BLACK },
                    { verticalAxis[3], WHITE },
                    { verticalAxis[4], BLACK },
                    { verticalAxis[5], WHITE },
                    { verticalAxis[6], BLACK },
                    { verticalAxis[7], WHITE },
                }
            },
            {   horizontalAxis[7], new Dictionary<char, string>()
                {
                    { verticalAxis[0], WHITE },
                    { verticalAxis[1], BLACK },
                    { verticalAxis[2], WHITE },
                    { verticalAxis[3], BLACK },
                    { verticalAxis[4], WHITE },
                    { verticalAxis[5], BLACK },
                    { verticalAxis[6], WHITE },
                    { verticalAxis[7], BLACK },
                }
            }
        };

        bool CellsAreTheSameColor(char cell1_horizontal, char cell1_vertical, char cell2_horizontal, char cell2_vertical)
        {
            return string.Equals(chessBoard[cell1_horizontal][cell1_vertical], chessBoard[cell2_horizontal][cell2_vertical]);
        }

        public bool ChessBoardCellColor(string cell1, string cell2)
        {
            char cell1_horizontal = cell1.ToLower().ToCharArray()[0];
            char cell1_vertical = cell1.ToLower().ToCharArray()[1];
            char cell2_horizontal = cell2.ToLower().ToCharArray()[0];
            char cell2_vertical = cell2.ToLower().ToCharArray()[1];
            return CellsAreTheSameColor(cell1_horizontal, cell1_vertical, cell2_horizontal, cell2_vertical);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
