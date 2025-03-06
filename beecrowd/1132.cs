int soma = 0;

Console.WriteLine("Digite o primeiro numero");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo o numero");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

for (int i = num1; i <= num2; i++)
{
    if (i % 13 != 0)
    {
        soma += i;
    }
}

Console.WriteLine(soma);
