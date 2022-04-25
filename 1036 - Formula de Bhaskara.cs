using System;

class URI
{

    static void Main(string[] args)
    {

        double a, b, c, d;
        Array result = new Array[2];
        string[] nums = Console.ReadLine().Split(' ');

        a = double.Parse(nums[0]);
        b = double.Parse(nums[1]);
        c = double.Parse(nums[2]);

        result = Bhaskara(a, b, c);
        d = (Math.Pow(b, 2.0) - 4.0 * a * c);

        if (a == 0 || d < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            Console.WriteLine($"R1 = {result.GetValue(0):0.00000}");
            Console.WriteLine($"R2 = {result.GetValue(1):0.00000}");
        }

    }

    public static Array Bhaskara(double a, double b, double c)
    {
        double[] r = new double[2];

        r[0] = ((-b + Math.Sqrt(Math.Pow(b, 2.0) - 4.0 * a * c)) / (2.0 * a));
        r[1] = ((-b - Math.Sqrt(Math.Pow(b, 2.0) - 4.0 * a * c)) / (2.0 * a));

        return r;
    }

}