namespace AddBorder
{
    internal class Program
    {
        string[] AddBorder(string[] picture)
        {
            for(int i = 0; i < picture.Length; i++)
            {
                picture[i] = picture[i].Replace(picture[i], "*" + picture[i] + "*");
            }
            List<string> borderedStrings = new List<string>(picture);
            int wordLength = borderedStrings[0].Length;
            string upperAndLowerBorders = new string('*', wordLength);
            borderedStrings.Insert(0, upperAndLowerBorders);
            borderedStrings.Insert(borderedStrings.Count, upperAndLowerBorders);
            return borderedStrings.ToArray();
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            string[] b = ["abc", "ded"];
            Console.WriteLine("result: " + string.Join(", ", a.AddBorder(b)));
        }
    }
}
