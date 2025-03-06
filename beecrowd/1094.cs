int total_animal = 0, sapos = 0, rato = 0, coelho = 0;
int experimentos = int.Parse(Console.ReadLine());

for (int i = 0; i < experimentos; i++)
{
    string[] dados = Console.ReadLine().Split();
    int quantidade = int.Parse(dados[0]);
    string tipo = dados[1];

    total_animal += quantidade;

    if (tipo == "Sapo")
        sapos += quantidade;
    else if (tipo == "Rato")
        rato += quantidade;
    else if (tipo == "Coelho")
        coelho += quantidade;
}

Console.WriteLine($"Total de animais: {total_animal}");
Console.WriteLine($"Total de sapos: {sapos}");
Console.WriteLine($"Total de ratos: {rato}");
Console.WriteLine($"Total de coelhos: {coelho}");

Console.WriteLine($"Porcentagem de sapos: {(double)sapos / total_animal * 100}%");
Console.WriteLine($"Porcentagem de ratos: {(double)rato / total_animal * 100}%");
Console.WriteLine($"Porcentagem de coelhos: {(double)coelho / total_animal * 100}%");