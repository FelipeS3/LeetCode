namespace ConsoleApp1;

public class Program
{
    
    static void Main(string[] args)
    {
        var usuario = new Usuario();
        Console.WriteLine("Escolha um valor");
        Console.WriteLine("1 - Registrar um usuario");
        Console.WriteLine("2 - Fazer Login");
        Console.WriteLine("3 - Consultar um livro");
        Console.WriteLine("4 - Cadastrar um livro");
        Console.WriteLine("5 - Excluir um livro");
        int opcao = Int32.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Usuario(); break;
        }
    }
}
