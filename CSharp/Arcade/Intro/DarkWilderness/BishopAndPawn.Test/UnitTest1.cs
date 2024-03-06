namespace BishopAndPawn.Test
{
    public class UnitTest1
    {
        BishopAndPawn.Program program = new BishopAndPawn.Program();
        string bishop = "";
        string pawn = "";
        bool expectedValue;
        bool actualValue;

        [Fact]
        public void Test1()
        {
            bishop = "a1";
            pawn = "c3";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            bishop = "h1";
            pawn = "h3";
            expectedValue = false;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            bishop = "a5";
            pawn = "c3";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            bishop = "g1";
            pawn = "f3";
            expectedValue = false;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            bishop = "e7";
            pawn = "d6";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            bishop = "e7";
            pawn = "a3";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            bishop = "e3";
            pawn = "a7";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            bishop = "a1";
            pawn = "h8";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            bishop = "a1";
            pawn = "h7";
            expectedValue = false;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            bishop = "h1";
            pawn = "a8";
            expectedValue = true;
            actualValue = program.BishopAndPawn(bishop, pawn);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}