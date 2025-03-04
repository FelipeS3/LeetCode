
//Exercicio com Dictionarys
Dictionary<string, double> alunos = new Dictionary<string, double>();

 
while (true)
{
    Console.WriteLine("1 - Adicionar aluno");
    Console.WriteLine("2 - Buscar nota de aluno");
    Console.WriteLine("3 - Exibir média da turma");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Nota do aluno: ");
            double nota;
            while(!double.TryParse(Console.ReadLine(), out nota)) Console.WriteLine("Valor inválido.");
            alunos[nome] = nota;
            break;

        case 2:

            Console.WriteLine("Digite o nome do aluno");
            string busca = Console.ReadLine();
            if (alunos.TryGetValue(busca, out double notaAluno)) Console.WriteLine($"A nota de {busca} é {notaAluno}");
            else Console.WriteLine("Aluno não encontrado.");
            break;


        case 3:
            double media = alunos.Values.Average();
            Console.WriteLine($"A média da tume é de {media:F2}");
            break;

        case 4: Environment.Exit(1); break;

        default: return; break;

    }

}

