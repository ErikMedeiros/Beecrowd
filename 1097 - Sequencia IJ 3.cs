//https://www.beecrowd.com.br/repository/UOJ_1097.html
using System;

class URI
{

    static void Main(string[] args)
    {

        for (int i = 1; i <= 9; i += 2)
        {
            for (int j = i + 6; j > i + 3; j--)
            {
                Console.WriteLine($"I={i} J={j}");
            }
        }

    }

}