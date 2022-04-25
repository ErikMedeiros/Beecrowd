using System;

class URI
{

    static void Main(string[] args)
    {

        int funcioNum, hTrab;
        double valPorH, salario;

        funcioNum = int.Parse(Console.ReadLine());
        hTrab = int.Parse(Console.ReadLine());
        valPorH = double.Parse(Console.ReadLine());

        salario = valPorH * hTrab;

        Console.WriteLine($"NUMBER = {funcioNum}\nSALARY = U$ {salario:0.00}");

    }

}