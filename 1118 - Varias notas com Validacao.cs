//https://www.beecrowd.com.br/repository/UOJ_1118.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int mainLoop;

        do
        {
            float[] notas = { -1, -1 };

            for (int i = 0; i < 2; i++)
            {
                bool success = float.TryParse(Console.ReadLine(), out notas[i]);

                while (!success || notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("nota invalida");
                    success = float.TryParse(Console.ReadLine(), out notas[i]);
                }
            }

            Console.WriteLine($"media = {(notas[0] + notas[1]) / 2:.00}");
            Console.WriteLine("novo calculo (1-sim 2-nao)");

            bool loopCheck = int.TryParse(Console.ReadLine(), out mainLoop);

            while (mainLoop < 1 || mainLoop > 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                loopCheck = int.TryParse(Console.ReadLine(), out mainLoop);
            }
        } while (mainLoop == 1);
    }

}