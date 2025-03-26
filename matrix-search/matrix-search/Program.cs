namespace matrix_search
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 2, 5 };

            var resultado = SearchValue(array);

            Console.WriteLine(resultado);
        }


        static int SearchValue(int[] array)
        {
            Dictionary<int, int> valores = new Dictionary<int, int>();

            foreach (int item in array)
            {
                if (valores.ContainsKey(item))
                {
                    valores[item]++;
                }
                else
                {
                    valores[item] = 1;
                }
            }

            foreach (var par in valores)
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
