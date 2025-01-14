// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (num1 + num2));
Console.WriteLine("- : " + (num1 - num2));
Console.WriteLine("* : " + (num1 / num2));


if(num2 != 0)
{
    Console.WriteLine("/ : " + (num1 / num2));
}
else
{ 
    Console.WriteLine("/ : divisão por zero não e permitido");
}

Console.WriteLine("====================");
Console.WriteLine("Os númros são iguais? " + (num1 == num2));
Console.WriteLine("Número 1 é maior Número 2? " + (num1 > num2));
Console.WriteLine("Número 1 é menor Número 2? " + (num1 < num2));
Console.WriteLine("Número 1 é maior igual Número 2? " + (num1 >= num2));
Console.WriteLine("Número 1 é menor igual Número 2? " + (num1 <= num2));

