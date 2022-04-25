using System;

class URI
{

    static void Main(string[] args)
    {

        string[] nums = Console.ReadLine().Split(' ');
        string[] nums1 = Console.ReadLine().Split(' ');
        double a, aa, b, bb, result;

        a = double.Parse(nums[0]);
        aa = double.Parse(nums[1]);
        b = double.Parse(nums1[0]);
        bb = double.Parse(nums1[1]);

        result = Distancia(a, aa, b, bb);

        Console.WriteLine($"{result:0.0000}");

    }

    public static double Distancia(double x, double y, double xx, double yy)
    {
        return Math.Sqrt(Math.Pow(xx - x, 2) + Math.Pow(yy - y, 2));
    }
}