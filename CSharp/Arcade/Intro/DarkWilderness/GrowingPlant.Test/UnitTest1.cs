namespace GrowingPlant.Test
{
    public class UnitTest1
    {
        GrowingPlant.Program program;

        public UnitTest1() 
        {
            program = new GrowingPlant.Program();
        }

        [Fact]
        public void Test1()
        {
            int upSpeed = 100;
            int downSpeed = 10;
            int desiredHeight = 910;
            int expectedValue = 10;
            int actualValue = program.GrowingPlant(upSpeed, downSpeed, desiredHeight);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test2()
        {
            int upSpeed = 10;
            int downSpeed = 9;
            int desiredHeight = 4;
            int expectedValue = 1;
            int actualValue = program.GrowingPlant(upSpeed, downSpeed, desiredHeight);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test3()
        {
            int upSpeed = 5;
            int downSpeed = 2;
            int desiredHeight = 7;
            int expectedValue = 2;
            int actualValue = program.GrowingPlant(upSpeed, downSpeed, desiredHeight);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test4()
        {
            int upSpeed = 7;
            int downSpeed = 3;
            int desiredHeight = 443;
            int expectedValue = 110;
            int actualValue = program.GrowingPlant(upSpeed, downSpeed, desiredHeight);
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Test5()
        {
            int upSpeed = 6;
            int downSpeed = 5;
            int desiredHeight = 10;
            int expectedValue = 5;
            int actualValue = program.GrowingPlant(upSpeed, downSpeed, desiredHeight);
            Assert.Equal(expectedValue, actualValue);
        }
    }
}