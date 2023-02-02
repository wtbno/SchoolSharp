using System;


class DoWhile
{

    static void Main(string[] args)
    {
        string senha = "123";
        string senhauser;
        int tentativas = 0;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Insira sua senha");
            senhauser = Console.ReadLine();
            tentativas++;

        } while (senha != senhauser);

        Console.Clear();
        System.Console.WriteLine("Senha correta, número de tentativas {0}", tentativas);




    }
}

//Do While garante que o prog será executado pelo menos uma vez