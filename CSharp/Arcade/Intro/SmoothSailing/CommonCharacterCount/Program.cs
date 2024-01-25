namespace CommonCharacterCount
{
    internal class Program
    {
        int CommonCharacterCount(string s1, string s2)
        {
            int counter = 0;
            var l1 = s1.ToList();
            var l2 = s2.ToList();
            for (int i = 0; i < l1.Count; i++) 
            {
                if (l2.Contains(l1[i]))
                {
                    counter++;
                    l2.Remove(l1[i]);
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            string s1 = "aabcc";
            string s2 = "adcaa";
            Console.WriteLine("result: " + a.CommonCharacterCount(s1, s2));
        }
    }
}
