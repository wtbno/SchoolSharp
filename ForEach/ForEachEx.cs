using System;


class ForEx
{

    static void Main(string[] args)
    {

        int[] num = new int[4] { 11, 12, 14, 15 };
        foreach (int n in num)
        //variável n vai receber as variáveis presentes em num
        {
            System.Console.WriteLine(n);
        }

    }
}

//For padrão para atribuição ou inicialização
//Foreach pra leitura dentro de uma coleção