namespace ValidTime
{
    public class Program
    {
        bool FirstCharacter24HourClockFormat(char character)
        {
            return character >= '0' && character <= '2';
        }

        bool SecondCharacter24HourClockFormat(char firstCharacter, char secondCharacter)
        {
            if(firstCharacter == '2')
            {
                return secondCharacter >= '0' && secondCharacter <= '3';
            }
            return secondCharacter >= '0' && secondCharacter <= '9';
        }

        bool ThirdCharacter24HourClockFormat(char character)
        {
            return character >= '0' && character <= '5';
        }

        bool FourthCharacter24HourClockFormat(char character)
        {
            return character >= '0' && character <= '9';
        }

        public bool ValidTime(string time)
        {
            char firstCharacter = '\0';
            int valid24HourFormatCharacters = 0;
            for (int i = 0; i < time.Length; i++)
            {
                if (i == 0)
                {
                    if (FirstCharacter24HourClockFormat(time[i]))
                    {
                        firstCharacter = time[i];
                        valid24HourFormatCharacters++;
                    }
                    else break;
                }
                else if (i == 1)
                {
                    if (SecondCharacter24HourClockFormat(firstCharacter, time[i])) valid24HourFormatCharacters++;
                    else break;
                }
                else if (i == 3)
                {
                    if (ThirdCharacter24HourClockFormat(time[i])) valid24HourFormatCharacters++;
                    else break;
                }
                else if (i == 4)
                {
                    if (FourthCharacter24HourClockFormat(time[i])) valid24HourFormatCharacters++;
                    else break;
                }
            } 
            return valid24HourFormatCharacters == 4;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}