namespace GrowingPlant
{
    public class Program
    {
        public int GrowingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int days = 1;
            int currentHeight = 0;
            while((currentHeight += upSpeed) < desiredHeight)
            {
                currentHeight -= downSpeed;
                days++;
            }
            return days;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
