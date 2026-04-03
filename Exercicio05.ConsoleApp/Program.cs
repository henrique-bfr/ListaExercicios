// Ex 05 - Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.Write("Digite a nota da primeira prova: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da primeira prova: ");
double peso1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da segunda prova: ");
double peso2 = Convert.ToDouble(Console.ReadLine());

double media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

Console.WriteLine($"Sua média ponderada foi: {media:F2} pontos");
Console.ReadLine();