using System;

class Input
{
    static void Main(string[] args)
    {
        int idade;
        string nome;


        System.Console.WriteLine("Insira sua idade");
        idade = int.Parse(Console.ReadLine());
        //Conversão de str para int
        System.Console.WriteLine("Insira seu nome: ");
        nome = Console.ReadLine();
        System.Console.WriteLine("A sua idade é {0} e seu nome é {1}", idade, nome);




    }
}

// Converções int x str = conversões explicitas.