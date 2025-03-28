namespace SomaDosPares
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumEvenToN(6));
        }
        private static int SumEvenToN(int n)
        {
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0) sum += i;
            }

            return sum;
        }
    }
}