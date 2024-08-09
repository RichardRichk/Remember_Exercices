//Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
//Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
//os números pares.

int[] number = new int[10];
int result = 0;

Console.WriteLine("Salve, Vamos somar todos os elementos de um vetor, primeiro digite os numeros:");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o numero" + (i+1));
    number[i] = int.Parse(Console.ReadLine());
}

foreach (int i in number)
{
    if (i%2 == 0)
    {
        result += i;
    }
}

Console.WriteLine("Resultado:" + result);
