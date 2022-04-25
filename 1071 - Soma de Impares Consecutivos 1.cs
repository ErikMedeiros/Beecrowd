//https://www.beecrowd.com.br/repository/UOJ_1071.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int som = 0;

        for (int i = y + 1; i < x; i++)
        {
            if (i % 2 == 1 || i % 2 == -1)
            {
                som += i;
            }
        }

        Console.WriteLine(som);
    }

}