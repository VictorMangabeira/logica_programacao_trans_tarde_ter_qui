

Console.WriteLine("Insira um número interiro positivo");
int contador = 1;
int numero = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine(contador);
    contador++;
}
while (contador <= numero);