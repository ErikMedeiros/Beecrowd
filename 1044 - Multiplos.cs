using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, multi;
        string[] nums = Console.ReadLine().Split(' ');

        a = int.Parse(nums[0]);
        b = int.Parse(nums[1]);

        multi = Math.Max(a, b) / Math.Min(a, b);

        if (multi * b == a || multi * a == b)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}