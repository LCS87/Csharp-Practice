// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio3
{
    public static void Main()
    {
        string username, password;
        int ctr = 0, dd = 0;
        Console.Write("\n\nChecar username e password :\n");
        Console.Write("Senha e login padrão é : username e password\n");
        Console.Write("---------------------------------\n");
        do
        {
            Console.Write("digite Nome de Usuario: ");
            username = Console.ReadLine();

            Console.Write("Digite a Senha: ");
            password = Console.ReadLine();
            if (username == "username" && password == "password")
            {
                dd = 1;
                ctr = 3;
            }

            else
            {
                dd = 0;
                ctr++;
            }
        }
        while ((username != "username" || password != "password")
                && (ctr != 3));
        if (dd == 0)
        {
            Console.Write("\n Voce errou 3 vezes, tente mais tarde!\n\n");
        }
        else
        if (dd == 1)
        {
            Console.Write("\n Login com Sucesso!!!!\n\n");
        }
    }
}
