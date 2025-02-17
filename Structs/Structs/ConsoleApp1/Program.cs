// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Console.WriteLine("Escolha uma op!");

var produto = new Produto();


Console.WriteLine("Insira os dados");

Console.WriteLine("Id: ");
produto.Id = int.Parse(Console.ReadLine());

Console.WriteLine("Titulo: ");
produto.Title = Console.ReadLine();

Console.WriteLine("Descricao: ");
produto.Descricao = Console.ReadLine();


Console.WriteLine($"{produto.Id}, {produto.Title}, {produto.Descricao}");