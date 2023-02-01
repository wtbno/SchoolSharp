using System;


class ArrayEx
{
    static void Main(string[] args)
    {
        //int n1, n2, n3, n4, n5;
        int[] n = new int[5]; //0 a 4
        int[] num = new int[3] { 99, 55, 33 };
        //Não é possível inserir mais valores do que os declarados no array
        int[] num = { 55, 99, 33 };

        //tipo-operador-nome - atribuição
        //str - [] - carro  
        //Atribuição
        //veículo[0]="carro"


        n[0] = 37;
        n[1] = 49;
        n[2] = 55;
        n[3] = 14;
        n[4] = 98;

        System.Console.WriteLine(n[4]);
    }
}