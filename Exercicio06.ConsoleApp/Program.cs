// Ex 06 - Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

using System.Threading.Tasks.Dataflow;

Console.Write("Digite o valor de A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de C: ");
int c = Convert.ToInt32(Console.ReadLine());

if((a + b) < c)
{
    Console.WriteLine("A soma de A + B é MENOR que C");
}
else
{
    Console.WriteLine("Fim do programa, digite ENTER para sair");
    Console.ReadLine();
}