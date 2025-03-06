int numero ,i;

Console.WriteLine("Digite um numero inteiro: ");
numero = int.Parse(Console.ReadLine());

for (i = 0; i < numero; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }

}
