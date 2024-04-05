namespace ControleAcademico
{
    public class Aluno
    {
        // PROPRIEDADES:
        public int Matricula { get; set; } // Matrícula do aluno
        public string Nome { get; set; }   // Nome do aluno


        // CONSTRUTORES:
        // Construtor sem parâmetros
        public Aluno()
        {
            Matricula = 0;       // Inicializa a matrícula com 0
            Nome = string.Empty; // Inicializa o nome com uma string vazia
        }

        // Construtor com parâmetros
        public Aluno(int matricula, string nome) // Construtor com parâmetros
        {
            Matricula = matricula; // Inicializa a matrícula
            Nome = nome;           // Inicializa o nome
        }

        // Método estático para adicionar um aluno
        public static Aluno AddAluno(int matricula, string nome)
        {
            return new Aluno(matricula, nome);
        }

        public void InserirNotas()
        {
            Console.WriteLine("Notas inseridas para o aluno: " + Nome);
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}, Nome: {Nome}";
        }
    }
}