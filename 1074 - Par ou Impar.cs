using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int[] y = new int[x];

        for (int i = 0; i < x; i++)
        {
            y[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < y.Length; i++)
        {
            if (y[i] == 0)
            {
                Console.WriteLine("NULL");
            }
            else if (y[i] % 2 == 0)
            {
                if (y[i] > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }
            else
            {
                if (y[i] > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }

    }

}