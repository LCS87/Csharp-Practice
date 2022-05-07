// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        float r;
        float pi = 3.1415926535f;

        Console.Write("Raio: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine(4 * pi * (r * r));

        Console.WriteLine(4f / 3f * pi * (r * r * r));
    }
}
