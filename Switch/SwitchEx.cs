using System;

class SwitchEx
{
    static void Main(string[] args)
    {
        int tempo = 0;
        char escolha;

    inicio:
        //Label

        Console.Clear();


        System.Console.WriteLine("Sorocaba-SP a Curitiba-PR");
        System.Console.WriteLine("Selecione o transporte: [a]Avião | [b]Carro, | [c]Ônibus");
        escolha = char.Parse(Console.ReadLine());


        switch (escolha)
        {
            case 'a':
            case 'A':
                tempo = 40;
                break;
            case 'b':
            case 'B':
                tempo = 240;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            System.Console.WriteLine("Opção inválida.");
        }
        else
        {
            System.Console.WriteLine("Com o transporte escolhido, você levará {0} minutos para chegar os destino", tempo);
        }

        System.Console.WriteLine("Calcular com outro meio de transporte?[s/n]");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 's' | escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            System.Console.WriteLine("Obrigado por utilizar nossos serviços");
        }
    }
}


//"" Sinaliza uma string
//'' Serve como limitador de char
//Ao termino de cada case há um break