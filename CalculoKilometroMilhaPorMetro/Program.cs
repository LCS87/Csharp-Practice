// See https://aka.ms/new-console-template for more information
using System;
public class Exercicio
{
    public static void Main()
    {
        float distancia;
        float hour, min, sec;

        float timeSec;
        float mps;
        float kph, mph;

        Console.Write("Entre com a Distancia em Metros: ");
        distancia = Convert.ToSingle(Console.ReadLine());
        Console.Write("Entre com o Tempo em Horas: ");
        hour = Convert.ToSingle(Console.ReadLine());
        Console.Write("Entre com o Tempo em Minutos: ");
        min = Convert.ToSingle(Console.ReadLine());
        Console.Write("Entre com o tempo em Segundos: ");
        sec = Convert.ToSingle(Console.ReadLine());

        timeSec = (hour * 3600) + (min * 60) + sec;
        mps = distancia / timeSec;
        kph = (distancia / 1000.0f) / (timeSec / 3600.0f);
        mph = kph / 1.609f;

        Console.WriteLine("Sua Velocidade em metros/segundos é {0}:", mps);
        Console.WriteLine("Sua Veolicidade em km/h é {0}", kph);
        Console.WriteLine("Sua Velocidade em milhas/hora é {0}", mph);
    }
}
