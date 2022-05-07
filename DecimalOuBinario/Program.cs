// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        string responda;
        string resultado;

        Console.Write("Input a Number : ");
        responda = Console.ReadLine();

        int num = Convert.ToInt32(responda);
        resultado = "";
        while (num > 1)
        {
            int restante = num % 2;
            resultado = Convert.ToString(restante) + resultado;
            num /= 2;
        }
        resultado = Convert.ToString(num) + resultado;
        Console.WriteLine("Binary: {0}", resultado);
    }
}
