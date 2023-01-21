using System;

class Variaveis
{
    static void Main()
    {
        byte n1 = 10; // armazena entre 0 e 255
        int num = 32;
        char letras = 'c';
        float flutuante = 5.98f;
        string texto = "Olá mundo! ";

        var aux = texto;

        System.Console.WriteLine(aux + "Tudo bem?");

    }
}