//https://www.beecrowd.com.br/repository/UOJ_1047.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int iniH, iniM, finH, finM, minI, minF;
        string[] nums = Console.ReadLine().Split(' ');

        iniH = int.Parse(nums[0]);
        iniM = int.Parse(nums[1]);
        finH = int.Parse(nums[2]);
        finM = int.Parse(nums[3]);

        minI = (iniH * 60) + iniM;
        minF = (finH * 60) + finM;

        if (minI == minF)
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }
        else if (minF < minI)
        {
            Console.WriteLine($"O JOGO DUROU {(1440 - (minI - minF)) / 60} HORA(S) E {(1440 - (minI - minF)) % 60} MINUTO(S)");
        }
        else if (minF > minI)
        {
            Console.WriteLine($"O JOGO DUROU {(minF - minI) / 60} HORA(S) E {(minF - minI) % 60} MINUTO(S)");
        }

    }

}