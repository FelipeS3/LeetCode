

string text = @"C:\Users\felip\OneDrive\Área de Trabalho\MeuTexto.text";

using (StreamWriter sw = new StreamWriter(text))
{
    sw.WriteLine("Manipulação de strings");
}