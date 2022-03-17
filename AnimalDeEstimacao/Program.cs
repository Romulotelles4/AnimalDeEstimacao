using System;

namespace AnimalDeEstimacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            
            int contcachorro = 0, contgato = 0, contpeixe = 0;

            //Primeiro animal
            Console.WriteLine("Qual o nome do primeiro animal? ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do primeiro animal? ");
            a1.Tipo = Console.ReadLine();

            if(a1.Tipo == "cachorro") contcachorro++;
            if(a1.Tipo == "gato") contgato++;
            if(a1.Tipo =="peixe") contpeixe++;

            //Segundo animal
            Console.WriteLine("Qual o nome do segundo animal? ");
            a2.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do segundo animal? ");
            a2.Tipo = Console.ReadLine();

            if (a2.Tipo == "cachorro") contcachorro++;
            if (a2.Tipo == "gato") contgato++;
            if (a2.Tipo == "peixe") contpeixe++;
            
            //Terceiro animal
            Console.WriteLine("Qual o nome do terceiro animal? ");
            a3.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do terceiro animal? ");
            a3.Tipo = Console.ReadLine();

            if (a3.Tipo == "cachorro") contcachorro++;
            if (a3.Tipo == "gato") contgato++;
            if (a3.Tipo == "peixe") contpeixe++;

            //Quarto animal
            Console.WriteLine("Qual o nome do quarto animal? ");
            a4.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do quarto animal? ");
            a4.Tipo = Console.ReadLine();

            if (a4.Tipo == "cachorro") contcachorro++;
            if (a4.Tipo == "gato") contgato++;
            if (a4.Tipo == "peixe") contpeixe++;

            //Quinto animal
            Console.WriteLine("Qual o nome do quinto animal? ");
            a5.Nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do quinto animal? ");
            a5.Tipo = Console.ReadLine();

            if (a5.Tipo == "cachorro") contcachorro++;
            if (a5.Tipo == "gato") contgato++;
            if (a5.Tipo == "peixe") contpeixe++;

            Console.Clear();
            Console.WriteLine("Quantidade de cachorros: " + contcachorro);
            Console.WriteLine("Quantidade de gatos: " + contgato);
            Console.WriteLine("Quantidade de peixes: " + contpeixe);
            Console.ReadKey();


        }
    }
}
