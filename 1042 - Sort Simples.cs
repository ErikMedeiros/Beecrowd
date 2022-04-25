//https://www.beecrowd.com.br/repository/UOJ_1042.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x, y, z;
        string[] nums = Console.ReadLine().Split(' ');

        x = int.Parse(nums[0]);
        y = int.Parse(nums[1]);
        z = int.Parse(nums[2]);

        int max = Math.Max(Math.Max(x, y), z);
        int min = Math.Min(Math.Min(x, y), z);

        Console.WriteLine(min);
        Console.WriteLine((x + y + z) - min - max);
        Console.WriteLine(max);

        Console.WriteLine();

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

    }

}