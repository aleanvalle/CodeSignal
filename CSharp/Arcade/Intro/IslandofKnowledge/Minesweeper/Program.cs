namespace Minesweeper
{
    internal class Program
    {
        Dictionary<string, Dictionary<string, int>> DirectionsGenerator(Dictionary<string, int> coordinate)
        {
            Dictionary<string, int> east = new Dictionary<string, int> 
            {
                { "col", coordinate["col"] + 1 },
                { "row", coordinate["row"]     }
            };
            Dictionary<string, int> southEast = new Dictionary<string, int>
            {
                { "col", coordinate["col"] + 1 },
                { "row", coordinate["row"] + 1 }
            };
            Dictionary<string, int> south = new Dictionary<string, int>
            {
                { "col", coordinate["col"]     },
                { "row", coordinate["row"] + 1 }
            };
            Dictionary<string, int> southWest = new Dictionary<string, int>
            {
                { "col", coordinate["col"] - 1 },
                { "row", coordinate["row"] + 1 }
            };
            Dictionary<string, int> west = new Dictionary<string, int>
            {
                { "col", coordinate["col"] - 1 },
                { "row", coordinate["row"]     }
            };
            Dictionary<string, int> northWest = new Dictionary<string, int>
            {
                { "col", coordinate["col"] - 1 },
                { "row", coordinate["row"] - 1 }
            };
            Dictionary<string, int> north = new Dictionary<string, int>
            {
                { "col", coordinate["col"]     },
                { "row", coordinate["row"] - 1 }
            };
            Dictionary<string, int> northEast = new Dictionary<string, int>
            {
                { "col", coordinate["col"] + 1 },
                { "row", coordinate["row"] - 1 }
            };
            return new Dictionary<string, Dictionary<string, int>>
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
            Dictionary<string, Dictionary<string, int>> directionsGenerator = DirectionsGenerator(coordinate);
            if (coordinate["col"] == 0 && coordinate["row"] == 0) //LeftUpperCorner
            {
                adjacentPositions.AddRange(new List<bool>
                { 
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]],
                    matrix[directionsGenerator["southEast"]["row"]][directionsGenerator["southEast"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]]
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] == 0) //RightUpperCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]],
                    matrix[directionsGenerator["southWest"]["row"]][directionsGenerator["southWest"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]]
                });
            }
            else if(coordinate["col"] == 0 && coordinate["row"] == rowLimit) //LeftLowerCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[directionsGenerator["northEast"]["row"]][directionsGenerator["northEast"]["col"]],
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]]
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] == rowLimit) //RightLowerCorner
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[directionsGenerator["northWest"]["row"]][directionsGenerator["northWest"]["col"]],
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]]
                });
            }
            else if(coordinate["col"] < colLimit && coordinate["row"] == 0) //Ceiling
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]],
                    matrix[directionsGenerator["southWest"]["row"]][directionsGenerator["southWest"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]],
                    matrix[directionsGenerator["southEast"]["row"]][directionsGenerator["southEast"]["col"]],
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]],
                });
            }
            else if(coordinate["col"] < colLimit && coordinate["row"] == rowLimit) //Floor
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]],
                    matrix[directionsGenerator["northWest"]["row"]][directionsGenerator["northWest"]["col"]],
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[directionsGenerator["northEast"]["row"]][directionsGenerator["northEast"]["col"]],
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]],
                });
            }
            else if(coordinate["col"] == 0 && coordinate["row"] < rowLimit) //LeftWall
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[directionsGenerator["northEast"]["row"]][directionsGenerator["northEast"]["col"]],
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]],
                    matrix[directionsGenerator["southEast"]["row"]][directionsGenerator["southEast"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]],
                });
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] < rowLimit) //RightWall
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[directionsGenerator["northWest"]["row"]][directionsGenerator["northWest"]["col"]],
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]],
                    matrix[directionsGenerator["southWest"]["row"]][directionsGenerator["southWest"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]],
                });
            }
            else //Free
            {
                adjacentPositions.AddRange(new List<bool>
                {
                    matrix[directionsGenerator["northWest"]["row"]][directionsGenerator["northWest"]["col"]],
                    matrix[directionsGenerator["northEast"]["row"]][directionsGenerator["northEast"]["col"]],
                    matrix[    directionsGenerator["north"]["row"]][    directionsGenerator["north"]["col"]],
                    matrix[     directionsGenerator["west"]["row"]][     directionsGenerator["west"]["col"]],
                    matrix[     directionsGenerator["east"]["row"]][     directionsGenerator["east"]["col"]],
                    matrix[    directionsGenerator["south"]["row"]][    directionsGenerator["south"]["col"]],
                    matrix[directionsGenerator["southEast"]["row"]][directionsGenerator["southEast"]["col"]],
                    matrix[directionsGenerator["southWest"]["row"]][directionsGenerator["southWest"]["col"]]
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
            PrettyMultiArray.Program prettyMultiArray = new PrettyMultiArray.Program();
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
            Console.WriteLine("b: " + prettyMultiArray.PrintMatrix(a.Minesweeper(b)));
            Console.WriteLine("c: " + prettyMultiArray.PrintMatrix(a.Minesweeper(c)));
            Console.WriteLine("d: " + prettyMultiArray.PrintMatrix(a.Minesweeper(d)));
            Console.WriteLine("e: " + prettyMultiArray.PrintMatrix(a.Minesweeper(e)));
            Console.WriteLine("f: " + prettyMultiArray.PrintMatrix(a.Minesweeper(f)));
            Console.WriteLine("g: " + prettyMultiArray.PrintMatrix(a.Minesweeper(g)));
        }
    }
}
