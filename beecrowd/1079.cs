int numero;
double valor1, valor2, valor3, media;

Console.Write("Digite o número de casos de teste: ");
numero = int.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    Console.Write("Digite o primeiro valor: ");
    valor1 = double.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    valor2 = double.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro valor: ");
    valor3 = double.Parse(Console.ReadLine());

    media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
    Console.WriteLine($"A média desses numeros é: {media:F1}");
}
