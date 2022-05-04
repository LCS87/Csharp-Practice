// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {

        double r, per_cir;
        double PI = 3.14;
        Console.WriteLine("Digite o raio do circulo : ");
        r = Convert.ToDouble(Console.ReadLine());
        per_cir = 2 * PI * r;
        Console.WriteLine("O Perimento é : {0}", per_cir);
        Console.Read();
    }
}
