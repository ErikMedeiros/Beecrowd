using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c, d, dife;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());

        dife = a * b - c * d;

        Console.WriteLine($"DIFERENCA = {dife}");

    }

}