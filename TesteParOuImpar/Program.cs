// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        int n1, n2;
        bool bothEven;
        Console.Write("Digite o Primeiro Numero: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o Segundo Numero: ");
        n2 = Convert.ToInt32(Console.ReadLine());


        //bothEven = ((n1%2!=0) || (n1%2!=0))? false:true;
        bothEven = ((n1 % 2 == 0)
            && (n2 % 2 == 0)) ? true : false;

        Console.WriteLine(bothEven ?
          "Ambos são Par" :
          "Ha um Numero Impar");
    }
}
