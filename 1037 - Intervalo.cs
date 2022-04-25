using System;

class URI
{

    static void Main(string[] args)
    {

        string[] ranges = { "[0,25]", "(25,50]", "(50,75", "(75,100]" };
        double i;

        i = double.Parse(Console.ReadLine());

        if (i >= 0 && i <= 25)
        {
            Console.WriteLine($"Intervalo {ranges[0]}");
        }
        else if (i > 25 && i <= 50)
        {
            Console.WriteLine($"Intervalo {ranges[1]}");
        }
        else if (i > 50 && i <= 75)
        {
            Console.WriteLine($"Intervalo {ranges[2]}");
        }
        else if (i > 75 && i <= 100)
        {
            Console.WriteLine($"Intervalo {ranges[3]}");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }

    }

}