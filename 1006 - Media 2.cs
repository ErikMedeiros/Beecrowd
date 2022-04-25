using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, c, pA, pB, pC, media;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        pA = 2;
        pB = 3;
        pC = 5;

        media = (a * pA + b * pB + c * pC) / (pA + pB + pC);

        Console.WriteLine($"MEDIA = {media:0.0}");

    }

}