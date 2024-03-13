namespace IsMAC48Address
{
    public class Program
    {
        string HEXADECIMAL_MAC48 = "0123456789ABCDEF";
        int HEXADECIMAL_MAC48_LENGTH = 17;
        char HYPHEN = '-';
        int[] HYPHENPOSITIONS = { 2, 5, 8, 11, 14 };

        bool IsValidLength(string inputString)
        {
            return inputString.Length == HEXADECIMAL_MAC48_LENGTH;
        }

        bool HaveFiveHyphens(string inputString)
        {
            int hyphenCounter = 0;
            for(int pos = 0; pos < inputString.Length; pos++)
            {
                if (inputString[pos] == HYPHEN)
                {
                    hyphenCounter++;
                }
            }
            return hyphenCounter == 5;
        }

        bool AreValidHyphens(string inputString)
        {
            int validHyphens = 0;
            foreach(int pos in HYPHENPOSITIONS)
            {
                if (inputString[pos] == HYPHEN)
                {
                    validHyphens++;
                }
            }
            return validHyphens == 5;
        }

        bool IsValidMACAddressGroup(string group)
        {
            int validCharacters = 0;
            for(int iPos = 0; iPos < group.Length; iPos++)
            {
                for(int jPos = 0; jPos < HEXADECIMAL_MAC48.Length; jPos++)
                {
                    if (HEXADECIMAL_MAC48[jPos] == group[iPos])
                    {
                        validCharacters++;
                        break;
                    }
                }
            }
            return validCharacters == 2;
        }

        public bool IsMAC48Address(string inputString)
        {
            if(IsValidLength(inputString) && HaveFiveHyphens(inputString) && AreValidHyphens(inputString))
            {
                string group = "";
                int macAddressGroupCounter = 0;
                for(int pos = 0; pos < inputString.Length; pos++)
                {
                    if (inputString[pos] != HYPHEN)
                    {
                        group += inputString[pos];
                    }
                    if(group.Length == 2)
                    {
                        if (IsValidMACAddressGroup(group))
                        {
                            macAddressGroupCounter++;
                            group = "";
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                return macAddressGroupCounter == 6;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
