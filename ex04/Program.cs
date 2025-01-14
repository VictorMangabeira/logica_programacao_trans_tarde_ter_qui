// Escrever um programa que pergunte o nome do usuario e apresente nome + boas vindas

Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual é seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual é seu último sobrenome?");
string ultimosobrenome = Console.ReadLine();

Console.WriteLine($"Seja bem vindo(a) {nome} {sobrenome} {ultimosobrenome} ");

