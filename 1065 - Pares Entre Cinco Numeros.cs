using System;

class URI
{

    static void Main(string[] args)
    {

        int[] nums = new int[5];
        int par = 0;

        for (int i = 0; i < 5; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
            if (nums[i] % 2 == 0)
            {
                ++par;
            }
        }

        Console.WriteLine($"{par} valores pares");

    }

}