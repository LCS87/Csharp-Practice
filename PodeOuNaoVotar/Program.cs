

int eleitor;

Console.WriteLine("Digite a idade do eleitor: ");
eleitor = Convert.ToInt32(Console.ReadLine());

   if(eleitor  < 18)
    {
    Console.WriteLine("Desculpa mas voce nã opode votar!");   
    }
   else
   {
    Console.WriteLine("Parabens! voce esta apto para votar.");
    }

   Console.ReadLine();