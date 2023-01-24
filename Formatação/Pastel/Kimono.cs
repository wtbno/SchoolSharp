using System;

class Kimono
{
    static void Main(string[] args)
    {
        double valorCompra = 500.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Kimono";

        valorVenda = valorCompra + (valorCompra * lucro);

        System.Console.WriteLine("Produto.......:{0,15}", produto);
        System.Console.WriteLine("Valor de compra....:{0,15:c}", valorCompra);
        System.Console.WriteLine("Lucro.....:{0,15:p}", lucro);
        System.Console.WriteLine("Valor de venda.....:{0,15:c}", valorVenda);


    }
}