namespace LineEncoding
{
    public class Program
    {
        string ReplaceByEncoding(string s)
        {
            if(s.Length > 1)
            {
                return s.Length.ToString() + s[0];
            }
            else
            {
                return s[0].ToString();
            }
        }

        public string LineEncoding(string s)
        {
            string substring = "";
            char previousChar = '\0';
            List<string> substrings = new List<string>();
            for(int pos = 0; pos < s.Length; pos++)
            {
                if (pos > 0 && s[pos] != previousChar)
                {
                    substrings.Add(substring);
                    substring = "";
                }
                previousChar = s[pos];
                substring += previousChar;
                if (pos + 1 == s.Length && substring.Length != 0)
                {
                    substrings.Add(substring);
                }
            }
            string lineEncoding = "";
            for(int pos = 0; pos < substrings.Count; pos++)
            {
                lineEncoding += ReplaceByEncoding(substrings[pos]);
            }
            return lineEncoding;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
