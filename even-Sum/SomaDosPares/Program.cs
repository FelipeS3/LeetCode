namespace SomaDosPares
{
    public class Program
    {
        static void Main(string[] args)
        {
            SomaPares();
        }
        static void SomaPares()
        {
            Console.WriteLine("Digite um numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine($"A soma dos numeros pares de 1 ate {num} é {soma}");

        }
    }
}