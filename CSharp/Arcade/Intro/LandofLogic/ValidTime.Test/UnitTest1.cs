namespace ValidTime.Test
{
    public class UnitTest1
    {
        ValidTime.Program program = new ValidTime.Program();
        string time = "";
        bool expectedValue;
        bool actualValue;

        [Fact]
        public void Test1()
        {
            time = "13:58";
            expectedValue = true;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            time = "25:51";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            time = "02:76";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            time = "24:00";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            time = "02:61";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test6()
        {
            time = "27:00";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test7()
        {
            time = "19:66";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test8()
        {
            time = "12:31";
            expectedValue = true;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test9()
        {
            time = "25:73";
            expectedValue = false;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test10()
        {
            time = "09:56";
            expectedValue = true;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test11()
        {
            time = "03:29";
            expectedValue = true;
            actualValue = program.ValidTime(time);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}