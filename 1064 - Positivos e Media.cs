using System;

class URI
{

    static void Main(string[] args)
    {

        double[] nums = new double[6];
        double med = 0;
        int pos = 0;

        for (int i = 0; i < 6; i++)
        {
            nums[i] = float.Parse(Console.ReadLine());
            if (nums[i] > 0)
            {
                ++pos;
                med += nums[i];
            }
        }

        med /= pos;

        Console.WriteLine($"{pos} valores positivos");
        Console.WriteLine($"{med:F1}");

    }

}