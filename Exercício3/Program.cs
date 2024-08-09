﻿// Exercício 3
// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite um número:");
    numeros[i] = int.Parse(Console.ReadLine());
}

int somaPares = 0;
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        somaPares += numeros[i];
    }
}

Console.WriteLine("A soma dos números pares é: " + somaPares);