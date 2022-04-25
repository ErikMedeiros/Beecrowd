//https://www.beecrowd.com.br/repository/UOJ_1005.html
using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, pA, pB, media;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        pA = 3.5;
        pB = 7.5;

        media = (a * pA + b * pB) / (pA + pB);

        Console.WriteLine($"MEDIA = {media:0.00000}");

    }

}