string[] nomes = new string[5];

Console.WriteLine("Salve cumpadi, digita 5 nomes ai pra mim, retornarei eles em ordem alfabetica.");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome:" + (i+1));
    nomes[i] = Console.ReadLine();
}

Array.Sort(nomes);

Console.WriteLine("Nomes em ordem alfabetica:");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

