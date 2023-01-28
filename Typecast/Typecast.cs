using System;

class Typecast
{
    static void Main(string[] args)
    {
        float n1 = 10.5f;
        int n2 = (int)n1;//type cast de float para int
        System.Console.WriteLine(n2);

    }
}


// Conversões implicitas = conversões seguras, ocorrem automaticamente, 
// como p.ex: alargamento de num. inteiro
// Conversões não implicitas (explicitas), são utilizadas
// convers. para poder exec. o cod, podem não ser possível como str para int