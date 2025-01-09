using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número: ");
        int numero;
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        if (numero < 0)
        {
            return false;
        }

        int a = 0;
        int b = 1;

        while (a <= numero)
        {
            if (a == numero)
            {
                return true;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
