using System;

class URI
{

    static void Main(string[] args)
    {

        int iniH, finH;
        string[] nums = Console.ReadLine().Split(' ');

        iniH = int.Parse(nums[0]);
        finH = int.Parse(nums[1]);

        if (iniH == finH)
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
        else if (finH < iniH)
        {
            Console.WriteLine($"O JOGO DUROU {24 - (iniH - finH)} HORA(S)");
        }
        else if (finH > iniH)
        {
            Console.WriteLine($"O JOGO DUROU {finH - iniH} HORA(S)");
        }

    }

}