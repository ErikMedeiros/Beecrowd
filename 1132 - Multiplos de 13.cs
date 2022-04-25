//https://www.beecrowd.com.br/repository/UOJ_1132.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int soma = 0;
        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            if (i % 13 != 0)
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);

    }

}