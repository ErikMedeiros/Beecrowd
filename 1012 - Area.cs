//https://www.beecrowd.com.br/repository/UOJ_1012.html
using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, c, areaT, areaC, areaTr, areaQ, areaR, pi = 3.14159;

        string[] nums = Console.ReadLine().Split(' ');

        a = double.Parse(nums[0]);
        b = double.Parse(nums[1]);
        c = double.Parse(nums[2]);

        areaT = (a * c) / 2;
        areaC = pi * Math.Pow(c, 2);
        areaTr = ((a + b) * c) / 2;
        areaQ = Math.Pow(b, 2);
        areaR = a * b;

        Console.WriteLine($"TRIANGULO: {areaT:0.000}");
        Console.WriteLine($"CIRCULO: {areaC:0.000}");
        Console.WriteLine($"TRAPEZIO: {areaTr:0.000}");
        Console.WriteLine($"QUADRADO: {areaQ:0.000}");
        Console.WriteLine($"RETANGULO: {areaR:0.000}");

    }

}