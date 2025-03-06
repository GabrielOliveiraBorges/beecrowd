int numero, x, dentro = 0, fora = 0;

Console.Write("Digite a quantidade de números: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    x = int.Parse(Console.ReadLine());

    if (x >= 10 && x <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine($"{dentro} dentro do intervalo [10,20]");
Console.WriteLine($"{fora} fora do intervalo");
