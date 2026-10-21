//Chave => ID
//Valor => Nome

/*
Dictionary<int, string> myDictionary = new Dictionary<int, string>()
{
  { 4587963, "Teclado" },
 { 3374561, "Cadeira Gamer" },
 { 2456987, "Notebook" },
 { 6356984, "Teclado" },
 { 8654987, "Mouse"  },
};

Console.WriteLine(myDictionary[4587963]);
Console.WriteLine(myDictionary[3374561]);
Console.WriteLine(myDictionary[2456987]);
Console.WriteLine(myDictionary[6356984]);
Console.WriteLine(myDictionary[8654987]);

//Crie um programa que:

//    Declare um dicionário com as informações de nome e nota de cada aluno
//    Use um loop para iterar sobre essas notas
//    Exiba as notas na tela

Dictionary<string, double> notasAlunos = new Dictionary<string, double>();
notasAlunos.Add("João", 8.5);
notasAlunos.Add("Maria", 9.0);
notasAlunos.Add("Chloe", 10.0);
notasAlunos.Add("Lucas", 7.5);
notasAlunos.Add("Ana", 6.0);


//foreach (var aluno in notasAlunos)
//{

//  Console.WriteLine($"Notas dos aluno: {aluno.Key} -> {aluno.Value} ");

//}

//Crie um programa que:

//  Inicialize um dicionário com itens.
// Remova um item específico do inventário.
//Adicione um novo item ao inventário.
// Exiba a lista atualizada de itens.

Dictionary<int, string> inventarioRPG = new Dictionary<int, string>()
{
    {1, "Espada Longa"},
    {2, "Arco Curto" },
    {3, "Escudo de ferro" },
    {4, "Pocoes e Consumiveis" }

};

Console.WriteLine("Itens no iventario inicial: ");
foreach (var item in inventarioRPG)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}
Console.WriteLine("=====================================");

inventarioRPG.Remove(4);

inventarioRPG.Add(4, "Tesouros e Moedas");

Console.WriteLine("Itens no inventario atualizado:");
foreach(var item in inventarioRPG)
{

    Console.WriteLine($"ID: {item.Key} - {item.Value}");

}
*/

//Crie um programa que:

//   Inicialize um dicionário com algumas tarefas
// Remova todas as tarefas do dicionário
//Adicione novas tarefas
// Liste as novas tarefas

//Dica: O método Clear() esvazia completamente o dicionário, removendo todos os itens de uma só vez.
//Isso é útil quando precisamos reiniciar uma coleção sem criar uma nova instância.

Dictionary<string, string> tarefas = new Dictionary<string, string>
{
    { "Refatorar módulo de login", "Ana" },
    { "Testar API de pagamentos", "Pedro" }

};

Console.WriteLine("Tarefas Iniciais: ");

foreach(var tarefa in tarefas) { Console.WriteLine($"Tarefa: {tarefa.Key} -> Responsavel: {tarefa.Value}"); }

Console.WriteLine("=======================");

tarefas.Clear();

tarefas.Add("Implementar autenticação OAuth", "João");
tarefas.Add("Otimizar consultas SQL", "Maria");
tarefas.Add("Atualizar documentação", "Carlos");




Console.WriteLine("Tarefas do proximo sprint: ");
   
foreach (var tarefa in tarefas)
{ 
    Console.WriteLine($"Tarefa: {tarefa.Key} -> Responsavel: {tarefa.Value}"); 
}