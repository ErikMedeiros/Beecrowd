//https://www.beecrowd.com.br/repository/UOJ_1013.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int a, b, c;
        string[] nums = Console.ReadLine().Split(' ');

        a = int.Parse(nums[0]);
        b = int.Parse(nums[1]);
        c = int.Parse(nums[2]);

        Console.WriteLine($"{Maior(Maior(a, b), c)} eh o maior");
    }

    public static int Maior(int a, int b)
    {
        return (a + b + Math.Abs(a - b)) / 2;
    }

}