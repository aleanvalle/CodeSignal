namespace CircleOfNumbers.Test
{
    public class UnitTest1
    {
        CircleOfNumbers.Program circleOfNumbers;

        public UnitTest1() 
        {
            circleOfNumbers = new CircleOfNumbers.Program();
        }

        [Fact]
        public void Test1()
        {
            int n = 10;
            int firstNumber = 2;
            int expectedValue = 7;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            int n = 10;
            int firstNumber = 7;
            int expectedValue = 2;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            int n = 4;
            int firstNumber = 1;
            int expectedValue = 3;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            int n = 6;
            int firstNumber = 3;
            int expectedValue = 0;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            int n = 18;
            int firstNumber = 6;
            int expectedValue = 15;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            int n = 12;
            int firstNumber = 10;
            int expectedValue = 4;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            int n = 18;
            int firstNumber = 5;
            int expectedValue = 14;
            int actualValue = circleOfNumbers.CircleOfNumbers(n, firstNumber);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}