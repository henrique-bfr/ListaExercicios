/* Ex04 - 
    Crie um programa para calcular o salário total de um vendedor. 
        Deverá ser informado o salário base e o total de vendas. 
        A comissão é calculada com um percentual (informado pelousuário) sobre o total de vendas.
*/
Console.Write("Digite o seu salário base: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o total de vendas: ");
double vendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o percentual de comissão das suas vendas: ");
double percentual = Convert.ToDouble(Console.ReadLine());

double salarioFinal = salarioBase + ((vendas * percentual) / 100);

Console.WriteLine($"Seu salário total é: {salarioFinal:F2}");
Console.ReadLine();