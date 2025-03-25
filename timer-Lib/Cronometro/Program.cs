
namespace Cronometro;

public class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Escolha minuto ou segundos");
        Console.WriteLine("1 - Minutos");
        Console.WriteLine("2 - Segundos");
        string escolha = Console.ReadLine().ToLower();

        char type = char.Parse(escolha.Substring(escolha.Length - 1, 1));
        int tempo = int.Parse(escolha.Substring(0, escolha.Length - 1));

        int multipliyer = 1;

        if (tempo == 0)
            System.Environment.Exit(0);

        if (type == 'm')
            multipliyer = 60;

        Preparar(tempo * multipliyer);
    }

    static void Preparar(int tempo)
    {
        Console.Clear();
        Console.WriteLine("Preparar...");
        Thread.Sleep(1000);
        Console.WriteLine("Apontar...");
        Thread.Sleep(1000);
        Console.WriteLine("Vai!!!");
        Thread.Sleep(1500);
        Start(tempo);
    }


    static void Start(int tempo)
    {
        for (int contar = 1; contar <= tempo; contar++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(contar);
        }

        Finalizando();
    }

    static void Finalizando()
    {
        Console.WriteLine("Obrigado por usar nosso sistema!");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("Deseja voltar ao menu?");
        var escolha = Console.ReadLine();

        if (escolha.ToLower() == "sim") Menu();


        if (escolha.ToLower() == "não") System.Environment.Exit(0);
    }
}