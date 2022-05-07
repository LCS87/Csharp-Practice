// See https://aka.ms/new-console-template for more information

using System;
public class Exercicio
{
    public static void Main()
    {
        int tmp;
        Console.Write("\n\n");
        Console.Write("Como Esta a Temperaura do Dia:\n");
        Console.Write("--------------------------------");
        Console.Write("\n\n");

        Console.Write("Digite a Temepra do Dia  : ");
        tmp = Convert.ToInt32(Console.ReadLine());
        if (tmp < 0)
            Console.Write("Clima congelante.\n");
        else if (tmp < 10)
            Console.Write("Clima Muito Frio.\n");
        else if (tmp < 20)
            Console.Write("clima Frio.\n");
        else if (tmp < 30)
            Console.Write("Temperatura Normal.\n");
        else if (tmp < 40)
            Console.Write("Esta Quente.\n");
        else
            Console.Write("Esta Muito Quente.\n");

    }
}