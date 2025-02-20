namespace Biblioteca;

public class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro("C# para iniciantes", "Autor A");
        Livro livro2 = new Livro("Design Patterns", "Autor B");

        Biblioteca biblioteca = new Biblioteca();
        biblioteca.AdicionarLivro(livro1);
        biblioteca.AdicionarLivro(livro2);

        biblioteca.EmprestarLivro("C# para Iniciantes");
        biblioteca.EmprestarLivro("Design Patterns");
        biblioteca.Devolver("C# para Iniciantes");

        biblioteca.ExibirLivrosDisponiveis();

        Livro.ExibirLivros();
    }
}
public class Livro
{
    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponivel = true;
        TotalLivros++;
        DataDevolucao = DateTime.Now;
    }
    public string Titulo;
    public string Autor;
    public bool Disponivel;
    private static int TotalLivros;
    public int TotalEmprestada;
    public DateTime? DataDevolucao;

    public void DevolverLivro()
    {
        if (Disponivel == false)
        {
            Disponivel = true;
            TotalEmprestada--;
            DataDevolucao = DateTime.Now;
            Console.WriteLine($"Livro {Titulo} Foi devolvido");
        }
    }

    public void Emprestar()
    {
        if (Disponivel == true)
        {
            Disponivel = false;
            TotalEmprestada++;
            Console.WriteLine($"Livro {Titulo} foi emprestado");
        }
        else
        {
            Console.WriteLine($"Livro {Titulo} não está disponível");
        }
    }

    public static void ExibirLivros()
    {
        Console.WriteLine($"Quantidade total de livros {TotalLivros}");
    }
}

public class Biblioteca
{
    public List<Livro> livros = new List<Livro>();

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"Livro \"{livro.Titulo}\" adicionado à biblioteca.");
    }

    public void EmprestarLivro(string titulo)
    {
        var livro = livros.Find(l => l.Titulo == titulo && l.Disponivel == true);

        if (livro != null)
        {
            livro.Emprestar();
        }
        else
        {
            Console.WriteLine($"Livro {titulo} não está disponível para o emprestimo!");
        }
    }

    public void Devolver(string titulo)
    {
        var livro = livros.Find(l => l.Titulo == titulo && l.Disponivel == false);

        if (livro != null)
        {
            livro.DevolverLivro();
        }
        else
        {
            Console.WriteLine($" O Livro {titulo} não encontrado!");
        }
    }

    public void ExibirLivrosDisponiveis()
    {
        foreach (var livro in livros)
        {
            if (!livro.Disponivel)
            {
                Console.WriteLine($"{livro.Titulo}, {livro.Autor}, {livro.Disponivel}");
            }
        }
    }

}