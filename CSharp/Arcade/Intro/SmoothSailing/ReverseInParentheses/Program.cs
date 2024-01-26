using System.Text.RegularExpressions;

namespace ReverseInParentheses
{
    internal class Program
    {
        string ReverseInParentheses(string inputString)
        {
            string PATTERN = "(\\(\\w*\\))";
            Regex wordInParentheses = new Regex(PATTERN);
            Match match = wordInParentheses.Match(inputString);
            if (match.Success)
            {
                string catched = match.Value.Substring(1, match.Value.Length - 2);
                char[] reversed = catched.ToCharArray();
                Array.Reverse(reversed);
                string parenthesesReplacement = new string(reversed);
                inputString = inputString.Remove(match.Index, match.Length);
                inputString = inputString.Insert(match.Index, parenthesesReplacement);
                return ReverseInParentheses(inputString);
            }
            else
            {
                return inputString;
            }
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string b = "(bar)";
            string c = "foo(bar)baz";
            string d = "foo(bar)baz(blim)";
            string e = "foo(bar(baz))blim";
            Console.WriteLine("b: " + a.ReverseInParentheses(b));
            Console.WriteLine("c: " + a.ReverseInParentheses(c));
            Console.WriteLine("d: " + a.ReverseInParentheses(d));
            Console.WriteLine("e: " + a.ReverseInParentheses(e));
        }
    }
}
