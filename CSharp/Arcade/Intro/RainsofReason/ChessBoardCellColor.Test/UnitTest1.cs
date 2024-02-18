namespace ChessBoardCellColor.Test
{
    public class UnitTest1
    {
        ChessBoardCellColor.Program chessBoardCellColor = new ChessBoardCellColor.Program();
        Dictionary<string, List<string>> cellPairs;

        public UnitTest1()
        {
            cellPairs = new Dictionary<string,List<string>>()
            {
                { "test1", new List<string>() { "A1", "C3" } },
                { "test2", new List<string>() { "A1", "H3" } },
                { "test3", new List<string>() { "A1", "A2" } },
                { "test4", new List<string>() { "A1", "B2" } },
                { "test5", new List<string>() { "B3", "H8" } },
                { "test6", new List<string>() { "C3", "B5" } },
                { "test7", new List<string>() { "G5", "E7" } },
                { "test8", new List<string>() { "C8", "H8" } },
                { "test9", new List<string>() { "D2", "D2" } },
                {"test10", new List<string>() { "A2", "A5" } }
            };
        }

        [Fact]
        public void Test1()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test1"][0], cellPairs["test1"][1]);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test2"][0], cellPairs["test2"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test3"][0], cellPairs["test3"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test4"][0], cellPairs["test4"][1]);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test5"][0], cellPairs["test5"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test6"][0], cellPairs["test6"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test7"][0], cellPairs["test7"][1]);
            Assert.Equal(expectedValue, actualValue);
        }
        
        [Fact]
        public void Test8()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test8"][0], cellPairs["test8"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test9"][0], cellPairs["test9"][1]);
            Assert.Equal(expectedValue, actualValue);
        }


        [Fact]
        public void Test10()
        {
            bool expectedValue = true;
            bool actualValue = chessBoardCellColor.ChessBoardCellColor(cellPairs["test10"][0], cellPairs["test10"][1]);
            Assert.NotEqual(expectedValue, actualValue);
        }

    }
}