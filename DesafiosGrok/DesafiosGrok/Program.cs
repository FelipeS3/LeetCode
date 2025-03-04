

public class Program
{
    static void Main(string[] args)
    {
        //Exercicio 1
        string Nome = "Felipe";
        int Idade = 20;
        Console.WriteLine($"{Nome} e {Idade}");

        //Exercicio 2
        Console.WriteLine("Digite sua idade");
        string idade = Console.ReadLine();

        int idadeInteiro = int.Parse(idade);

        Console.WriteLine($"Idade: {idadeInteiro + 5}");

        //Exercicio 3
        int CalcularDobro(int valor)
        {
            return valor * 2;
        }

        //Exercicio 4
        Console.WriteLine("Digite um numero");
        int numero = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"Tabuada do {numero} é {numero * i}");
        // 
        int tabuada = 0;
        while (tabuada <= 10)
        {
            tabuada++;
            Console.WriteLine($"A tabuada do {numero} é {numero * tabuada}");
        }

        int MaiorValor(int x, int y)
        {
            return x > y ? x : y;
        }


        List<int> valores = new List<int>();

        Console.WriteLine("Digite primeiro valor");
        int valor1 = int.Parse(Console.ReadLine());
        valores.Add(valor1);

        Console.WriteLine("Digite segundo valor");
        int valor2 = int.Parse(Console.ReadLine());
        valores.Add(valor2);

        Console.WriteLine("Digite terceiro valor");
        int valor3 = int.Parse(Console.ReadLine());
        valores.Add(valor3);

        Console.WriteLine("Digite quarto valor");
        int valor4 = int.Parse(Console.ReadLine());
        valores.Add(valor4);

        Console.WriteLine("Digite quinto valor");
        int valor5 = int.Parse(Console.ReadLine());
        valores.Add(valor5);

        int valorMaior = EncontrarMaior(valores);
        Console.WriteLine(valorMaior);

        int EncontrarMaior(List<int> valores)
        {
            int maior = valores[0];
            foreach (var valor in valores)
            {
                if (valor > maior) maior = valor;
            }
            return maior;
        }

    }

}