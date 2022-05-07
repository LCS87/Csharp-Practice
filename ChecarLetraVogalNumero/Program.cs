// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        char caracter;

        Console.Write("Digite um Caractere: ");
        caracter = Convert.ToChar(Console.ReadLine());

        if ((caracter == 'a') || (caracter == 'e') || (caracter == 'i') ||
                (caracter == 'o') || (caracter == 'u'))
            Console.WriteLine("Isso é uma vogal Minuscula.");
        else if ((caracter >= '0') && (caracter <= '9'))
            Console.WriteLine("Isso é um Digito");
        else
            Console.Write("Isso e outro tipo de Carctere.");
    }
}
