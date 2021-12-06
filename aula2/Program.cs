using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args) //classe pricipal;
        {
            Console.WriteLine("Entrada de dados");
            Console.WriteLine("Digite o seu nome");

            string nomeDoUsuario = Console.ReadLine();

            Console.WriteLine("O nome digitado é: " + nomeDoUsuario);


        }


        public static void Inicio()
        {

            //COMO DECLARAR UMA VARIAVEL.
            // TIPO depois o NOME ; <- no final de todas as linhas.

            //linha verde = a variavel criada não esta sendo utilizada.

            //linha vermelha = esta falando algo, vai dar erro de compilação.

            // 1 sinal de igual representa atribuição.

            string nome = "Lucas";
            int idade = 28;

            //Console.WriteLine(nome);
            //Console.WriteLine(idade);
            Console.WriteLine(nome + " " + idade);


        }

        public static void OperadorAritmetico()
        {

            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;

            Console.WriteLine("Soma de todos os números: " + (primeiro + segundo + terceiro));
            Console.WriteLine("Subtração: " + (terceiro - segundo - primeiro));
            Console.WriteLine("Multiplicação: " + (terceiro * segundo * primeiro));
            Console.WriteLine("Divisão: " + (terceiro / segundo));
        }

        public static void OperadorAtribucao()
        {
            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("------------");

            a += 2;
            Console.WriteLine(a);
            Console.WriteLine("------------");


            string alfabeto = "ABC";
            alfabeto += "DEF";
            Console.WriteLine(alfabeto);

            Console.WriteLine("------------");

            a = 10; //receber 10.
            a *= 3; //10 * 3;
            Console.WriteLine(a);

        }

        public static void OperadorRelacional()
        {


            int a = 10;
            bool resposta = a >= 10; //resposta sempre será TRUE OU FALSE.

            Console.WriteLine("Valor da resposta:" + resposta);


            bool menor = a < 10;
            bool maiorIgual = a >= 30;
            bool igual = (a == 10);  //igualdade
            bool diferente = (a != 10); //diferente.


            Console.WriteLine("Valor da resposta menor :" + menor);
            Console.WriteLine("Valor da resposta maiorIgual :" + maiorIgual);
            Console.WriteLine("Valor da resposta igual :" + igual);
            Console.WriteLine("Valor da resposta diferente :" + diferente);

        }

        public static void OperadorLogico()
        {


            int salario1 = 100;
            int salario2 = 50;
            int salario3 = 200;

            //Quero saber se o salario1 é maior que o 2 e tbm maior que o 3.

            //&& significa E
            bool resultadoSalario = salario1 > salario2 && salario1 > salario3;

            // primeira condicao = (TRUE OU FALSE) E ( TRUE OU FALSE)

            //Console.WriteLine(resultadoSalario);


            //Quero saber se o salario 2 menor que o salario 1 ou maior que salario 3
            bool resultado2 = salario2 < salario1 || salario2 > salario3;
            //TRUE                 //FALSE


            //Console.WriteLine(resultado2);


            //Quero saber se o salario2  é maior que o salario 3
            bool resultado3 = !(salario2 > salario3);
            //! quer saber do contrario.

            //! = quero saber se é falso.


            Console.WriteLine(resultado3);


        }



    }
}



using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para executar basta retirar o comentario da função desejada.

            //POR EXEMPLO: abaixo vai ser executado apenas Switch.


           // CondicaoIf();
           // CondicaoELSE();
           // CondicaoComElseIF();
           // CondicaoComElseIF();
            Switch();
           // While();
           // DoWhile();
           // For();

        }
        public static void CondicaoIf()
        {
            //IF (SE) -> Operador logico - TRUE OU FALSE.

            //IF (SE) .

            //ELSE -> SENAO;

            int hora = 10;

            if (hora > 12) //irá executar apenas se o resultado for TRUE. 
            {
                Console.WriteLine("Boa tarde!");
            }



        }

        public static void CondicaoELSE()
        {
            //IF (SE) -> Operador logico - TRUE OU FALSE.


            //IF (SE) .

            //ELSE -> SENAO;

            int hora = 10;

            if (hora > 12) //irá executar apenas se o resultado for TRUE. 
            {
                Console.WriteLine("Boa tarde!");
            }
            else //SENÃO; = FALSE PARA A CONDIÇÃO DE CIMA.
            {
                Console.WriteLine("Bom dia");
            }

        }

        public static void CondicaoComElseIF()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());


            if (hora < 12) //SE A HORA É MENOR QUE 12;
            {
                Console.WriteLine("Bom dia!");
            }

            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }

            else //se nao acontecer nenhuma das condições acima.
            {
                Console.WriteLine("Boa noite!");
            }


            //DICA 
            if (hora < 12) //é menor que 12? 
                Console.WriteLine("Bom dia!");

            else if (hora < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");


        }

        public static void Switch()
        {
            //SWITCH
            //vai executar um bloco de comando de acordo coma correspondência.

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            switch (hora)
            {
                case < 12: Console.WriteLine("Bom dia!"); break;
                case < 18: Console.WriteLine("Boa tarde!"); break;
                default: Console.WriteLine("Boa noite!"); break;
            }


            //codição para string.
            string nome = "LUCAS";


            switch (nome)
            {
                case "IGOR": Console.WriteLine("nao vai entrar"); break;
                case "LUCAS": Console.WriteLine("Boa tarde! Lucas."); break;
                default: Console.WriteLine("nao vai entrar"); break;
            }




        }

        public static void While()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            int soma = 0;

            //enquanto for diferente de 0, somar os valores.

            while (numero != 0)  //condicao verdeira.
            {
                soma += numero;
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
            };

            Console.WriteLine(soma);


        }

        public static void DoWhile()
        {

            //DO = faça.
            //WHILE = enquanto

            int numero = 1;

            do //faça
            {
                Console.WriteLine(numero);
                numero++; // ++ somar mais 1. 
            }
            while (numero <= 100);

            //-------------------------------------

            int numeroUsuario;

            //Console.ReadLine()  --> STRING.
            //numeroUsuario  --->INT. 
            //numeroUsuario = int.Parse()
            //Parse realiza a conversao de tipo.

            do
            {
                Console.WriteLine("Digite um número:");
                numeroUsuario = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}:", numeroUsuario);
            }
            while (numeroUsuario != 0);
        }

        public static void For()
        {
            //FOR 

            //i = 1 comecar no numero 1.
            // condicao <= 100 .
            // ++ (1 por 1)




            for (double numero = 1; numero <= 4; numero += 0.2)
            {
                Console.WriteLine(numero);
            }



        }


    }
}





sing System; 

namespace aula04
{
    internal class Program
    {

        //void nao vai ter retorno.
        //Main classe principal do nosso principal.      


        /// <summary>
        /// Aqui se encontra a main e eu utilizei 3 / par abrir esse comentario.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //comentario em linha.

            /*
             * 
             * comentarios
             * mais
             * de
             * uma
             * linha
            
             */


        }


        public static void For()
        {
            //FOR 

            //i = 1 comecar no numero 1.
            // condicao <= 100 .
            // ++ (1 por 1)


            for (double numero = 1; numero <= 4; numero += 0.2)
            {
                Console.WriteLine(numero);
            }



        }

        public static void Array()
        {

            //array  ("VETOR") = uma sequencia não ordenada de itens.

            //int numero = 4;
            //int numero2 = 8;

            int[] numero_loteria = { 4, 8, 15, 16, 23, 42 };
            //posicoes 0 , 1, 2, 3, 4,  5  

            Console.WriteLine("A posição 0 é: " + numero_loteria[0]);

            Console.WriteLine("A quantidade de itens é: " + numero_loteria.Length);


            // numero <= 5;
            for (int numero = 0; numero < numero_loteria.Length; numero++)
            {
                Console.WriteLine("Está na posição: " + numero);
                Console.WriteLine("Valor do numero_loteria: " + numero_loteria[numero]);
            }



        }

        public static void Foreach()
        {
            int[] numero_loteria = { 4, 8, 15, 16, 23, 42 };


            foreach (var numero in numero_loteria)
            {
                Console.WriteLine("O item do array é: " + numero);
            }
        }
    }
}