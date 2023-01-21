using System;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Inicio C#");
            if (args.GetLength(0) > 0)
            {
                System.Console.WriteLine(args.GetValue(1));
            }
            //Formas de utilização de argumentos de entrada
        }
    }
}