namespace DeleteDigit
{
    public class Program
    {
        public int DeleteDigit(int n)
        {
            string number = n.ToString();
            string tempNumber = number;
            int maxNumber = int.MinValue;
            for(int i = 0; i < number.Length; i++)
            {
                tempNumber = tempNumber.Remove(i, 1);
                if(Convert.ToInt32(tempNumber) > maxNumber)
                {
                    maxNumber = Convert.ToInt32(tempNumber);
                }
                tempNumber = number;
            }
            return maxNumber;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
