using System;

class Program
{
    static void Main(string[] args)
    {
        // Valores de faturamento por estado
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        // Cálculo do faturamento total
        double faturamentoTotal = sp + rj + mg + es + outros;

        // Cálculo dos percentuais
        double percentualSP = (sp / faturamentoTotal) * 100;
        double percentualRJ = (rj / faturamentoTotal) * 100;
        double percentualMG = (mg / faturamentoTotal) * 100;
        double percentualES = (es / faturamentoTotal) * 100;
        double percentualOutros = (outros / faturamentoTotal) * 100;

        // Exibição dos resultados
        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }
}
