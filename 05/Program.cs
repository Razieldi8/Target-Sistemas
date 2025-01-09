using System;

class Program
{
    static void Main(string[] args)
    {
        // Entrada da string
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        // Inversão manual da string
        string invertida = InverterString(entrada);

        // Exibição do resultado
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string texto)
    {
        char[] caracteres = new char[texto.Length];
        int j = texto.Length - 1;

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[j];
            j--;
        }

        return new string(caracteres);
    }
}
