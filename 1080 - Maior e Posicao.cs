//https://www.beecrowd.com.br/repository/UOJ_1080.html
using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {

        int x = 0, max = 0, aux;
        List<int> pos = new List<int>();

        for (int i = 0; i < 100; i++)
        {
            aux = x;
            x = int.Parse(Console.ReadLine());
            pos.Add(x);

            max = Math.Max(Math.Max(aux, x), max);
        }

        Console.WriteLine(max);
        Console.WriteLine(pos.IndexOf(max) + 1);
    }
}