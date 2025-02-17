namespace Jokenpo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jokenpo();
        }

        static void Jokenpo()
        {
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");
            var escolhaJogador = int.Parse(Console.ReadLine());

            Random r = new Random();
            int escolhaComputador = r.Next(1, 3);

            if (escolhaComputador == 1 && escolhaJogador == 1)
            {
                Console.WriteLine("Empate! O computador escolheu Pedra");
            }
            if (escolhaComputador == 1 && escolhaJogador == 2)
            {
                Console.WriteLine("Jogador Ganhou! O computador escolheu Pedra");
            }
            if (escolhaComputador == 1 && escolhaJogador == 3)
            {
                Console.WriteLine("Computador Ganhou! O computador escolheu Pedra");
            }
            if (escolhaComputador == 2 && escolhaJogador == 1)
            {
                Console.WriteLine("Computador Ganhou! O computador escolheu Papel");
            }
            if (escolhaComputador == 2 && escolhaJogador == 2)
            {
                Console.WriteLine("Empate! O computador escolheu Papel");
            }
            if (escolhaComputador == 2 && escolhaJogador == 3)
            {
                Console.WriteLine("Jogador Ganhou! O computador escolheu Papel");
            }
            if (escolhaComputador == 3 && escolhaJogador == 1)
            {
                Console.WriteLine("Jogador Ganhou! O computador escolheu Tesoura");
            }
            if (escolhaComputador == 3 && escolhaJogador == 2)
            {
                Console.WriteLine("Computador Ganhou! O computador escolheu Tesoura");
            }
            if (escolhaComputador == 3 && escolhaJogador == 3)
            {
                Console.WriteLine("Empate! O computador escolheu Tesoura");
            }

            Console.WriteLine("Deseja tentar novamente?");
            var escolha = Console.ReadLine().ToLower();

            if (escolha == "sim") Jokenpo();

            else Console.WriteLine("Obrigado por jogar!");


        }
    }
}