using System;

class Form
{
    static void Main(string[] args)
    {
        string nome;
        int idade;
        string cidade;
        string[] exames = new string[10] { "K", "Na", "Ur", "Creat", "Tgo", "Tgp", "ColT", "TSH", "T3", "T4" };

        // tipo[] nomeDoArray = new tipo[tamanho_do_array];


        System.Console.WriteLine("Por gentileza, informe seu nome");
        nome = Console.ReadLine();
        System.Console.WriteLine("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Informe a cidade de nasmento: ");
        cidade = Console.ReadLine();
        System.Console.WriteLine("O seu nome é {0} e sua idade é {1}, você é natural de {2}: ", nome, idade, cidade);


    }
}