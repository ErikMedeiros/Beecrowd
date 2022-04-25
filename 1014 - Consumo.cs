using System;

class URI
{

    static void Main(string[] args)
    {

        int a;
        double b, total;

        a = int.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        total = a / b;

        Console.WriteLine($"{total:0.000} km/l");

    }

}