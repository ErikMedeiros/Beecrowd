//https://www.beecrowd.com.br/repository/UOJ_1073.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}^2 = {i * i}");
            }
        }

    }

}