using System;
int num1;
int num2;

// operacao();
Console.WriteLine("Resultado: " + operacao());
int operacao()
{
    Console.WriteLine("Digite o primeiro número:");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número:");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escolha a operação: 1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão");
    int operacao = Convert.ToInt32(Console.ReadLine());

    switch (operacao)
    {
        case 1:
            return num1 + num2;
        case 2:
            return num1 - num2;
        case 3:
            return num1 * num2;
        case 4:
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("Divisão por zero não é permitida.");
        default:
            throw new InvalidOperationException("Operação inválida.");
    }
}