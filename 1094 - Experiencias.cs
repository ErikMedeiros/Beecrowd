//https://www.beecrowd.com.br/repository/UOJ_1094.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        string[] cobaias;
        double total, coelhos = 0.0, sapos = 0.0, ratos = 0.0;
        double pCoelhos, pSapos, pRatos;

        for (int i = 0; i < x; i++)
        {
            cobaias = Console.ReadLine().Split(' ');

            if (cobaias[1] == "C")
            {
                coelhos += double.Parse(cobaias[0]);
            }
            else if (cobaias[1] == "R")
            {
                ratos += double.Parse(cobaias[0]);
            }
            else if (cobaias[1] == "S")
            {
                sapos += double.Parse(cobaias[0]);
            }
        }

        total = sapos + coelhos + ratos;

        pCoelhos = (coelhos / total) * 100;
        pRatos = (ratos / total) * 100;
        pSapos = (sapos / total) * 100;

        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {pCoelhos:F2} %");
        Console.WriteLine($"Percentual de ratos: {pRatos:F2} %");
        Console.WriteLine($"Percentual de sapos: {pSapos:F2} %");

    }

}