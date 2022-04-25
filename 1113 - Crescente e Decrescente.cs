//https://www.beecrowd.com.br/repository/UOJ_1113.html
using System;

class URI
{

    static void Main(string[] args)
    {

        string[] nums;

        do
        {
            nums = Console.ReadLine().Split();

            if (int.Parse(nums[0]) > int.Parse(nums[1]))
            {
                Console.WriteLine("Decrescente");
            }
            else if (int.Parse(nums[1]) > int.Parse(nums[0]))
            {
                Console.WriteLine("Crescente");
            }

        } while (nums[0] != nums[1]);

    }

}