//https://www.beecrowd.com.br/repository/UOJ_1116.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        int a, b;
        double[] div = new double[x];

        for (int i = 0; i < x; i++)
        {
            string[] nums = Console.ReadLine().Split();
            a = int.Parse(nums[0]);
            b = int.Parse(nums[1]);

            if (b == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                div[i] = (double)a / (double)b;
                Console.WriteLine($"{div[i]:F1}");
            }
        }

    }

}