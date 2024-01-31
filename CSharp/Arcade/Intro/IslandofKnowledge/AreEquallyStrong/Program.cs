namespace AreEquallyStrong
{
    internal class Program
    {
        bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            List<int> yours = new List<int>() { yourLeft, yourRight };
            List<int> friend = new List<int>() { friendsLeft, friendsRight };
            return yours.Max() == friend.Max() && yours.Min() == friend.Min();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            int[] b = [10, 15, 15, 10];
            int[] c = [15, 10, 15, 10];
            int[] d = [15, 10, 15, 9];
            int[] e = [10, 5, 5, 10];
            int[] f = [10, 15, 5, 20];
            int[] g = [10, 20, 10, 20];
            int[] h = [5, 20, 20, 5];
            int[] i = [20, 15, 5, 20];
            int[] j = [5, 10, 5, 10];
            int[] k = [1, 10, 10, 0];
            int[] l = [5, 5, 10, 10];
            int[] m = [10, 5, 10, 6];
            int[] n = [1, 1, 1, 1];
            int[] o = [0, 10, 10, 0];
            Console.WriteLine("b: " + a.AreEquallyStrong(b[0], b[1], b[2], b[3]));
            Console.WriteLine("c: " + a.AreEquallyStrong(c[0], c[1], c[2], c[3]));
            Console.WriteLine("d: " + a.AreEquallyStrong(d[0], d[1], d[2], d[3]));
            Console.WriteLine("e: " + a.AreEquallyStrong(e[0], e[1], e[2], e[3]));
            Console.WriteLine("f: " + a.AreEquallyStrong(f[0], f[1], f[2], f[3]));
            Console.WriteLine("g: " + a.AreEquallyStrong(g[0], g[1], g[2], g[3]));
            Console.WriteLine("h: " + a.AreEquallyStrong(h[0], h[1], h[2], h[3]));
            Console.WriteLine("i: " + a.AreEquallyStrong(i[0], i[1], i[2], i[3]));
            Console.WriteLine("j: " + a.AreEquallyStrong(j[0], j[1], j[2], j[3]));
            Console.WriteLine("k: " + a.AreEquallyStrong(k[0], k[1], k[2], k[3]));
            Console.WriteLine("l: " + a.AreEquallyStrong(l[0], l[1], l[2], l[3]));
            Console.WriteLine("m: " + a.AreEquallyStrong(m[0], m[1], m[2], m[3]));
            Console.WriteLine("n: " + a.AreEquallyStrong(n[0], n[1], n[2], n[3]));
            Console.WriteLine("o: " + a.AreEquallyStrong(o[0], o[1], o[2], o[3]));
        }
    }
}
