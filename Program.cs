
//  Array of strings representing employees
/*
string[] funcionarios = { "Alice", "Bob", "Charlie", "Diana" };

Console.WriteLine(funcionarios[3]);
int indice = Array.IndexOf(funcionarios, "Bob");
Console.WriteLine($"Índice de Bob: {indice}");

Array.Sort(funcionarios);
foreach (string funcionario in funcionarios)
{
    Console.WriteLine(funcionario);
}
Console.WriteLine("---------------");
string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Length);
foreach (string funcionario in novoArray)
{
    Console.WriteLine(funcionario);
}
*/

//Crie um programa que:

//  Declare um array de números representando doações.
//   Utilize um loop para somar todos os valores contidos no array.
//   Exiba o total calculado na tela.

//double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
//double total = 0;

//foreach(double valor in doacoes)
//{
//    total += valor;
//}
//Console.WriteLine($"Total de doações: {total}");

//Crie um programa que:

//    Declare um array com nomes de participantes.
//    Ordene esse array alfabeticamente.
//    Identifique e exiba o terceiro nome da lista após a ordenação.

//string[] participantes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };
//Array.Sort(participantes);
//Console.WriteLine($"O terceiro nome da lista e: {participantes.ElementAt(2)}" );

//Crie um programa que:

//    Declare um array de números inteiros.
//    Localize no array o índice de cada um dos números da combinação.
//    Exiba a combinação no console.

//O sistema gera uma combinação única a cada acesso, onde:

   // O primeiro dígito é a posição onde o número 19 está localizado.
   //O segundo dígito é a posição onde o número 42 está localizado.
   //O terceiro dígito é a posição onde o número 7 está localizado.

//int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
//int indice19 = Array.IndexOf(numeros, 19);
//int indice42 = Array.IndexOf(numeros, 42);
//int indice7 = Array.IndexOf(numeros, 7);

//Console.WriteLine($"Combinação de cada cadeado: {indice19}-{indice42}-{indice7}");