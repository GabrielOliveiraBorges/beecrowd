Console.WriteLine("Digite um numero: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} {i * i} {i * i * i}");
}
