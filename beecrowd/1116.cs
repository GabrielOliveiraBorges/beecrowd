int n;
int num1, num2;
double resultado;

Console.WriteLine("Digite um numero: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split();
    num1 = int.Parse(valores[0]);
    num2 = int.Parse(valores[1]);

    if (num2 == 0)
    {
        Console.WriteLine("divisão impossível");
    }
    else
    {
        resultado = (double)num1 / num2;
        Console.WriteLine($"{resultado:F1}");
    }
}
