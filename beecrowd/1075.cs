int numero;

Console.Write("Digite um numero: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10000; i++)
{
    if (i % numero == 2)
    {
        Console.WriteLine(i);
    }
}