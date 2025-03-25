int valor = 0;

Console.WriteLine("Digite uma frase");
var frase = Console.ReadLine();

foreach (char i in frase)
{
    if (i != ' ')
    {
        valor++;
    }
}
Console.WriteLine(valor);


