//https://www.beecrowd.com.br/repository/UOJ_1117.html
using System;

class URI
{

    static void Main(string[] args)
    {

        double x, y, med;

        do
        {
            x = double.Parse(Console.ReadLine());

            if (x > 10d || x < 0d)
            {
                Console.WriteLine("nota invalida");
            }
        } while (x > 10d || x < 0d);

        do
        {
            y = double.Parse(Console.ReadLine());

            if (y > 10d || y < 0d)
            {
                Console.WriteLine("nota invalida");
            }
        } while (y > 10d || y < 0d);

        med = (x + y) / 2d;

        Console.WriteLine($"media = {med:F2}");

    }

}