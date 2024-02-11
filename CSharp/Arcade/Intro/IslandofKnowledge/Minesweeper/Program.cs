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

        List<bool> AddMines(bool[][] matrix, Dictionary<string, (int, int)> arrangement)
        {
            List<bool> positions = new List<bool>();
            foreach (var adjacentPos in arrangement)
            {
                positions.Add(matrix[adjacentPos.Value.Item1][adjacentPos.Value.Item2]);
            }
            return positions;
        }

        Dictionary<string, Dictionary<string, (int, int)>> MinesLocator(Dictionary<string, int> coordinate)
        {
            (int, int) east      = (coordinate["col"] + 1, coordinate["row"]    );
            (int, int) southEast = (coordinate["col"] + 1, coordinate["row"] + 1);
            (int, int) south     = (coordinate["col"]    , coordinate["row"] + 1);
            (int, int) southWest = (coordinate["col"] - 1, coordinate["row"] + 1);
            (int, int) west      = (coordinate["col"] - 1, coordinate["row"]    );
            (int, int) northWest = (coordinate["col"] - 1, coordinate["row"] - 1);
            (int, int) north     = (coordinate["col"]    , coordinate["row"] - 1);
            (int, int) northEast = (coordinate["col"] + 1, coordinate["row"] - 1);
            Dictionary<string, Dictionary<string, (int, int)>> positions = new Dictionary<string, Dictionary<string, (int, int)>>()
            {
                { "LeftUpperCorner", new Dictionary<string, (int, int)>
                    {
                        { "East"     , east     }, 
                        { "Southeast", southEast},
                        { "South"    , south    }
                    }
                },
                { "RightUpperCorner", new Dictionary<string, (int, int)>
                    {
                        { "West"     , west     },
                        { "Southwest", southWest},
                        { "South"    , south    }
                    }
                },
                { "LeftLowerCorner", new Dictionary<string, (int, int)>
                    {
                        { "North"    , north    },
                        { "Northeast", northEast},
                        { "East"     , east     }
                    }
                },
                { "RightLowerCorner", new Dictionary<string, (int, int)>
                    {
                        { "North"    , north    },
                        { "Northwest", northWest},
                        { "West"     , west     }
                    }
                },
                { "Ceiling", new Dictionary<string, (int, int)>
                    {
                        { "West"     , west     },
                        { "Southwest", southWest},
                        { "South"    , south    },
                        { "Southeast", southEast},
                        { "East"     , east     }
                    }
                },
                { "Floor", new Dictionary<string, (int, int)>
                    {
                        { "East"     , east     },
                        { "Northeast", northEast},
                        { "North"    , north    },
                        { "Northwest", northWest},
                        { "West"     , west     }
                    }
                },
                { "LeftWall", new Dictionary<string, (int, int)>
                    {
                        { "North"    , north    },
                        { "Northeast", northEast},
                        { "East"     , east     },
                        { "Southeast", southEast},
                        { "South"    , south    }
                    }
                },
                { "RightWall", new Dictionary<string, (int, int)>
                    {
                        { "South"    , south    },
                        { "Southwest", southWest},
                        { "West"     , west     },
                        { "Northwest", northWest},
                        { "North"    , north    }
                    }
                },
                { "Free", new Dictionary<string, (int, int)>
                    {
                        { "Northwest", northWest},
                        { "North"    , north    },
                        { "Northeast", northEast},
                        { "West"     , west     },
                        { "East"     , east     },
                        { "Southwest", southWest},
                        { "South"    , south    },
                        { "Southeast", southEast}
                    }
                },
            };
            return positions;
        }

        int MineCounter(bool[][] matrix, Dictionary<string, int> coordinate)
        {
            List<bool> adjacentPositions;
            int rowLimit = matrix.Length - 1;
            int colLimit = matrix[0].Length - 1;
            Dictionary<string, Dictionary<string, (int, int)>> minesLocator = MinesLocator(coordinate);
            if (coordinate["col"] == 0 && coordinate["row"] == 0) //LeftUpperCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator["LeftUpperCorner"]);    
            }
            else if(coordinate["col"] == colLimit && coordinate["row"] == 0) //RightUpperCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator["RightUpperCorner"]);
            }//fix below...
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == 0) //LeftLowerCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator["LeftLowerCorner"]);
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 == colLimit) //RightLowerCorner
            {
                adjacentPositions = AddMines(matrix, minesLocator["RightLowerCorner"]);
            }
            else if(coordinate.Item1 == 0 && coordinate.Item2 < colLimit) //Ceiling
            {
                adjacentPositions = AddMines(matrix, minesLocator["Ceiling"]);
            }
            else if(coordinate.Item1 == rowLimit && coordinate.Item2 < colLimit) //Floor
            {
                adjacentPositions = AddMines(matrix, minesLocator["Floor"]);
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == 0) //LeftWall
            {
                adjacentPositions = AddMines(matrix, minesLocator["LeftWall"]);
            }
            else if(coordinate.Item1 < rowLimit && coordinate.Item2 == colLimit) //RightWall
            {
                adjacentPositions = AddMines(matrix, minesLocator["RightWall"]);
            }
            else //Free
            {
                adjacentPositions = AddMines(matrix, minesLocator["Free"]);
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
