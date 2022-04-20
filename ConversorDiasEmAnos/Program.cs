int dias, anos, semanas;

    Console.WriteLine("Digite os Dias: ");
    dias = Convert.ToInt32(Console.ReadLine());

   
    anos = (dias / 365);
    semanas = (dias % 365) / 7;
    dias = dias - ((anos * 365) + (semanas * 7));

Console.WriteLine("Anos    : "+ anos );
    Console.WriteLine("Semanas : "+ semanas);
    Console.WriteLine("Dias    : "+ dias);

   Console.ReadKey();
