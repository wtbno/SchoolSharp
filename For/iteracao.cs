using System;


class iteracao
{

    static void Main(string[] args)
    {


        int[] num = new int[10];

        for (int i = 0; i < 10; i++)
        {//Testa > incrementa > executa
            num[i] = 0;

            System.Console.WriteLine("Valor da atribuição {0}", num[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            num[i] = 0;
            //o escopo de i é o for

            System.Console.WriteLine("Valor de num na pos{0}: {1}", i, num[i]);
        }



        //pode ser utilizado a declaração da var fora ou dentro do loop
        // for (int numero = 0; numero < 1000000; numero++)
        // {
        //     System.Console.WriteLine("Valor do número {0}", numero);
        // }
        //Enquanto for verdadeira, o loop é executada, quando falsa, pula para o próximo passo


    }
}