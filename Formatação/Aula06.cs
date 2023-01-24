using System;

class Aula06
{
    static void Main()
    {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        System.Console.WriteLine("Produto.......:{0.15}", produto);
        System.Console.WriteLine("Valor de compra....:{0.15:c}", valorCompra);
        System.Console.WriteLine("Lucro.....:{0.15:p}", lucro);


    }
}