﻿int n;

Console.Write("Digite o valor de N: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}^2 = {i * i}");
    }
}

