/*
List<string> lista = new List<string>
{
    "Alice",
    "Bob",
    "Charlie",
    "Chloe",
    "Diana",
};
Console.WriteLine(lista[3]);
int indice = lista.IndexOf("Bob");
Console.WriteLine($"Índice de Bob: {indice}");

//lista.Sort();
lista.Reverse();
foreach (string funcionario in lista)
{
    Console.WriteLine(funcionario);
}
Console.WriteLine("------------------");

lista.Add("Eve");
lista.Remove("Charlie");

foreach (string funcionario in lista)
{
    Console.WriteLine(funcionario);
}
Console.WriteLine("--------------------");
HashSet<string> conjunto = new HashSet<string>();
conjunto.Add("Alice");
conjunto.Add("Bob");
conjunto.Add("Charlie");
conjunto.Add("Diana");
conjunto.Add("Alice"); // Não será adicionado novamente, pois já existe no conjunto
conjunto.Add("Gabriel");

conjunto.Add("bob"); // Diferente de "Bob", será adicionado ao conjunto
Console.WriteLine(conjunto.Count);
foreach (string funcionario in conjunto)
{
    Console.WriteLine(funcionario);
}

//Crie um programa que:

//Escolha a melhor estrutura para armazenar os scores.
//  Garanta que os dados estejam ordenados.
// Exiba os valores no console.

//List<int> scores = new List<int>();
//scores.Add(150);
//scores.Add(90);
//scores.Add(200);
//scores.Add(120);
//scores.Add(150);
//scores.Add(80);
// scores.Add(180);
//scores.Add(200);

//List<int> orderedScores = new List<int>(scores);
//orderedScores.Sort(); // Ordena os scores em ordem crescente

//Console.WriteLine("Scores ordenados:");
//foreach (int score in orderedScores)
//{
//Console.WriteLine(score);
//}
//var orderedScores = scores.OrderBy(s => s).ToList();
//foreach (int score in orderedScores)
//{
//    Console.WriteLine(score);
//}

//Crie um programa que:

//  Inicialize uma lista com os caracteres descritos acima
// Decifre a mensagem dada pelos caracteres descritos
// Exiba o resultado

char[] caracteres = new char[] { 'o', 'd', 'n', 'u', 'm', ' ', 'a', 'l', 'o', };

Array.Reverse(caracteres); // Inverte a ordem dos elementos do array para decifrar a mensagem
Console.WriteLine(new string(caracteres));

//Crie um programa que:

//    Declare uma lista de nomes.
//    Organize a lista em ordem alfabética.
//    Inverta a ordem da lista.
//    Remova o primeiro elemento e o adicione novamente na lista.
 //   Agora verifique quem está no índice 3 da lista e exiba o nome no console

List<string> nomes = new List<string> {"Thiago", "Chloe", "Arthur", "Emanuele", "Ruan" };
Console.WriteLine("Lista Original:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

List<string> nomesOrdenados = new List<string>(nomes);
nomesOrdenados.Sort(); // Ordena os nomes em ordem alfabética

Console.WriteLine("Apos Sort(ordem alfabetica):");
foreach (string nome in nomesOrdenados)
{
    Console.WriteLine(nome);
}

List<string> nomesInvertidos = new List<string>(nomesOrdenados);
nomesInvertidos.Reverse(); // Inverte a ordem da lista

Console.WriteLine("Apos Reverse():");
foreach (string nome in nomesInvertidos)
{
    Console.WriteLine(nome);
}

nomes.RemoveAt(0); // Remove o primeiro elemento da lista
nomes.Add("Thiago"); // Adiciona novamente o primeiro elemento na lista

Console.WriteLine("Apos remover e adicionar o primeiro elemento:");
Console.WriteLine(string.Join(", ", nomes));


Console.WriteLine("A pessoa sorteada foi: " + nomes[3]);

//Crie um programa que:

//Declare duas listas distintas de produtos.
 //  Adicione todos os elementos da lista secundária na lista principal.
  //Exiba a lista principal com todos os produtos.

List<string> produtosPrincipais = new List<string> { "Mouse", "Teclado", "Monitor" };
List<string> produtosSecundarios = new List<string> { "Cabo USB", "Fone de Ouvido", "Webcam", "HeadSet" };

produtosPrincipais.AddRange(produtosSecundarios); // Adiciona todos os elementos da lista secundária na lista principal
Console.WriteLine("Lista Principal com todos os produtos:");
//Console.WriteLine(string.Join(", ", produtosPrincipais));

foreach (string produto in produtosPrincipais)
{
    Console.WriteLine(produto);
}
*/

