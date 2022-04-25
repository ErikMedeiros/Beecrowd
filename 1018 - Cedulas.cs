//https://www.beecrowd.com.br/repository/UOJ_1018.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int qtd, aux;
        int[] notas = new int[7];

        qtd = int.Parse(Console.ReadLine());
        aux = qtd;

        notas[0] = (qtd - qtd % 100) / 100;
        if (notas[0] > 0) { aux -= 100 * notas[0]; }

        notas[1] = qtd % 100 / 50;
        if (notas[1] > 0) { aux -= 50 * notas[1]; }

        notas[2] = aux / 20;
        if (notas[2] > 0) { aux -= 20 * notas[2]; }

        notas[3] = aux / 10;
        if (notas[3] > 0) { aux -= 10 * notas[3]; }

        notas[4] = aux / 5;
        if (notas[4] > 0) { aux -= 5 * notas[4]; }

        notas[5] = aux / 2;
        if (notas[5] > 0) { aux -= 2 * notas[5]; }

        notas[6] = aux / 1;
        if (notas[6] > 0) { aux -= 1 * notas[6]; }

        Console.WriteLine(qtd);
        Console.WriteLine($"{notas[0]} nota(s) de R$ 100,00");
        Console.WriteLine($"{notas[1]} nota(s) de R$ 50,00");
        Console.WriteLine($"{notas[2]} nota(s) de R$ 20,00");
        Console.WriteLine($"{notas[3]} nota(s) de R$ 10,00");
        Console.WriteLine($"{notas[4]} nota(s) de R$ 5,00");
        Console.WriteLine($"{notas[5]} nota(s) de R$ 2,00");
        Console.WriteLine($"{notas[6]} nota(s) de R$ 1,00");

    }

}