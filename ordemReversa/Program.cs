// See https://aka.ms/new-console-template for more information

public class Exercicio
{
    public static void Main()
    {
        char letra, letra1, letra2;

        Console.Write("Digite a Primeira Letra: ");
        letra = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite a Segunda Letra: ");
        letra1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite a Terceira Letra: ");
        letra2 = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("{0} {1} {2}", letra2, letra1, letra);
    }
}