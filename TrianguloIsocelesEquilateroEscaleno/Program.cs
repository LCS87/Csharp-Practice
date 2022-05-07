// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        int ladoa, ladob, ladoc;
        Console.Write("\n\n");
        Console.Write("Indentificar se o Triangulo é Equilatero, Isósceles ou Escaleno:\n");
        Console.Write("----------------------------------------------------------------");
        Console.Write("\n\n");



        Console.Write("Digite o Primeiro Lado do Triangulo: ");
        ladoa = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Segundo Lado do Triangulo: ");
        ladob = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Terceiro Lado do Triangulo: ");
        ladoc = Convert.ToInt32(Console.ReadLine());



        if (ladoa == ladob && ladob == ladoc)
        {
            Console.Write("Esse é um Triangulo Equilatero.\n");
        }
        else if (ladoa == ladob || ladoa == ladoc || ladob == ladoc)
        {
            Console.Write("Esse é um Triangulo Isóceles.\n");
        }
        else
        {
            Console.Write("Esse é um Triangulo Escaleno.\n");
        }
    }
}
