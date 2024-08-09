// Exercício 2
// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

List<string> nomes = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um nome:");
    nomes.Add(Console.ReadLine());
}

nomes.Sort();

Console.WriteLine("");
Console.WriteLine("Nomes em ordem alfabética:");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}