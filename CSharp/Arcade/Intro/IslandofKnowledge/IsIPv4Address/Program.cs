using System.Text.RegularExpressions;

namespace IsIPv4Address
{
    internal class Program
    {
        bool IsIPv4Address(string inputString)
        {
            string PATTERN = "^(2[0-5][0-5]|1[0-9][0-9]|[1-9][0-9]|[0-9])\\.(2[0-5][0-5]|1[0-9][0-9]|[1-9][0-9]|[0-9])\\.(2[0-5][0-5]|1[0-9][0-9]|[1-9][0-9]|[0-9])\\.(2[0-5][0-5]|1[0-9][0-9]|[1-9][0-9]|[0-9])$";
            Regex ipv4Address = new Regex(PATTERN);
            Match match = ipv4Address.Match(inputString);
            return match.Success;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string b = "172.16.254.1";
            string c = "172.316.254.1";
            string d = ".254.255.0";
            string e = "1.1.1.1a";
            string f = "1";
            string g = "0.254.255.0";
            string h = "1.23.256.255.";
            string i = "1.23.256..";
            string j = "0..1.0";
            string k = "64.233.161.00";
            string l = "64.00.161.131";
            string m = "01.233.161.131";
            string n = "35..36.9.9.0";
            string o = "1.1.1.1.1";
            string p = "1.256.1.1";
            string q = "a0.1.1.1";
            string r = "0.1.1.256";
            string s = "129380129831213981.255.255.255";
            string t = "255.255.255.255abcdekjhf";
            string u = "7283728";
            string v = "0..1.0.0";
            Console.WriteLine("b: " + a.IsIPv4Address(b));
            Console.WriteLine("c: " + a.IsIPv4Address(c));
            Console.WriteLine("d: " + a.IsIPv4Address(d));
            Console.WriteLine("e: " + a.IsIPv4Address(e));
            Console.WriteLine("f: " + a.IsIPv4Address(f));
            Console.WriteLine("g: " + a.IsIPv4Address(g));
            Console.WriteLine("h: " + a.IsIPv4Address(h));
            Console.WriteLine("i: " + a.IsIPv4Address(i));
            Console.WriteLine("j: " + a.IsIPv4Address(j));
            Console.WriteLine("k: " + a.IsIPv4Address(k));
            Console.WriteLine("l: " + a.IsIPv4Address(l));
            Console.WriteLine("m: " + a.IsIPv4Address(m));
            Console.WriteLine("n: " + a.IsIPv4Address(n));
            Console.WriteLine("o: " + a.IsIPv4Address(o));
            Console.WriteLine("p: " + a.IsIPv4Address(p));
            Console.WriteLine("q: " + a.IsIPv4Address(q));
            Console.WriteLine("r: " + a.IsIPv4Address(r));
            Console.WriteLine("s: " + a.IsIPv4Address(s));
            Console.WriteLine("t: " + a.IsIPv4Address(t));
            Console.WriteLine("u: " + a.IsIPv4Address(u));
            Console.WriteLine("v: " + a.IsIPv4Address(v));
        }
    }
}
