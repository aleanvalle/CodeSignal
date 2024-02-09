using System.Drawing;

namespace Minesweeper
{
    internal class Program
    {
        enum Position : int
        {
            LeftUpperCorner = 0,
            RightUpperCorner = 1,
            LeftLowerCorner = 2,
            RightLowerCorner = 3,
            Ceiling = 4,
            Floor = 5,
            LeftWall = 6,
            RightWall = 7,
            Free = 8
        }

        Position DefinePosition(int rowLimit, int colLimit, (int,int) coordinate)
        {
            if(coordinate.Item1 == 0 && coordinate.Item2 == 0)
            {
                return Position.LeftUpperCorner; //LeftUpperCorner
            }
            else if(coordinate.Item1 == 0 && coordinate.Item2 == colLimit)
            {
                return Position.RightUpperCorner; //RightUpperCorner
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == 0)
            {
                return Position.LeftLowerCorner; //LeftLowerCorner
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == colLimit)
            {
                return Position.RightLowerCorner; //RightLowerCorner
            }
            else if(coordinate.Item1 == 0 && coordinate.Item2 < colLimit)
            {
                return Position.Ceiling; //Ceiling
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 < colLimit)
            {
                return Position.Floor; //Floor
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == 0)
            {
                return Position.LeftWall; //LeftWall
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == colLimit)
            {
                return Position.RightWall; //RightWall
            }
            else
            {
                return Position.Free; //Free
            }
        }

        int MineCounter(bool[][] matrix, Position option, (int,int) coordinate)
        {
            List<bool> mineCounts = new List<bool>();
            if(option == Position.LeftUpperCorner)
            {
                mineCounts.Add(matrix[coordinate.Item1 + 1][coordinate.Item2]);
                mineCounts.Add(matrix[coordinate.Item1 + 1][coordinate.Item2 + 1]);
                mineCounts.Add(matrix[coordinate.Item1][coordinate.Item2 + 1]);
            }
            else if(option == Position.RightUpperCorner)
            {
                mineCounts.Add(matrix[coordinate.Item1 - 1][coordinate.Item2]);
                mineCounts.Add(matrix[coordinate.Item1 - 1][coordinate.Item2 - 1]);
                mineCounts.Add(matrix[coordinate.Item1][coordinate.Item2 - 1]);
            }
            else if(option == Position.LeftLowerCorner)
            {
                mineCounts.Add(matrix[coordinate.Item1 + 1][coordinate.Item2]);
                mineCounts.Add(matrix[coordinate.Item1 + 1][coordinate.Item2 - 1]);
                mineCounts.Add(matrix[coordinate.Item1][coordinate.Item2 - 1]);
            }
            //all other options here...
            return mineCounts.Count(b => b);
        }

        int[][] Minesweeper(bool[][] matrix)
        {
            return new int[1][];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
