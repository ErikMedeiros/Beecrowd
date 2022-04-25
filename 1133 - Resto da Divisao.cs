//https://www.beecrowd.com.br/repository/UOJ_1133.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        for (int i = Math.Min(a, b) + 1; i < Math.Max(a, b); i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }

    }

}