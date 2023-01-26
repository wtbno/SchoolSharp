using System;


// As tuplas no C# são uma estrutura de dados do tipo de referência que podem armazenar valores de diferentes tipos.

// A principal vantagem de uma tupla é permitir o armazenamento de múltiplos tipos, como por exemplo uma string e um int ao mesmo tempo.

// Como o C# é uma linguagem fortemente tipada, esta possibilidade pode nos ajudar muito no dia-a-dia, evitando a criação de classes simples apenas para o transporte de dados. //


var tupla = new Tuple<String, int>("Minha idade", 32);
System.Console.WriteLine(tupla.Item1);
System.Console.WriteLine(tupla.Item2);


