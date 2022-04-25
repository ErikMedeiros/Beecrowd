//https://www.beecrowd.com.br/repository/UOJ_1067.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

    }

}