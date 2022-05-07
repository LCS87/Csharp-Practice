// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        int num1, num2, opt;

        Console.Write("\n\n");
        Console.Write("Calculadora Simples:\n");
        Console.Write("------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Diigte o Primeiro numero:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo Numero :");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.Write("\nEscolha uma Opção :\n");
        Console.Write("1-Soma.\n2-Substração.\n3-Multiplicação.\n4-Divisão.\n5-Sair.\n");
        Console.Write("\nDigite a Operação :");
        opt = Convert.ToInt32(Console.ReadLine());

        switch (opt)
        {
            case 1:
                Console.Write("Soma  {0} e {1} é: {2}\n", num1, num2, num1 + num2);
                break;

            case 2:
                Console.Write("Subtração {0}  e {1} é: {2}\n", num1, num2, num1 - num2);
                break;

            case 3:
                Console.Write("Multiplicaçõa {0} e {1} é: {2}\n", num1, num2, num1 * num2);
                break;

            case 4:
                if (num2 == 0)
                {
                    Console.Write("O segundo digito é Zero.Divisão por Zero.\n");
                }
                else
                {
                    Console.Write("Divisão {0} e {1} é : {2}\n", num1, num2, num1 / num2);
                }
                break;

            case 5:
                break;

            default:
                Console.Write("Digite uma Opção Valida\n");
                break;
        }
    }
}