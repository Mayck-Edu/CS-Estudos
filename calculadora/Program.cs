using System;
int num1;
int num2;


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
            return num1 / num2;
        default:
            throw new InvalidOperationException("Ops!!");
    }
}

try
{
    Console.WriteLine("O resultado da operação é: " + operacao());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Não é possível dividir por zero. " + ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Essa operação não é válida: " + ex.Message);
}
catch (FormatException)
{
    Console.WriteLine("Entrada inválida. Por favor, insira números inteiros.");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
}
finally
{
    operacao();
}