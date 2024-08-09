// Exercício 4
// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.WriteLine("Digite um número para ver a tabuada:");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine($"Tabuada do número {numero}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}