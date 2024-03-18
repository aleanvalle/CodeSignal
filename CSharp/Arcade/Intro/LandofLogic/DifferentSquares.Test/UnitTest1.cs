namespace DifferentSquares.Test
{
    public class UnitTest1
    {
        DifferentSquares.Program program = new DifferentSquares.Program();
        int[][] matrix = { };
        int expectedValue;
        int actualValue;

        [Fact]
        public void Test1()
        {
            matrix = [
                [1, 2, 1],
                [2, 2, 2],
                [2, 2, 2],
                [1, 2, 3],
                [2, 2, 1]
            ];
            expectedValue = 6;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            matrix = [
                [9, 9, 9, 9, 9],
                [9, 9, 9, 9, 9],
                [9, 9, 9, 9, 9],
                [9, 9, 9, 9, 9],
                [9, 9, 9, 9, 9],
                [9, 9, 9, 9, 9]
            ];
            expectedValue = 1;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            matrix = [[3]];
            expectedValue = 0;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            matrix = [[3, 4, 5, 6, 7, 8, 9]];
            expectedValue = 0;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            matrix = [
                [3],
                [4],
                [5],
                [6],
                [7]
            ];
            expectedValue = 0;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            matrix = [
                [2, 5, 3, 4, 3, 1, 3, 2],
                [4, 5, 4, 1, 2, 4, 1, 3],
                [1, 1, 2, 1, 4, 1, 1, 5],
                [1, 3, 4, 2, 3, 4, 2, 4],
                [1, 5, 5, 2, 1, 3, 1, 1],
                [1, 2, 3, 3, 5, 1, 2, 4],
                [3, 1, 4, 4, 4, 1, 5, 5],
                [5, 1, 3, 3, 1, 5, 3, 5],
                [5, 4, 4, 3, 5, 4, 4, 4],
            ];
            expectedValue = 54;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            matrix = [[1, 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 2, 3, 9]];
            expectedValue = 0;
            actualValue = program.DifferentSquares(matrix);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}