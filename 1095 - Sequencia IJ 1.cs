//https://www.beecrowd.com.br/repository/UOJ_1095.html
using System;

class URI
{

    static void Main(string[] args)
    {

        for (int i = 1, j = 60; j >= 0; j -= 5, i += 3)
        {
            Console.WriteLine($"I={i} J={j}");
        }

    }

}