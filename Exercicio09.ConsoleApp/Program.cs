Console.Write("Digite um valor para calcular o fatorial: ");
int numero = Convert.ToInt32(Console.ReadLine());

long resultado = 1;
Console.Write($"{numero}! = ");

for (int i = numero; i >= 1; i--)
{
    resultado *= i;
    if (i > 1)
    {
        Console.Write(i + " X ");
    }
    else
    {
        Console.Write(i + " = ");
    }
}

Console.WriteLine(resultado);
Console.ReadLine();