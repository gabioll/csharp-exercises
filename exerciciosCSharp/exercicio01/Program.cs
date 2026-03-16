using System;
namespace LogicaDeProgramacao.Exercicios.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10]; //declaração do vetor

            //entrada de Elementos do vetor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número inteiro:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maior = numeros[0]; //inicializa o maior com o primeiro elemento do vetor
            int menor = numeros[0]; //inicializa o menor com o primeiro elemento do vetor
            for (int i = 1; i < 10; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i]; //atualiza o maior
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i]; //atualiza o menor
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");

            int pares = 0; //contador de números pares
            int impares = 0; //contador de números ímpares
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares++; //incrementa o contador de pares
                }
                else
                {
                    impares++; //incrementa o contador de ímpares
                }
            }
            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");

            double media = 0; //variável para armazenar a média
            for (int i = 0; i < 10; i++)
            {
                media += numeros[i]; //soma os elementos do vetor
            }
            media /= 10; //calcula a média
            Console.WriteLine($"A média dos números é: {media}");

            
        }
        
    }
}