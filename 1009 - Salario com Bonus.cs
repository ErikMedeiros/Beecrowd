//https://www.beecrowd.com.br/repository/UOJ_1009.html
using System;

class URI
{

    static void Main(string[] args)
    {

        string nomeVend;
        double salario, vendasTotal, aux;

        nomeVend = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        vendasTotal = double.Parse(Console.ReadLine());

        aux = vendasTotal * 0.15 + salario;

        Console.WriteLine($"TOTAL = R$ {aux:0.00}");

    }

}