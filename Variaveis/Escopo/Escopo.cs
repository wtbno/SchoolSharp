using System;

class Escopo
{

    //Escopo global
    static int num = 100;

    //Variaveis locais:
    //static void Main()
    //{
    //  int numero = 10;
    //}
    //Numero está dentro do escopo main, e não está acessível em teste.
    static void Main()
    {
        int numero = 50;
        System.Console.WriteLine(num);
    }
}