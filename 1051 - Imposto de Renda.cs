using System;

class URI
{

    static void Main(string[] args)
    {

        float salary, imposto;

        salary = float.Parse(Console.ReadLine());

        if (salary <= 2000f)
        {
            Console.WriteLine("Isento");
        }
        else if (salary >= 2000.01f && salary <= 3000f)
        {
            imposto = (salary - 2000f) * 0.08f;
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (salary >= 3000.01f && salary <= 4500f)
        {
            imposto = 1000f * 0.08f + (salary - 3000f) * 0.18f;
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (salary > 4500f)
        {
            imposto = 1000f * 0.08f + 1500 * 0.18f + (salary - 4500f) * 0.28f;
            Console.WriteLine($"R$ {imposto:F2}");
        }

    }

}