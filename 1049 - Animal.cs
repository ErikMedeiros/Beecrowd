//https://www.beecrowd.com.br/repository/UOJ_1049.html
using System;

class URI
{

    static void Main(string[] args)
    {

        string[] words = new string[3];

        words[0] = Console.ReadLine();
        words[1] = Console.ReadLine();
        words[2] = Console.ReadLine();

        if (words[0] == "vertebrado")
        {
            if (words[1] == "ave")
            {
                if (words[2] == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else if (words[2] == "onivoro")
                {
                    Console.WriteLine("pomba");
                }
            }
            else if (words[1] == "mamifero")
            {
                if (words[2] == "herbivoro")
                {
                    Console.WriteLine("vaca");
                }
                else if (words[2] == "onivoro")
                {
                    Console.WriteLine("homem");
                }
            }
        }
        else if (words[0] == "invertebrado")
        {
            if (words[1] == "inseto")
            {
                if (words[2] == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else if (words[2] == "herbivoro")
                {
                    Console.WriteLine("lagarta");
                }
            }
            else if (words[1] == "anelideo")
            {
                if (words[2] == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else if (words[2] == "onivoro")
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }

}