int[,] matriz = new int[3,3] { {1,2,3}, {4,5,6}, {7,8,9} };

int soma = 0;

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        soma += matriz[i, j];
    }
}

Console.WriteLine($"Maior valor: {soma}");