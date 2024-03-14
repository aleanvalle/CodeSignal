namespace ChessKnight.Test
{
    public class UnitTest1
    {
        ChessKnight.Program program = new ChessKnight.Program();
        string cell = "";
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            cell = "a1";
            expectedValue = 2;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            cell = "c2";
            expectedValue = 6;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            cell = "d4";
            expectedValue = 8;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            cell = "g6";
            expectedValue = 6;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            cell = "a3";
            expectedValue = 4;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            cell = "b7";
            expectedValue = 4;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            cell = "h8";
            expectedValue = 2;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            cell = "h6";
            expectedValue = 4;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            cell = "g8";
            expectedValue = 3;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            cell = "a5";
            expectedValue = 4;
            actualValue = program.ChessKnight(cell);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}