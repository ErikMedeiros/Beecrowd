using System;

class URI
{

    static void Main(string[] args)
    {

        float salary, newSalary;
        float[] readjust = { 0.15f, 0.12f, 0.10f, 0.07f, 0.04f };

        salary = float.Parse(Console.ReadLine());

        if (salary <= 400d)
        {
            newSalary = (salary * readjust[0]) + salary;
            Console.WriteLine($"Novo salario: {newSalary:F2}\nReajuste ganho: {newSalary - salary:F2}\nEm percentual: {readjust[0] * 100} %");
        }
        else if (salary >= 400.01 && salary <= 800d)
        {
            newSalary = (salary * readjust[1]) + salary;
            Console.WriteLine($"Novo salario: {newSalary:F2}\nReajuste ganho: {newSalary - salary:F2}\nEm percentual: {readjust[1] * 100} %");
        }
        else if (salary >= 800.01 && salary <= 1200d)
        {
            newSalary = (salary * readjust[2]) + salary;
            Console.WriteLine($"Novo salario: {newSalary:F2}\nReajuste ganho: {newSalary - salary:F2}\nEm percentual: {readjust[2] * 100} %");
        }
        else if (salary >= 1200.01 && salary <= 2000d)
        {
            newSalary = (salary * readjust[3]) + salary;
            Console.WriteLine($"Novo salario: {newSalary:F2}\nReajuste ganho: {newSalary - salary:F2}\nEm percentual: {readjust[3] * 100} %");
        }
        else if (salary > 2000d)
        {
            newSalary = (salary * readjust[4]) + salary;
            Console.WriteLine($"Novo salario: {newSalary:F2}\nReajuste ganho: {newSalary - salary:F2}\nEm percentual: {readjust[4] * 100} %");
        }

    }

}