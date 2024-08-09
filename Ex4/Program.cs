//Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
//número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.WriteLine("Salve, digite um numero e eu retorno a tabuada");

int number = int.Parse(Console.ReadLine());

ExibirTabuada(number);

static void ExibirTabuada(int number)
{
    Console.WriteLine($"Tabuada do {number}:");

    for (int i = 1; i <= 10; i++)
    {
        int resultado = number * i;
        Console.WriteLine($"{number} x {i} = {resultado}");
    }
}