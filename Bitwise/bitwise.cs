using System;


class bitwise
{
    static void Main(string[] args)
    {
        int num = 10;
        int num2 = 10;
        num2 = num2 >> 1;
        // Desloca 1 casa pra direita
        num = num << 1;
        // Desloca 1 casa pra esquerda

        // << dobra o valor
        // >> reduz a metade
        System.Console.WriteLine(num);
        System.Console.WriteLine(num2);
    }
}