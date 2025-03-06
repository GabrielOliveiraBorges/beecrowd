int n1, n2, soma = 0, temp;

Console.Write("Digite o primeiro numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    temp = n1;
    n1 = n2;
    n2 = temp;
}

for (int i = n1 + 1; i < n2; i++)
{
    if (i % 2 != 0)
    {
        soma += i;
    }
}

Console.WriteLine($"A soma dos valores ímpares entre {n1} e {n2} é: {soma}");