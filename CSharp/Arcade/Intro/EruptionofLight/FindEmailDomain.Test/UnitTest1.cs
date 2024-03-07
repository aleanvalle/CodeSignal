namespace FindEmailDomain.Test
{
    public class UnitTest1
    {
        FindEmailDomain.Program program = new FindEmailDomain.Program();
        string address = "";
        string expectedValue = "";
        string actualValue = "";

        [Fact]
        public void Test1()
        {
            address = "prettyandsimple@example.com";
            expectedValue = "example.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            address = "fully-qualified-domain@codesignal.com";
            expectedValue = "codesignal.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            address = "\" \"@space.com";
            expectedValue = "space.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            address = "someaddress@yandex.ru";
            expectedValue = "yandex.ru";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            address = "\" \"@xample.org";
            expectedValue = "xample.org";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            address = "\"much.more unusual\"@yahoo.com";
            expectedValue = "yahoo.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            address = "\"very.unusual.@.unusual.com\"@usual.com";
            expectedValue = "usual.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            address = "admin@mailserver2.ru";
            expectedValue = "mailserver2.ru";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            address = "example-indeed@strange-example.com";
            expectedValue = "strange-example.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            address = "very.common@gmail.com";
            expectedValue = "gmail.com";
            actualValue = program.FindEmailDomain(address);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}