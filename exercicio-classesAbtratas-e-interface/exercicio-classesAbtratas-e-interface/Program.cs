namespace exercicio_classesAbtratas_e_interface;

public class Program
{
    static void Main(string[] args)
    {
        var carro = new Carro("Fusca");
        var aviao = new Aviao("Boeing 747");
        var barco = new Barco("Titanic");

        carro.ExibirInfo();
        carro.Mover();
        carro.Parar();

        Console.WriteLine();

        aviao.ExibirInfo();
        aviao.Mover();
        aviao.Parar();

        Console.WriteLine();

        barco.ExibirInfo();
        barco.Mover();
        barco.Parar();

    }
}

public interface IMeioDeTransporte
{
    void Mover();
    void Parar();
}

public abstract class Transporte : IMeioDeTransporte
{
    public Transporte(string nome)
    {
        Nome = nome;
    }
    public string Nome;
    public abstract void ExibirInfo();
    public void Mover()
    {
        Console.WriteLine($"O {Nome} está em movimento.");
    }

    public void Parar()
    {
        Console.WriteLine($"O {Nome} parou.");
    }
}

public class Carro : Transporte
{
    public Carro(string nome) : base(nome) { }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Este é um carro chamado {Nome}");
    }
}
public class Aviao : Transporte
{
    public Aviao(string nome) : base(nome) { }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Este é um avião chamado {Nome}");
    }
}
public class Barco : Transporte
{
    public Barco(string nome) : base(nome) { }

    public override void ExibirInfo()
    {
        Console.WriteLine($"Este é um barco chamado {Nome}");
    }
}