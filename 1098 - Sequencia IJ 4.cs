//https://www.beecrowd.com.br/repository/UOJ_1098.html
using System;

class URI
{

    static void Main(string[] args)
    {

        for (double i = 0; i <= 2d; i += 0.2d)
        {
            for (double j = i + 1; j <= 3 + i; j++)
            {
                Console.WriteLine($"I={i:0.#} J={j:0.#}");
            }
        }

    }

}