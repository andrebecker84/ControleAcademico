namespace ControleAcademico
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criando disciplina e professor
            Disciplina disciplina = new Disciplina(1, "Rock");
            Professor professor = new Professor(101, "Axl Rose");

            // Criando turma
            Turma turma = new Turma(1, disciplina, professor);

            // Criando lista de alunos
            List<Aluno> alunos = new List<Aluno>
            {
                Aluno.AddAluno(10101, "André"),
                Aluno.AddAluno(10102, "Lucas"),
                Aluno.AddAluno(10103, "Pedro"),
                Aluno.AddAluno(10104, "João"),
                Aluno.AddAluno(10105, "Maria"),
                Aluno.AddAluno(10106, "José"),
                Aluno.AddAluno(10107, "Carlos"),
                Aluno.AddAluno(10108, "Ana"),
                Aluno.AddAluno(10109, "Paula"),
                Aluno.AddAluno(10110, "Mariana"),
                Aluno.AddAluno(10111, "Carla"),
                Aluno.AddAluno(10112, "Fernanda")
            };

            // Adicionando alunos à turma e exibindo resultado
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(turma.AddAluno(aluno));
            }

            // Gerando pauta da turma
            Console.WriteLine(turma.GerarPauta());

            // Exibindo lista de alunos matriculados
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" Alunos matriculados [Escola]");
            Console.WriteLine("------------------------------------------------");
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($" - [ {aluno.Matricula} ] {aluno.Nome}");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
            
            // Testando os métodos ToString() das classes
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(" Testes de Métodos ToString() das Classes");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine(alunos[0]);
            Console.WriteLine(professor);
            Console.WriteLine(disciplina);
            Console.WriteLine(turma);
            Console.WriteLine("------------------------------------------------");
        }
    }
}