// See https://aka.ms/new-console-template for more information
// console.log('Hello, World!')
Console.WriteLine("Hello, World!");
// "mundo dos tipos"
Console.WriteLine('I'); // caractere 'a'

// int -> integer -> 32bits (4 bytes) com sinal
//int idade = 18;

byte idade = 18; // 0-255

Console.WriteLine("Idade: " + idade);

Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);

// compile time, run time

// unsigned integer => inteiro sem sinal
uint likes = 123_233_323;

// tipo inferido (descobre o tipo a partir do valor)
var dislikes = 87; // é int
// dislikes = "87 dislikes"; // não pode atribuir string

// js => number
// double => números reais  32bits(4 bytes) , float 16bits(2 bytes)
double peso = 2.999;
peso = 2.5;
Console.WriteLine(peso);
// diferença de precisão
Console.WriteLine(0.1 + 0.1 + 0.1);

// monetário (dinheiro)
decimal preco = 0.10m; // monetary

if (preco > 10)
{
    Console.WriteLine("caro");
}
else
{
    Console.WriteLine("barato");
}

// for, foreach
for (var i = 0; i < 10; i++) Console.WriteLine("i: " + i);
// para cada (qualquer coleção de "coisas")

string info = "informática";
info = info.ToUpper(); // ToUpper é um Método (função) de String


foreach (char c in info) Console.WriteLine("c: " + c);

for (var i = 0; i < info.Length; i++)
{
    Console.WriteLine(info[i]);
}

// módulos:
// namespace, class, struct, record, enum






















