//https://www.beecrowd.com.br/repository/UOJ_1115.html
using System;

class URI
{

    static void Main(string[] args)
    {

        string[] coords;
        int x, y;

        do
        {
            coords = Console.ReadLine().Split();
            x = int.Parse(coords[0]);
            y = int.Parse(coords[1]);

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                if (y < 0)
                {
                    Console.WriteLine("quarto");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("segundo");
                }
                if (y < 0)
                {
                    Console.WriteLine("terceiro");
                }
            }

        } while (x != 0 || y != 0);

    }

}