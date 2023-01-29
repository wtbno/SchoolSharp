using System;


class Condicional
{
    static void Main(string[] args)
    {
        float nota1;

        float nota2;

        //Para atribuir essa váriavel, foi necessário subir o trecho de cod.
        //para que ao usuário inserir o valor da nota a mesma fosse declarada.
        System.Console.WriteLine("Insira a nota da sua primeira prova: ");
        nota1 = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Insira a nota da sua segunda prova: ");
        nota2 = float.Parse(Console.ReadLine());


        float mediaFinal, soma;
        soma = (nota1 + nota2);
        mediaFinal = soma / 2;

        System.Console.WriteLine("A sua média final é {0}", mediaFinal);
        if (mediaFinal >= 7)
            if (mediaFinal >= 9)
            //If aninhado
            {
                System.Console.WriteLine("Parabéns, você obteve uma boa nota final!!!");
            }
            else
            {
                System.Console.WriteLine("Você foi aprovado");
            }
        else if (mediaFinal >= 5)
        {
            System.Console.WriteLine("Você está de recuperação");
        }
        else
        {
            System.Console.WriteLine("Você foi reprovado");
            return;
        }
    }
}
