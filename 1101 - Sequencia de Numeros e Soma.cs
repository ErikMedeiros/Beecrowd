//https://www.beecrowd.com.br/repository/UOJ_1101.html
using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {

        string[] nums;
        int aux = 0;
        List<int> min = new List<int>();
        List<int> max = new List<int>();
        List<int> som = new List<int>();

        for (int i = 1; i > 0; i++)
        {
            nums = Console.ReadLine().Split();
            min.Add(Math.Min(int.Parse(nums[0]), int.Parse(nums[1])));
            max.Add(Math.Max(int.Parse(nums[0]), int.Parse(nums[1])));

            if (min[i - 1] <= 0 || max[i - 1] <= 0)
            {
                min[i - 1] = 0;
                max[i - 1] = 0;
                i = -1;
            }
        }

        for (int i = 0; i < max.Count - 1; i++)
        {
            aux = 0;
            for (int j = min[i]; j <= max[i]; j++)
            {
                Console.Write($"{j} ");
                aux += j;

                if (j == max[i])
                {
                    som.Add(aux);
                }
            }
            Console.WriteLine($"Sum={som[i]}");
        }

    }

}