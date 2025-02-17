namespace ManipulacaoDeArquivos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja escolher?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar arquivo");
            Console.WriteLine("0 - Sair");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();

            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var sw = new StreamReader(path))
            {
                string text = sw.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo, ou aperte Esc para sair");
            string text = "";

            do
            {
                text += Console.ReadLine() + Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("QQual caminho deseja escolher para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var sw = new StreamWriter(path))
            {
                sw.Write(text);
            }

            Console.WriteLine($"Arquivo{path} salvo com sucesso!");
            Console.ReadLine();

            Menu();
        }
    }
}