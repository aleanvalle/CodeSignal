namespace PhoneCall
{
    public class Program
    {
        public int PhoneCall(int min1, int min2_10, int min11, int s)
        {
            int phoneCallMinutes = 0;
            int phoneCallCost = 0;
            if (s >= min1) 
            {
                phoneCallCost += min1;
                phoneCallMinutes++;
            }
            else return phoneCallMinutes;
            for(int i = 2; i <= 10; i++)
            {
                if (s >= phoneCallCost + min2_10) 
                { 
                    phoneCallCost += min2_10;
                    phoneCallMinutes++;
                }
                else return phoneCallMinutes;
            }
            while(s >= phoneCallCost + min11)
            {
                phoneCallCost += min11;
                phoneCallMinutes++;
            }
            return phoneCallMinutes;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
