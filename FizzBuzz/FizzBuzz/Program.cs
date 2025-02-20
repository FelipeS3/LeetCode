namespace FizzBuzz;

public class Program
{
    static void Main(string[] args)
    {
        SomaDeUmACem();
    }


    static void SomaDeUmACem()
    {
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0) Console.WriteLine("Fizz");

            if (i % 5 == 0) Console.WriteLine("Buzz");

            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        }
    }
}