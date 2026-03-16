using System;

class Program
{
    static void Main()
    {
        // vetores para armazenar nomes e telefones
        string[] nomes = new string[30];
        string[] telefones = new string[30];

        // controla quantos funcionários foram cadastrados
        int quantidade = 0;

        // variável da opção do menu
        int opcao = 0;

        // enquanto o usuário não escolher sair
        while (opcao != 4)
        {
            Console.Clear(); // limpa a tela

            // MENU
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== SISTEMA DE FUNCIONÁRIOS ===");
            Console.ResetColor();
            Console.WriteLine("1 - Cadastrar funcionário");
            Console.WriteLine("2 - Pesquisar funcionário");
            Console.WriteLine("3 - Listar funcionários");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            // ===== OPÇÃO 1 - CADASTRAR =====
            if (opcao == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                MostrarTitulo("Cadastro de Funcionário");
                Console.ResetColor();

                char continuar = 's';

                while (continuar == 's' && quantidade < 30)
                {
                    Console.Write("Digite o nome: ");
                    nomes[quantidade] = Console.ReadLine();

                    Console.Write("Digite o telefone: ");
                    telefones[quantidade] = Console.ReadLine();

                    quantidade++;

                    Console.WriteLine();
                    Console.Write("Deseja cadastrar outro funcionário? (s/n): ");
                    continuar = char.Parse(Console.ReadLine().ToLower());
                    Console.WriteLine();
                }

                if (quantidade == 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Limite máximo de funcionários atingido.");
                    Console.ResetColor();
                }

                Pausar();
            }

            // ===== OPÇÃO 2 - PESQUISAR =====
            else if (opcao == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                MostrarTitulo("Pesquisa de Funcionário");
                Console.ResetColor();

                Console.Write("Digite o nome para pesquisar: ");
                string nomeProcurado = Console.ReadLine();

                bool encontrado = false;

                // percorre apenas os funcionários cadastrados
                for (int i = 0; i < quantidade; i++)
                {
                    if (string.Equals(nomes[i], nomeProcurado, StringComparison.OrdinalIgnoreCase))
                    {
                        // se for o primeiro encontrado, mostra cabeçalho
                        if (!encontrado)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nome        Telefone");
                            Console.WriteLine("--------------------");
                        }

                        Console.WriteLine($"{nomes[i],-10} {telefones[i]}");

                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine();
                    Console.WriteLine("Funcionário não encontrado.");
                }

                Pausar();
            }

            // ===== OPÇÃO 3 - LISTAR =====
            else if (opcao == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                MostrarTitulo("Lista de Funcionários");
                Console.ResetColor();

                if (quantidade == 0)
                {
                    Console.WriteLine("Nenhum funcionário cadastrado.");
                }
                else
                {
                    Console.WriteLine("Nome        Telefone");
                    Console.WriteLine("--------------------");

                    for (int i = 0; i < quantidade; i++)
                    {
                        Console.WriteLine($"{nomes[i],-10} {telefones[i]}");
                    }
                }

                Pausar();
            }

            // ===== OPÇÃO 4 - SAIR =====
            else if (opcao == 4)
            {
                Console.Clear();
                Console.WriteLine("Encerrando o sistema...");
            }

            // ===== OPÇÃO INVÁLIDA =====
            else
            {
                Console.WriteLine("Opção inválida.");
                Pausar();
            }
        }
    }


    // FUNÇÃO PARA MOSTRAR TÍTULOS
    static void MostrarTitulo(string titulo)
    {
        Console.WriteLine(titulo);
        Console.WriteLine(new string('=', titulo.Length));
        Console.WriteLine();
    }


    // FUNÇÃO PARA PAUSAR A TELA
    static void Pausar()
    {
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}