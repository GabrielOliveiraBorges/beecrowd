int numero, valor;

Console.Write("Digite o valor de N: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    Console.Write($"Digite o {i + 1}º valor: ");
    valor = int.Parse(Console.ReadLine());

    if (valor == 0)
    {
        Console.WriteLine("NULO");
    }
    else
    {
        if (valor % 2 == 0)
        {
            Console.Write("PAR ");
        }
        else
        {
            Console.Write("ÍMPAR ");
        }

        if (valor > 0)
        {
            Console.WriteLine("POSITIVO");
        }
        else
        {
            Console.WriteLine("NEGATIVO");
        }
    }
}
