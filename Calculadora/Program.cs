using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            double num1, num2;
            int resultado = 0;

            Console.WriteLine("Digitew o primeiro Numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Clear();

            while(resultado != 5)
            {
                Console.WriteLine("Para soma digite 1");
                Console.WriteLine("Para subtrair digite 2");
                Console.WriteLine("Para multiplicar digite 3");
                Console.WriteLine("Para dividir digite 4");
                Console.WriteLine("Para sair digite 5");
                resultado = int.Parse(Console.ReadLine());
                if (resultado == 1)
                {
                    Console.WriteLine("Soma = {0}", num1 + num2);
                }
                if (resultado == 2)
                {
                    Console.WriteLine("Subtração = {0}", num1 - num2);
                }
                if (resultado == 3)
                {
                    Console.WriteLine("Multilicação = {0}", num1 * num2);
                }
                if (resultado == 4)
                {
                    Console.WriteLine("Divisão = {0}", num1 / num2);
                }
                Console.ReadLine();
                Console.Clear();




            }
        }
    }
}
