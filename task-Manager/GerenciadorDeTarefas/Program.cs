// See https://aka.ms/new-console-template for more information
List<Tarefa> tarefas = new();

while (true)
{
    


Console.WriteLine(" 1 - Adicione uma tarefa");
Console.WriteLine("2 - Listar todas as tarefas");
Console.WriteLine("3 - Remover uma tarefa");
Console.WriteLine("4 - Deseja marcar uma tarefa como concluída?");
short opcao = short.Parse(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine("Id da tarefa: ");
    int id = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Descrição da tarefa: ");
    string tarefa = Console.ReadLine();

    Tarefa taref = new Tarefa(id, tarefa);
    tarefas.Add(taref);
    Console.WriteLine("Tarefa adicionada com sucesso!");
}

if (opcao == 2)
{
    foreach (var tarefa in tarefas)
    {
        Console.WriteLine($"Todas as tarefas: {tarefa.Id} {tarefa.Descricao} {tarefa.Concluida}");
    }
}

if (opcao == 3)
{
    Console.WriteLine("Digite o Id da tarefa que deseja excluir");
    var id = int.Parse(Console.ReadLine());

    if(id == null) throw new Exception("Não encontrado!");

    else
    {
        var excluir = tarefas.FirstOrDefault(x => x.Id == id);
        tarefas.Remove(excluir);
        Console.WriteLine("Excluído com sucesso.");
    }
}

if (opcao == 4)
{
    Console.WriteLine("Escolha a tarefa que deseja marcar como concluida");
    var concluir = int.Parse(Console.ReadLine());

    if (concluir == null) throw new Exception("Tarefa não encontrada");

    else
    {
        var tarefinha = tarefas.FirstOrDefault(x => x.Id == concluir);
        tarefinha.ConcluirTarefa();
    }
}


}

public class Tarefa()
{
    public Tarefa(int id, string descricao) : this()
    {
        Id = id;
        Descricao = descricao;
        Concluida = false;
    }

    public int Id;
    public string Descricao;
    public bool Concluida;

    public void ConcluirTarefa()
    {
        Concluida = true;
    }
}

