using System;

class URI
{

    static void Main(string[] args)
    {

        float[] nums = new float[6];
        int pos = 0;

        for (int i = 0; i < 6; i++)
        {
            nums[i] = float.Parse(Console.ReadLine());
            if (nums[i] > 0)
            {
                ++pos;
            }
        }

        Console.WriteLine($"{pos} valores positivos");

    }

}