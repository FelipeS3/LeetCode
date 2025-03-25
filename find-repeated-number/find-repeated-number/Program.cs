namespace find_repeated_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,2,5,6};

            int result = FindFirstRepeatedNumber(array);

            Console.WriteLine(result);
        }

        private static int FindFirstRepeatedNumber(int[] array)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var par in counts)
            {
                if (par.Value > 1)
                {
                    return par.Key;
                }
            }

            return -1;
        }
    }
}
