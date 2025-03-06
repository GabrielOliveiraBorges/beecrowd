Console.WriteLine("Digite um numero: ");
int num = int.Parse(Console.ReadLine());
int cont = 1;

for (int i = 0; i < num; i++)
{
    Console.WriteLine($"{cont} {cont + 1} {cont + 2} PUM");
    cont += 4;
}
