
namespace desafio;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        string? frase = Console.ReadLine();

        Console.WriteLine("Digite uma letra para buscar na frase");
        char caractere = Convert.ToChar(Console.ReadLine());

        int indice = frase.LastIndexOf(caractere);

        if (indice == -1) Console.WriteLine("Caractere nao existe na frase, tente novamente");

        else Console.WriteLine($"A ultima ocorrência da letra {caractere} esta no índice: {indice}.");

    }
}