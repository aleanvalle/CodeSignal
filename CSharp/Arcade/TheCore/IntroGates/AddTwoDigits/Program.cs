namespace AddTwoDigits
{
    public class Program
    {
        public int AddTwoDigits(int n)
        {
            return Convert.ToInt32(n.ToString()[0].ToString()) + Convert.ToInt32(n.ToString()[1].ToString());
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
