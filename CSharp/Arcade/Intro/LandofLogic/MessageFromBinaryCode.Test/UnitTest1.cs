namespace MessageFromBinaryCode.Test
{
    public class UnitTest1
    {
        MessageFromBinaryCode.Program program = new MessageFromBinaryCode.Program();
        string code = "";
        string expectedValue = "";
        string actualValue = "";

        [Fact]
        public void Test1()
        {
            code = "010010000110010101101100011011000110111100100001";
            expectedValue = "Hello!";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            code = "01001101011000010111100100100000011101000110100001100101001000000100011001101111011100100110001101100101001000000110001001100101001000000111011101101001011101000110100000100000011110010110111101110101";
            expectedValue = "May the Force be with you";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            code = "010110010110111101110101001000000110100001100001011001000010000001101101011001010010000001100001011101000010000001100000011010000110010101101100011011000110111100101110";
            expectedValue = "You had me at `hello.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            code = "010001010110110001100101011011010110010101101110011101000110000101110010011110010010110000100000011011010111100100100000011001000110010101100001011100100010000001010111011000010111010001110011011011110110111000100001";
            expectedValue = "Elementary, my dear Watson!";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            code = "010011000110111101110110011001010010000001000110011011110111001000100000010000010110110001101100001011000010000001001000011000010111010001110010011001010110010000100000010001100110111101110010001000000100111001101111011011100110010100101110";
            expectedValue = "Love For All, Hatred For None.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            code = "0100001101101000011000010110111001100111011001010010000001110100011010000110010100100000011101110110111101110010011011000110010000100000011000100111100100100000011000100110010101101001011011100110011100100000011110010110111101110101011100100111001101100101011011000110011000101110";
            expectedValue = "Change the world by being yourself.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            code = "01000101011101100110010101110010011110010010000001101101011011110110110101100101011011100111010000100000011010010111001100100000011000010010000001100110011100100110010101110011011010000010000001100010011001010110011101101001011011100110111001101001011011100110011100101110";
            expectedValue = "Every moment is a fresh beginning.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            code = "010011100110010101110110011001010111001000100000011100100110010101100111011100100110010101110100001000000110000101101110011110010111010001101000011010010110111001100111001000000111010001101000011000010111010000100000011011010110000101100100011001010010000001111001011011110111010100100000011100110110110101101001011011000110010100101110";
            expectedValue = "Never regret anything that made you smile.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            code = "010001000110100101100101001000000111011101101001011101000110100000100000011011010110010101101101011011110111001001101001011001010111001100101100001000000110111001101111011101000010000001100100011100100110010101100001011011010111001100101110";
            expectedValue = "Die with memories, not dreams.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            code = "0100000101110011011100000110100101110010011001010010000001110100011011110010000001101001011011100111001101110000011010010111001001100101001000000110001001100101011001100110111101110010011001010010000001110111011001010010000001100101011110000111000001101001011100100110010100101110";
            expectedValue = "Aspire to inspire before we expire.";
            actualValue = program.MessageFromBinaryCode(code);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}