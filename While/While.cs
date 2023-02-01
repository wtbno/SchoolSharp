using System;


class iteracao
{

    static void Main(string[] args)
    {


        int[] num = new int[10];

        /*
        iniciar a vairável contadora fora do while
        expressão contadora fica dentro do while
        */

        int i = 0;
        while (i < num.Length)
        {

            num[i] = 0;

            Console.WriteLine(num[i]);
            i++;

        }
        System.Console.WriteLine("Fim do loop");



    }
}