using System;

class URI
{

    static void Main(string[] args)
    {

        float a, b, c, min, max;
        string[] nums = Console.ReadLine().Split(' ');

        a = float.Parse(nums[0]);
        b = float.Parse(nums[1]);
        c = float.Parse(nums[2]);

        max = Math.Max(Math.Max(a, b), c);
        min = Math.Min(Math.Min(a, b), c);

        b = (a + b + c) - (min + max);
        a = max;
        c = min;

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (a * a == (b * b) + (c * c))
        {
            Console.WriteLine("TRIANGULO RETANGULO");

            if (a == b && a == c && c == b)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
        else if (a * a > (b * b) + (c * c))
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");

            if (a == b && a == c && c == b)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
        else if (a * a < (b * b) + (c * c))
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");

            if (a == b && a == c && c == b)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }

    }

}