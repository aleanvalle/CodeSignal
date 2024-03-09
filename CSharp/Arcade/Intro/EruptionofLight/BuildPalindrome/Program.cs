namespace BuildPalindrome
{
    public class Program
    {
        bool CheckPalindrome(string inputString)
        {
            return inputString.SequenceEqual(inputString.Reverse());
        }

        bool AllAreDifferent(char antepenultimate, char penultimate, char ultimate)
        {
            return antepenultimate != penultimate && antepenultimate != ultimate && penultimate != ultimate;
        }

        bool AntepenultimateIsDifferent(char antepenultimate, char penultimate, char ultimate)
        {
            return antepenultimate != penultimate && antepenultimate != ultimate && penultimate == ultimate;
        }

        bool PenultimateIsDifferent(char antepenultimate, char penultimate, char ultimate)
        {
            return antepenultimate != penultimate && antepenultimate == ultimate && penultimate != ultimate;
        }

        string PivotCharsToBuild(string normal, string reversed)
        {
            char ultimate = normal[normal.Length - 1];
            char penultimate = normal[normal.Length - 2];
            char antepenultimate = normal[normal.Length - 3];
            if(AllAreDifferent(antepenultimate, penultimate, ultimate)) 
            {
                normal = normal + reversed.Substring(1);
            }
            else if(AntepenultimateIsDifferent(antepenultimate, penultimate, ultimate))
            {
                normal = normal + reversed.Substring(2);
            }
            else if (PenultimateIsDifferent(antepenultimate, penultimate, ultimate))
            {
                normal = normal + reversed.Substring(3);
            }
            return normal;
        }

        string AddDifferentChars(string normal, string reversed)
        {
            string differentChars = "";
            int reversedStep = 0;
            int normalStep = 0;
            while(true)
            {
                while(normalStep < normal.Length)
                {
                    if (normal[normalStep] == reversed[reversedStep])
                    {
                        reversedStep++;
                    }
                    else
                    {
                        differentChars = differentChars.Insert(0, normal[normalStep].ToString());
                    }
                    normalStep++;
                }
                break;
            }
            return normal + differentChars;
        }

        public string BuildPalindrome(string st)
        {
            string originalString = st;
            if (!CheckPalindrome(st))
            {
                st = AddDifferentChars(originalString, new string (originalString.Reverse().ToArray()));
                if (!CheckPalindrome(st))
                {
                    st = PivotCharsToBuild(originalString, new string (originalString.Reverse().ToArray()));
                }
            }
            return st;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}