// Exercício 5
// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto. 

Console.WriteLine("Digite um texto:");
string text = Console.ReadLine().ToLower();

int total = 0;

foreach (char c in text)
{
if (c >= 'a' && c <= 'z')
{
total++;
}
}

Console.WriteLine($"O Texto tem um total de: {total} letra(s)");