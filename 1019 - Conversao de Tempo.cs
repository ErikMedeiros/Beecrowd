//https://www.beecrowd.com.br/repository/UOJ_1019.html
using System;

class URI
{

    static void Main(string[] args)
    {

        int s;
        s = int.Parse(Console.ReadLine());

        TimeSpan ts = TimeSpan.FromSeconds(s);
        Console.WriteLine($"{Math.Floor(ts.TotalHours)}:{(ts.Minutes)}:{(ts.Seconds)}");

    }

}