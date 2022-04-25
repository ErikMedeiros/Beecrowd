using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, c, perimetro, area;
        string[] nums = Console.ReadLine().Split(' ');

        a = double.Parse(nums[0]);
        b = double.Parse(nums[1]);
        c = double.Parse(nums[2]);

        if (b - c < a && a < b + c && a - c < b && b < a + c && a - b < c && c < a + b)
        {
            perimetro = a + b + c;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            area = ((a + b) * c) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }

}