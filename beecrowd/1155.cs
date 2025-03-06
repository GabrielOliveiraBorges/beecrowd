double s = 0.0;
int numerador = 1;
int denominador = 1;

for (int i = 0; i < 20; i++)
{
    s += (double)numerador / denominador;
    numerador += 2;
    denominador *= 2;
}

Console.WriteLine($"{s:F2}");
