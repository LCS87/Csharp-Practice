// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio2
{
    public static void Main()
    {
        Console.Write("Digite um mumero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Tamanho do Triangulo: ");
        int width = Convert.ToInt32(Console.ReadLine());

        int height = width;
        for (int row = 0; row < height; row++)
        {
            for (int coluna = 0; coluna < width; coluna++)
            {
                Console.Write(num);
            }

            Console.WriteLine();
            width--;
        }
    }
}
