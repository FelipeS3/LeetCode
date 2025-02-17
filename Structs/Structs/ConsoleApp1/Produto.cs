namespace ConsoleApp1;

struct Produto
{
    public Produto(int id, string title, string descricao)
    {
        Id = id;
        Title = title;
        Descricao = descricao;
    }
    public int Id;
    public string Title;
    public string Descricao;
}