namespace DesafioVoidStatic;

public class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("felipe");
        pessoa1.Apresentar();
        Pessoa pessoa2 = new Pessoa("maria");
        pessoa2.Apresentar();
        Pessoa pessoa3 = new Pessoa("zezin");
        pessoa3.Apresentar();

        Pessoa.TotalDeAlunos();

        Carro carro1 = new Carro("Mustang");
        carro1.ExibirModelo();
        Carro carro2 = new Carro("Camaro");
        carro2.ExibirModelo();
        Carro carro3 = new Carro("Fusca");
        carro3.ExibirModelo();

        Carro.CarroTotais();
    }
    

}
public class Pessoa
{
    private string Nome;
    private static int TotalAlunos;
    public Pessoa(string nome)
    {
        Nome = nome;
        TotalAlunos++;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    public static void TotalDeAlunos()
    {
        Console.WriteLine($"Total de alunos criados: {TotalAlunos}");
    }
}

public class Carro
{
    public Carro(string modelo)
    {
        Modelo = modelo;
        TotalCarros++;
    }
    private string Modelo;
    private static int TotalCarros;

    public void ExibirModelo()
    {
        Console.WriteLine($"Modelo : {Modelo}");
    }

    public static void CarroTotais()
    {
        Console.WriteLine($"Carros totais: {TotalCarros}");
    }
}