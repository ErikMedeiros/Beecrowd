using System;

class URI
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        double[,] y = new double[x, 3];
        double[] med = new double[x];

        for (int row = 0; row < x; row++)
        {
            string[] nums = Console.ReadLine().Split(' ');

            for (int col = 0; col < 3; col++)
            {
                y[row, col] = double.Parse(nums[col]);
            }
        }

        for (int i = 0; i < x; i++)
        {
            med[i] = (y[i, 0] * 2 + y[i, 1] * 3 + y[i, 2] * 5) / 10;
            Console.WriteLine($"{med[i]:F1}");
        }

    }

}