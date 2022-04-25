//https://www.beecrowd.com.br/repository/UOJ_1072.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int[] y = new int[x];
        int[] inOut = { 0, 0 };

        for (int i = 0; i < x; i++)
        {
            y[i] = int.Parse(Console.ReadLine());

            if (y[i] >= 10 && y[i] <= 20)
            {
                inOut[0]++;
            }
            else
            {
                inOut[1]++;
            }
        }

        Console.WriteLine($"{inOut[0]} in\n{inOut[1]} out");
    }

}