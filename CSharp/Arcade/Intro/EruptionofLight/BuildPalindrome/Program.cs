namespace BuildPalindrome
{
    public class Program
    {
        string AddDifferent(string normal, string reversed)
        {
            string addDifferent = "";
            for(int i = 0; i < normal.Length; i++)
            {
                for(int j = 0; j < reversed.Length;)
                {
                    if (normal[i] == reversed[j])
                    {
                        j++;
                    }
                    else
                    {
                        addDifferent.Insert(0, normal[i].ToString());
                    }
                }
            }
            return normal + addDifferent;
        }


        public string BuildPalindrome(string st)
        {
            return "";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
