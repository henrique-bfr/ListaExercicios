/*
    2.Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
    viagem.
        O programa deve solicitar ao usuário:
            a.A quilometragem inicial do veículo no início da viagem.
            b. A quilometragem final ao término da viagem.
            c. A quantidade de combustível consumida durante a viagem (em litros).
*/

bool kmOk = true;

while (kmOk)
{
    Console.Write("Digite a quilometragem inicial: ");
    double kmInicial = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite a quilometragem final: ");
    double kmFinal = Convert.ToDouble(Console.ReadLine());

    if (kmFinal < kmInicial)
    {
        Console.WriteLine("Opção inválida, o Km final não pode ser menor que o inicial!");
        Console.WriteLine("Pressione ENTER para tentar novamente...");
        Console.ReadLine();
        continue;
    }

    Console.Write("Digite a quantidade de litros consumidos: ");
    double litros = Convert.ToDouble(Console.ReadLine());

    if (litros <= 0)
    {
        Console.WriteLine("A quantidade de litros deve ser maior que zero!");
        Console.WriteLine("Pressione ENTER para tentar novamente...");
        Console.ReadLine();
        continue; 
    }

    double media = (kmFinal - kmInicial) / litros;

    Console.WriteLine($"A sua média é: {media:F2} km/l");
    
    kmOk = false;
}

Console.WriteLine("Aperte ENTER para sair.");
Console.ReadLine();