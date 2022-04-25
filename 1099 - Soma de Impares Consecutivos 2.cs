//https://www.beecrowd.com.br/repository/UOJ_1099.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int w = int.Parse(Console.ReadLine());
        int max, min;
        int[] som = new int[w];

        for (int j = 0; j < w; j++)
        {
            string[] nums = Console.ReadLine().Split(' ');
            max = Math.Max(int.Parse(nums[0]), int.Parse(nums[1]));
            min = Math.Min(int.Parse(nums[0]), int.Parse(nums[1]));

            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 == 1 || i % 2 == -1)
                {
                    som[j] += i;
                }
            }
        }

        for (int i = 0; i < w; i++)
        {
            Console.WriteLine(som[i]);
        }

    }

}