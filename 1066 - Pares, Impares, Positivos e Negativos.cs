using System;

class URI
{

    static void Main(string[] args)
    {

        int[] nums = new int[5];
        int par = 0;
        int impar = 0;
        int pos = 0;
        int neg = 0;

        for (int i = 0; i < 5; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());

            if (nums[i] % 2 == 0)
            {
                ++par;
            }
            else
            {
                ++impar;
            }

            if (nums[i] > 0)
            {
                ++pos;
            }
            else if (nums[i] < 0)
            {
                ++neg;
            }
        }

        Console.WriteLine($"{par} valor(es) par(es)");
        Console.WriteLine($"{impar} valor(es) impar(es)");
        Console.WriteLine($"{pos} valor(es) positivo(s)");
        Console.WriteLine($"{neg} valor(es) negativo(s)");

    }

}