//https://www.beecrowd.com.br/repository/UOJ_1114.html
using System;

class URI
{

    static void Main(string[] args)
    {

        string password;

        do
        {
            password = Console.ReadLine();

            if (password != "2002")
            {
                Console.WriteLine("Senha Invalida");
            }
            else
            {
                Console.WriteLine("Acesso Permitido");
            }
        } while (password != "2002");

    }

}