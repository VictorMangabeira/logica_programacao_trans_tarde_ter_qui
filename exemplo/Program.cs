Console.WriteLine("Nome completo do aluno: ");
string n = Console.ReadLine();
Console.WriteLine("Nota 1: ");
double nota1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nota 2: ");
double nota2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Nota 3: ");
double nota3 = Double.Parse(Console.ReadLine());
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"O aluno {n} foi aprovado, a media é: {media} ");
}
else if (media >= 4)
{
    Console.WriteLine($"O aluno {n} esta em recuperação,  a media é: {media} ");
}
else
{
    Console.WriteLine($"O aluno {n} foi reprovado,  a media é: {media}");
}
