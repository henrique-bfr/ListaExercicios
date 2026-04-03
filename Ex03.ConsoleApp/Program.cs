// Ex03 - Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

Console.Write("Digite sua temperatura em Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double fahrenheit = (celsius * 1.8) + 32;

Console.WriteLine($"Sua temperatura em Fahrenheit é: {fahrenheit}°F");