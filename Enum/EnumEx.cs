using System;

class EnumEx
{

    enum diasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado }

    static void Main(string[] args)
    {
        // diasSemana ds = diasSemana.Domingo;
        diasSemana ds = (diasSemana)5;
        // Conversão implicita - cast
        System.Console.WriteLine(ds);
    }
}