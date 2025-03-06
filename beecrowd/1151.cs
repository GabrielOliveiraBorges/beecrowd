Console.WriteLine("Digite um numero: ");
int num = int.Parse(Console.ReadLine());
int primeiro = 0, segundo = 1, proximo;

for (int i = 0; i < num; i++)
{
    if (i == 0)
    {
        Console.Write(primeiro);
    }
    else if (i == 1)
    {
        Console.Write(" " + segundo);
    }
    else
    {
        proximo = primeiro + segundo;
        Console.Write(" " + proximo);
        primeiro = segundo;
        segundo = proximo;
    }
}
Console.WriteLine();
