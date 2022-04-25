//https://www.beecrowd.com.br/repository/UOJ_1020.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int i, aux, d, m, a;
        i = int.Parse(Console.ReadLine());

        aux = i;

        a = aux / 365;
        m = (aux - 365 * a) / 30;
        d = (aux - 365 * a) % 30;

        Console.WriteLine($"{a} ano(s)\n{m} mes(es)\n{d} dia(s)");

    }

}