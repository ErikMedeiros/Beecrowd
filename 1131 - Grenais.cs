//https://www.beecrowd.com.br/repository/UOJ_1131.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int grenais = 0;
        int vitoriasInter = 0, vitoriasGremio = 0, empates = 0;
        int loop;

        do
        {
            string[] gols = Console.ReadLine().Split(' ');
            int golsInter = int.Parse(gols[0]);
            int golsGremio = int.Parse(gols[1]);

            if (golsInter > golsGremio)
                vitoriasInter += 1;
            else if (golsGremio > golsInter)
                vitoriasGremio += 1;
            else
                empates += 1;

            grenais += 1;

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            loop = int.Parse(Console.ReadLine());
        } while (loop == 1);

        Console.WriteLine($"{grenais} grenais");
        Console.WriteLine($"Inter:{vitoriasInter}");
        Console.WriteLine($"Gremio:{vitoriasGremio}");
        Console.WriteLine($"Empates:{empates}");

        if (vitoriasInter > vitoriasGremio)
            Console.WriteLine("Inter venceu mais");
        else if (vitoriasGremio > vitoriasInter)
            Console.WriteLine("Gremio venceu mais");
        else
            Console.WriteLine("Nao houve vencedor");

    }

}