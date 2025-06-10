using System;

Console.WriteLine("Bem-vindo ao Project Euler!");
Console.WriteLine("Visite: https://projecteuler.net/");
Console.WriteLine("Escolha um exercício:");


int opcao = 0;
opcao = Convert.ToInt32(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("o resultado é: " + exercise01());
        break;
    default:
        break;
}



int exercise01()
{

    /* Se listarmos todos os números naturais abaixo que 10 e são múltiplos de 3 ou 5, obtemos 3, 5, 6 e 9. A soma desses múltiplos é
    23
    .

    Encontre a soma de todos os múltiplos de 3
    ou 5 abaixo de 1000.*/
    int sum = 0;
    for (int i = 0; i < 1000; i++)
    {
        if (i % 3 == 0 || i % 5 == 0)
        {
            sum += i;
        }
    }
return sum;
}