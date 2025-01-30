/* 
 Desafio: Criar um programa que receba 6 nome utilizando arrays. 
Ao final o programa  deve exibir todos os nomes digitados
 */




string[] nomes = new string[6];

for (int i = 0; i < nomes.Length; i++)
{

    Console.Write($"Digite o {i + 1}ª nome:  ");
    nomes [i] = Console.ReadLine();
}

Console.WriteLine("\nVocê digitou os seguintes nomes");

foreach (string nome in nomes)
{
   
    Console.WriteLine(nome);
    
}




