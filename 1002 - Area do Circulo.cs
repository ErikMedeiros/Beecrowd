using System;

class URI
{

    static void Main(string[] args)
    {

        double area, n = 3.14159, raio;

        raio = double.Parse(Console.ReadLine());
        area = n * Math.Pow(raio, 2);

        Console.WriteLine($"A={area:0.0000}");
    }

}