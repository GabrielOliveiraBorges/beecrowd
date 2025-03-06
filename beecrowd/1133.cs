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

for (int i = num1 + 1; i < num2; i++)
{
    if (i % 5 == 2 && i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}