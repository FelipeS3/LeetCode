namespace exercicio_try_catch_finally
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um numero");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Você deve digitar um número válido!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operação finalizada.");
            }
        }
    }
}