using System;

struct Professor
{
    public string Matricula;
    public string Nome;
    public Disciplina DadosDisciplina;
}

struct Disciplina
{
    public string NomeDisciplina;
    public int CargaHoraria;
}

class Program
{
    static void Main()
    {
        Professor[] xProf = new Professor[4];

        for (int i = 0; i < xProf.Length; i++)
        {
            Console.WriteLine("Matrícula:");
            xProf[i].Matricula = Console.ReadLine();

            Console.WriteLine("Nome:");
            xProf[i].Nome = Console.ReadLine();

            // Inicializa struct
            xProf[i].DadosDisciplina = new Disciplina();

            Console.WriteLine("Disciplina:");
            xProf[i].DadosDisciplina.NomeDisciplina = Console.ReadLine();

            Console.WriteLine("Carga Horária:");
            xProf[i].DadosDisciplina.CargaHoraria = int.Parse(Console.ReadLine());
        }

        ListarTudo(xProf);

        Console.WriteLine("Digite o nome para pesquisar:");
        string nomeBusca = Console.ReadLine();

        bool encontrou = Pesquisar(xProf, nomeBusca);

        if (encontrou)
            Console.WriteLine("Professor encontrado!");
        else
            Console.WriteLine("Professor não encontrado!");

        Console.ReadKey();
    }

    static void ListarTudo(Professor[] xProf)
    {
        Console.Clear();
        Console.WriteLine("Lista de Professores:");

        foreach (Professor prof in xProf)
        {
            Console.WriteLine($"Matrícula: {prof.Matricula}");
            Console.WriteLine($"Nome: {prof.Nome}");
            Console.WriteLine($"Disciplina: {prof.DadosDisciplina.NomeDisciplina}");
            Console.WriteLine($"Carga Horária: {prof.DadosDisciplina.CargaHoraria}");
            Console.WriteLine();
        }
    }

    static bool Pesquisar(Professor[] P, string Nome)
    {
        foreach (Professor prof in P)
        {
            if (prof.Nome == Nome)
            {
                Console.WriteLine($"Matrícula: {prof.Matricula}");
                Console.WriteLine($"Nome: {prof.Nome}");
                Console.WriteLine($"Disciplina: {prof.DadosDisciplina.NomeDisciplina}");
                Console.WriteLine($"Carga Horária: {prof.DadosDisciplina.CargaHoraria}");
                return true;
            }
        }
        return false;
    }
}