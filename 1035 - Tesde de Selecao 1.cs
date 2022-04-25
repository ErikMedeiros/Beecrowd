using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c, d;
        string[] nums = Console.ReadLine().Split(' ');

        a = int.Parse(nums[0]);
        b = int.Parse(nums[1]);
        c = int.Parse(nums[2]);
        d = int.Parse(nums[3]);

        if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }

}