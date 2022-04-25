//https://www.beecrowd.com.br/repository/UOJ_1041.html
using System;

class URI
{

    static void Main(string[] args)
    {

        double x, y;
        string[] coords = Console.ReadLine().Split(' ');

        x = double.Parse(coords[0]);
        y = double.Parse(coords[1]);

        if (x > 0)
        {
            if (y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Eixo X");
            }
        }
        else if (x < 0)
        {
            if (y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Eixo X");
            }
        }
        else
        {
            if (y == 0)
            {
                Console.WriteLine("Origem");
            }
            else
            {
                Console.WriteLine("Eixo Y");
            }
        }

    }
}