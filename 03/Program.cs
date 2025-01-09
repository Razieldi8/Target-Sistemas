using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de dados de faturamento
        double[] faturamento = {
            1500.0, 2300.5, 0, 0, 2500.0, 3100.0, 2750.5, 0, 1800.0, 1950.0,
            0, 0, 3000.0, 3200.0, 3100.0, 4000.0, 0, 3500.0, 2700.0, 2800.0,
            0, 2900.0, 3100.0, 0, 0, 0, 2500.0, 3200.0, 2100.0, 3800.0
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
