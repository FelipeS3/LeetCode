namespace find_repeated_number
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,2,5,6};

            int resultado = FindFirstRepeatedNumber(array);

            Console.WriteLine(resultado);
        }

        private static int FindFirstRepeatedNumber(int[] array)
        {
            Dictionary<int, int> contagens = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (contagens.ContainsKey(num))
                {
                    contagens[num]++;
                }
                else
                {
                    contagens[num] = 1;
                }
            }

            foreach (var par in contagens)
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
