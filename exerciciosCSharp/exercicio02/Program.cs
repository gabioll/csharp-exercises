using System; // permite usar Console e outras funções básicas
class Program
{
    static void Main(string[] args)
    {
        // cria uma matriz para guardar as notas
        // 5 linhas (alunos) e 3 colunas (provas)
        int[,] notas = new int[5, 3];

        // percorre cada aluno
        for (int aluno = 0; aluno < 5; aluno++)
        {
            // mostra qual aluno está digitando as notas
            Console.WriteLine($"Digite as notas do aluno {aluno + 1}:");

            // percorre cada prova do aluno
            for (int prova = 0; prova < 3; prova++)
            {
                // pede a nota da prova
                Console.Write($"Avaliação {prova + 1}: ");

                // lê o valor digitado e converte para inteiro
                int nota = int.Parse(Console.ReadLine());

                // guarda a nota na matriz
                // aluno = linha
                // prova = coluna
                notas[aluno, prova] = nota;
            }

            // pula uma linha para deixar o console mais organizado
            Console.WriteLine();
        }


        // imprime um título para a tabela de notas
        Console.WriteLine("Tabela de Notas");
        Console.WriteLine("Aluno | P1 | P2 | P3");
        Console.WriteLine("---------------------");

        // percorre novamente os alunos para mostrar as notas
        for (int aluno = 0; aluno < 5; aluno++)
        {
            // mostra o número do aluno
            Console.Write($"{aluno + 1}     | ");

            // percorre as provas do aluno
            for (int prova = 0; prova < 3; prova++)
            {
                // mostra a nota guardada na matriz
                Console.Write($"{notas[aluno, prova]}  | ");
            }

            // quebra linha depois de mostrar todas as provas
            Console.WriteLine();
        }


        // espaço para separar as tabelas
        Console.WriteLine();


        // imprime o título da segunda tabela
        Console.WriteLine("Aluno | Total | Média");
        Console.WriteLine("----------------------");

        // percorre novamente cada aluno
        for (int aluno = 0; aluno < 5; aluno++)
        {
            int soma = 0; // variável para somar as notas do aluno

            // percorre as provas do aluno para somar
            for (int prova = 0; prova < 3; prova++)
            {
                soma += notas[aluno, prova]; // soma cada nota
            }

            // calcula a média
            double media = soma / 3.0;

            // mostra o resultado do aluno
            Console.WriteLine($"{aluno + 1}   | {soma,5}   | {media,5:F1}");
        }
    }
}    