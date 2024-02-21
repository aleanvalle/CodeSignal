namespace AbsoluteValuesSumMinimization
{
    public class Program
    {
        int Minimize(int element, int x)
        {
            return Math.Abs(element - x);
        }

        int Sum(int number1,  int number2)
        {
            return number1 + number2;
        }

        public int AbsoluteValuesSumMinimization(int[] a)
        {
            Dictionary<int, int> uniqueElementsToCompare = a
                .ToHashSet()
                .ToDictionary(k => k, v => a.Select(x => Minimize(x, v))
                .Aggregate((elem1, elem2) => Sum(elem1, elem2)));
            int minimumValue = uniqueElementsToCompare.Values.Min();
            Dictionary<int, int> smallestValues = uniqueElementsToCompare
                .Select(pair => pair)
                .Where(pair => pair.Value == minimumValue)
                .ToDictionary(x => x.Key, x => x.Value);
            if(smallestValues.Count > 1) 
            { 
                return smallestValues.Keys.Min();
            }
            else
            {
                return smallestValues.FirstOrDefault().Key;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
