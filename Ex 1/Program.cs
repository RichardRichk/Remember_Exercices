Console.WriteLine("Salve, Digita um numero inteiro ai pra mim:");
int numberInt = int.Parse(Console.ReadLine());

if (numberInt% 2 == 0)
{
    Console.WriteLine(numberInt + " e par");
}
else
{
    Console.WriteLine(numberInt + " e impar");
}