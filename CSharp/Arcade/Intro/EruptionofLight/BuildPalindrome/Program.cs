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

        string PivotToBuild(string normal, string reversed)
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
            string originalString = st;
            if (!CheckPalindrome(st))
            {
                st = AddDifferent(originalString, (string) originalString.Reverse());
                if (!CheckPalindrome(st))
                {
                    st = PivotToBuild(originalString, (string) originalString.Reverse());
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
