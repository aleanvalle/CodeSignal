namespace FirstDigit.Test
{
    public class UnitTest1
    {
        FirstDigit.Program firstDigit;

        public UnitTest1() 
        {
            firstDigit = new FirstDigit.Program();
        }

        [Fact]
        public void Test1()
        {
            string inputArray = "var_1__Int";
            char expectedValue = '1';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            string inputArray = "q2q-q";
            char expectedValue = '2';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            string inputArray = "0ss";
            char expectedValue = '0';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            string inputArray = "_Aas_23";
            char expectedValue = '2';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            string inputArray = "a a_933";
            char expectedValue = '9';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            string inputArray = "ok0";
            char expectedValue = '0';
            char actualValue = firstDigit.FirstDigit(inputArray);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}