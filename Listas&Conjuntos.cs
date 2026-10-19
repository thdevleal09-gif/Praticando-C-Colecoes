
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

HashSet<string> conjunto = new HashSet<string>
{
    "Thiago",
    "Lucas",
    "Estevao",
    "Endrick",
};







