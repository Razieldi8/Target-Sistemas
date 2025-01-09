using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de dados de faturamento
        double[] faturamento = {
            22174.1664, 24537.6698, 26139.6134, 0, 0, 26742.6612, 0, 42889.2258, 46251.174, 11191.4722,
            0, 0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 0, 0, 35240.1826,
            43829.1667, 18235.6852, 4355.0662, 13327.1025, 0, 0, 25681.8318, 1718.1221, 13220.495, 8414.61
        };

        // Filtrando dias com faturamento > 0
        var diasComFaturamento = faturamento.Where(f => f > 0).ToArray();

        if (diasComFaturamento.Length == 0)
        {
            Console.WriteLine("Nenhum faturamento foi registrado no mês.");
            return;
        }

        // Menor e maior valor de faturamento
        double menorValor = diasComFaturamento.Min();
        double maiorValor = diasComFaturamento.Max();

        // Média mensal considerando apenas dias com faturamento
        double mediaMensal = diasComFaturamento.Average();

        // Dias com faturamento superior à média
        int diasAcimaDaMedia = faturamento.Count(f => f > mediaMensal);

        // Exibindo os resultados
        Console.WriteLine($"Menor valor de faturamento: {menorValor:C}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:C}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }
}
