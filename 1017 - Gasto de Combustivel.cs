using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b;
        double result;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        result = (a * b) / 12.0;

        Console.WriteLine($"{result:0.000}");

    }

}