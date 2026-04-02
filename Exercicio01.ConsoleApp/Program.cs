Console.Write("Digite o comprimento da caixa retangular: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"o volume da caixa é: {volume:F2} cm³");

Console.ReadLine();