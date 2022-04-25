using System;

class URI
{

    static void Main(string[] args)
    {

        double qtd;
        int cents, money, aux;
        int[,] notas = new int[6, 2];

        qtd = double.Parse(Console.ReadLine());

        aux = Convert.ToInt32(qtd * 100);
        cents = aux % 100;
        money = (aux - cents) / 100;

        aux = money;

        notas[0, 0] = (money - money % 100) / 100;
        if (notas[0, 0] > 0) { aux -= (100 * notas[0, 0]); }

        notas[1, 0] = money % 100 / 50;
        if (notas[1, 0] > 0) { aux -= (50 * notas[1, 0]); }

        notas[2, 0] = aux / 20;
        if (notas[2, 0] > 0) { aux -= (20 * notas[2, 0]); }

        notas[3, 0] = aux / 10;
        if (notas[3, 0] > 0) { aux -= (10 * notas[3, 0]); }

        notas[4, 0] = aux / 5;
        if (notas[4, 0] > 0) { aux -= (5 * notas[4, 0]); }

        notas[5, 0] = aux / 2;
        if (notas[5, 0] > 0) { aux -= (2 * notas[5, 0]); }

        if (aux > 0) { cents += aux * 100; aux = cents; }

        aux = cents;

        notas[0, 1] = (cents - cents % 100) / 100;
        if (notas[0, 1] > 0) { aux -= 100 * notas[0, 1]; }

        notas[1, 1] = cents % 100 / 50;
        if (notas[1, 1] > 0) { aux -= 50 * notas[1, 1]; }

        notas[2, 1] = aux / 25;
        if (notas[2, 1] > 0) { aux -= 25 * notas[2, 1]; }

        notas[3, 1] = aux / 10;
        if (notas[3, 1] > 0) { aux -= 10 * notas[3, 1]; }

        notas[4, 1] = aux / 5;
        if (notas[4, 1] > 0) { aux -= 5 * notas[4, 1]; }

        notas[5, 1] = aux / 1;
        if (notas[5, 1] > 0) { aux -= 1 * notas[5, 1]; }

        Console.WriteLine($"NOTAS:\n" +
                        $"{notas[0, 0]} nota(s) de R$ 100.00\n" +
                        $"{notas[1, 0]} nota(s) de R$ 50.00\n" +
                        $"{notas[2, 0]} nota(s) de R$ 20.00\n" +
                        $"{notas[3, 0]} nota(s) de R$ 10.00\n" +
                        $"{notas[4, 0]} nota(s) de R$ 5.00\n" +
                        $"{notas[5, 0]} nota(s) de R$ 2.00");
        Console.WriteLine($"MOEDAS:\n" +
                        $"{notas[0, 1]} moeda(s) de R$ 1.00\n" +
                        $"{notas[1, 1]} moeda(s) de R$ 0.50\n" +
                        $"{notas[2, 1]} moeda(s) de R$ 0.25\n" +
                        $"{notas[3, 1]} moeda(s) de R$ 0.10\n" +
                        $"{notas[4, 1]} moeda(s) de R$ 0.05\n" +
                        $"{notas[5, 1]} moeda(s) de R$ 0.01");

    }

}