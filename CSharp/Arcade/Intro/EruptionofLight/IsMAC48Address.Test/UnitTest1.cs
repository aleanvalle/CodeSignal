namespace IsMAC48Address.Test
{
    public class UnitTest1
    {
        IsMAC48Address.Program program = new IsMAC48Address.Program();
        string inputString = "";
        bool expectedValue;
        bool actualValue;

        [Fact]
        public void Test1()
        {
            inputString = "00-1B-63-84-45-E6";
            expectedValue = true;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            inputString = "Z1-1B-63-84-45-E6";
            expectedValue = false;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            inputString = "not a MAC-48 address";
            expectedValue = false;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            inputString = "FF-FF-FF-FF-FF-FF";
            expectedValue = true;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            inputString = "00-00-00-00-00-00";
            expectedValue = true;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            inputString = "G0-00-00-00-00-00";
            expectedValue = false;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            inputString = "02-03-04-05-06-07-";
            expectedValue = false;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            inputString = "12-34-56-78-9A-BC";
            expectedValue = true;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            inputString = "FF-FF-AB-CD-EA-BC";
            expectedValue = true;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            inputString = "12-34-56-78-9A-BG";
            expectedValue = false;
            actualValue = program.IsMAC48Address(inputString);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}