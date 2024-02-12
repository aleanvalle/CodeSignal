namespace Minesweeper
{
    internal class Program
    {
        string printMatrix(int[][] arr)
        {
            int rowLength = arr.Length;
            int colLength = arr[0].Length;
            Console.Write("[");
            for (int i = 0; i < rowLength; i++)
            {
                Console.Write("[");
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}", arr[i][j]));
                    if (j + 1 != colLength)
                    {
                        Console.Write(",");
                    }
                    else
                    {
                        Console.Write("]\n");
                    }
                }
            }
            Console.Write("]");
            return "end";
        }

        Dictionary<string, (int, int)> DirectionsGenerator(Dictionary<string, int> coordinate)
        {
            (int, int) east      = (coordinate["col"] + 1, coordinate["row"]    );
            (int, int) southEast = (coordinate["col"] + 1, coordinate["row"] + 1);
            (int, int) south     = (coordinate["col"]    , coordinate["row"] + 1);
            (int, int) southWest = (coordinate["col"] - 1, coordinate["row"] + 1);
            (int, int) west      = (coordinate["col"] - 1, coordinate["row"]    );
            (int, int) northWest = (coordinate["col"] - 1, coordinate["row"] - 1);
            (int, int) north     = (coordinate["col"]    , coordinate["row"] - 1);
            (int, int) northEast = (coordinate["col"] + 1, coordinate["row"] - 1);
            return new Dictionary<string, (int, int)>
            {
                { "east"     , east      },
                { "southEast", southEast },
                { "south"    , south     },
                { "southWest", southWest },
                { "west"     , west      },
                { "northWest", northWest },
                { "north"    , north     },
                { "northEast", northEast },
            };
        }

        int MineCounter(bool[][] matrix, Dictionary<string, int> coordinate)
        {
            List<bool> adjacentPositions = new List<bool>();
            int rowLimit = matrix.Length - 1;
            int colLimit = matrix[0].Length - 1;
            Dictionary<string, (int, int)> directionsGenerator = DirectionsGenerator(coordinate);
            if (coordinate["col"] == 0 && coordinate["row"] == 0) //LeftUpperCorner
            {
                adjacentPositions.AddRange(new List<bool>
                { 
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2],
                    matrix[directionsGenerator["southEast"].Item1][directionsGenerator["southEast"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2]
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] == 0) //RightUpperCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2],
                    matrix[directionsGenerator["southWest"].Item1][directionsGenerator["southWest"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2]
                });
            }
            else if(coordinate["col"] == 0 && coordinate["row"] == rowLimit) //LeftLowerCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[directionsGenerator["northEast"].Item1][directionsGenerator["northEast"].Item2],
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2]
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] == rowLimit) //RightLowerCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[directionsGenerator["northWest"].Item1][directionsGenerator["northWest"].Item2],
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2]
                });
            }
            else if(coordinate["col"] < colLimit && coordinate["row"] == 0) //Ceiling
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2],
                    matrix[directionsGenerator["southWest"].Item1][directionsGenerator["southWest"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2],
                    matrix[directionsGenerator["southEast"].Item1][directionsGenerator["southEast"].Item2],
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2],
                });
            }
            else if(coordinate["col"] < colLimit && coordinate["row"] == rowLimit) //Floor
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2],
                    matrix[directionsGenerator["northWest"].Item1][directionsGenerator["northWest"].Item2],
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[directionsGenerator["northEast"].Item1][directionsGenerator["northEast"].Item2],
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2],
                });
            }
            else if(coordinate["col"] == 0 && coordinate["row"] < rowLimit) //LeftWall
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[directionsGenerator["northEast"].Item1][directionsGenerator["northEast"].Item2],
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2],
                    matrix[directionsGenerator["southEast"].Item1][directionsGenerator["southEast"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2],
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] < rowLimit) //RightWall
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[directionsGenerator["northWest"].Item1][directionsGenerator["northWest"].Item2],
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2],
                    matrix[directionsGenerator["southWest"].Item1][directionsGenerator["southWest"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2],
                });
            }
            else //Free
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[directionsGenerator["northWest"].Item1][directionsGenerator["northWest"].Item2],
                    matrix[directionsGenerator["northEast"].Item1][directionsGenerator["northEast"].Item2],
                    matrix[    directionsGenerator["north"].Item1][    directionsGenerator["north"].Item2],
                    matrix[     directionsGenerator["west"].Item1][     directionsGenerator["west"].Item2],
                    matrix[     directionsGenerator["east"].Item1][     directionsGenerator["east"].Item2],
                    matrix[    directionsGenerator["south"].Item1][    directionsGenerator["south"].Item2],
                    matrix[directionsGenerator["southEast"].Item1][directionsGenerator["southEast"].Item2],
                    matrix[directionsGenerator["southWest"].Item1][directionsGenerator["southWest"].Item2]
                });
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
                    var coordinate = new Dictionary<string, int> { { "col", col }, { "row", row } };
                    minesweeper[row].Add(MineCounter(matrix, coordinate));
                }
            }
            return minesweeper.Select(l => l.ToArray()).ToArray();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            bool[][] b = [
                [true, false, false],
                [false, true, false],
                [false, false, false]
            ];
            bool[][] c = [
                [false, false, false],
                [false, false, false]
            ];
            bool[][] d = [
                [true, false, false, true],
                [false, false, true, false],
                [true, true, false, true]
            ];
            bool[][] e = [
                [true, true, true],
                [true, true, true],
                [true, true, true]
            ];
            bool[][] f = [
                [false, true, true, false],
                [true, true, false, true],
                [false, false, true, false]
            ];
            bool[][] g = [
                [true, false],
                [true, false],
                [false, true],
                [false, false],
                [false, false]
            ];
            Console.WriteLine("b: " + a.printMatrix(a.Minesweeper(b)));
            Console.WriteLine("c: " + a.printMatrix(a.Minesweeper(c)));
            Console.WriteLine("d: " + a.printMatrix(a.Minesweeper(d)));
            Console.WriteLine("e: " + a.printMatrix(a.Minesweeper(e)));
            Console.WriteLine("f: " + a.printMatrix(a.Minesweeper(f)));
            Console.WriteLine("g: " + a.printMatrix(a.Minesweeper(g)));
        }
    }
}
