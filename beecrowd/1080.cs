int maior_valor, posicao, numero;

maior_valor = int.MinValue;
posicao = -1;

for (int i = 1; i <= 100; i++)
{
    numero = int.Parse(Console.ReadLine());

    if (numero > maior_valor)
    {
        maior_valor = numero;
        posicao = i;
    }
}

Console.WriteLine($"O maior valor é {maior_valor} e ele foi o {posicao}º número digitado.");