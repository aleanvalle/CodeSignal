namespace Minesweeper
{
    internal class Program
    {
        struct MinesLocator((int, int) coordinate)
        {
            public List<(int, int)> LeftUpperCorner = new List<(int, int)>(){
                (coordinate.Item1 + 1, coordinate.Item2),
                (coordinate.Item1 + 1, coordinate.Item1 + 1),
                (coordinate.Item1, coordinate.Item2 + 1)};
            public List<(int, int)> RightUpperCorner = new List<(int, int)>(){
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 - 1),
                (coordinate.Item1, coordinate.Item2 + 1)};
            public List<(int, int)> LeftLowerCorner = new List<(int, int)>(){
                (coordinate.Item1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2)};
            public List<(int, int)> RightLowerCorner = new List<(int, int)>(){
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 - 1),
                (coordinate.Item1, coordinate.Item2 - 1)};
            public List<(int, int)> Ceiling = new List<(int, int)>(){
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 + 1),
                (coordinate.Item1, coordinate.Item2 + 1),
                (coordinate.Item1 + 1, coordinate.Item2 + 1),
                (coordinate.Item1 + 1, coordinate.Item2)};
            public List<(int, int)> Floor = new List<(int, int)>(){
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 - 1),
                (coordinate.Item1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2)};
            public List<(int, int)> LeftWall = new List<(int, int)>(){
                (coordinate.Item1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2),
                (coordinate.Item1 + 1, coordinate.Item2 + 1),
                (coordinate.Item1, coordinate.Item2 + 1)};
            public List<(int, int)> RightWall = new List<(int, int)>(){
                (coordinate.Item1, coordinate.Item2 - 1),
                (coordinate.Item1 - 1, coordinate.Item2 - 1),
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 + 1),
                (coordinate.Item1, coordinate.Item2 + 1)};
            public List<(int, int)> Free = new List<(int, int)>(){
                (coordinate.Item1 - 1, coordinate.Item2 - 1),
                (coordinate.Item1, coordinate.Item2 - 1),
                (coordinate.Item1 + 1, coordinate.Item2 - 1),
                (coordinate.Item1 - 1, coordinate.Item2),
                (coordinate.Item1 + 1, coordinate.Item2),
                (coordinate.Item1 - 1, coordinate.Item2 + 1),
                (coordinate.Item1, coordinate.Item2 + 1),
                (coordinate.Item1 + 1, coordinate.Item2 + 1)};
        }
        
        List<bool> AddMines(bool[][] matrix, List<(int,int)> arrangement)
        {
            List<bool> positions = new List<bool>();
            foreach ((int, int) adjacentPos in arrangement)
            {
                positions.Add(matrix[adjacentPos.Item1][adjacentPos.Item2]);
            }
            return positions;
        }

        int MineCounter(bool[][] matrix, (int,int) coordinate)
        {
            List<bool> adjacentPositions;
            int rowLimit = matrix.Length - 1;
            int colLimit = matrix[0].Length; 
            MinesLocator minesLocator = new MinesLocator(coordinate);
            if(coordinate.Item1 == 0 && coordinate.Item2 == 0) //LeftUpperCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator.LeftUpperCorner);    
            }
            else if(coordinate.Item1 == 0 && coordinate.Item2 == colLimit) //RightUpperCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator.RightUpperCorner);
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == 0) //LeftLowerCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator.LeftLowerCorner);
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == colLimit) //RightLowerCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator.RightLowerCorner);
            }
            else if(coordinate.Item1 == 0 && coordinate.Item2 < colLimit) //Ceiling
            {
                adjacentPositions = AddMines(matrix, minesLocator.Ceiling);
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 < colLimit) //Floor
            {
                adjacentPositions = AddMines(matrix, minesLocator.Floor);
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == 0) //LeftWall
            {
                adjacentPositions = AddMines(matrix, minesLocator.LeftWall);
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == colLimit) //RightWall
            {
                adjacentPositions = AddMines(matrix, minesLocator.RightWall);
            }
            else //Free
            {
                adjacentPositions = AddMines(matrix, minesLocator.Free);
            }
            return adjacentPositions.Count(b => b);
        }

        int[][] Minesweeper(bool[][] matrix)
        {
            List<List<int>> minesweeper = new List<List<int>>();
            for(int row = 0; row < matrix.Length; row++)
            {
                minesweeper.Add(new List<int>());
                for(int col = 0; col < matrix[row].Length; col++)
                {
                    minesweeper[row].Add(MineCounter(matrix, (row, col)));
                }
            }
            return minesweeper.Select(l => l.ToArray()).ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
