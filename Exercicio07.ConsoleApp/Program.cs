/*
Ex07 - 
    O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde
    para dar uma indicação sobre a condição de peso de uma pessoa adulta. 
        A fórmula é IMC = peso / (altura) 
        2. Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
            a. IMC em adultos Condição
                b. Abaixo de 18,5 = Abaixo do peso
                c. Entre 18,5 e 25 = Peso normal
                d. Entre 25 e 30 = Acima do peso
                e. Acima de 30 = obeso
*/

Console.Write("Digite sua altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite seu peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura) ;

if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é: {imc:F2}, você está abaixo do peso normal.");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine($"Seu IMC é: {imc:F2}, você está no peso normal.");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine($"Seu IMC é: {imc:F2}, você está acima do peso normal.");
}
else
{
    Console.WriteLine($"Seu IMC é: {imc:F2}, você está obeso.");
}

