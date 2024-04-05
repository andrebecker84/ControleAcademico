namespace ControleAcademico
{
    public class Turma
    {
        // PROPRIEDADES:
        public int Codigo { get; set; }            // Código da turma
        public Disciplina Disciplina { get; set; } // Relacionamento da classe Turma X Disciplina 1:1
        public Professor Professor { get; set; }   // Relacionamento da classe Turma X Professor 1:1
        public List<Aluno> Alunos { get; set; }    // Relacionamento da classe Turma X Aluno 1:N (2..10 alunos no caso de uma turma)
        public const int LimiteAlunos = 10;        // Limite máximo de alunos na turma

        // CONSTRUTORES:
        // Construtor sem parâmetros
        public Turma()
        {
            Codigo = 0;                     // Inicializa o código com 0
            Disciplina = new Disciplina();  // Inicializa a disciplina com um objeto vazio
            Professor = new Professor();    // Inicializa o professor com um objeto vazio
            Alunos = new List<Aluno>();     // Inicializa a lista de alunos
        }

        // Construtor com parâmetros
        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            Codigo = codigo;             // Inicializa o código
            Disciplina = disciplina;     // Inicializa a disciplina
            Professor = professor;       // Inicializa o professor
            Alunos = new List<Aluno>();  // Inicializa a lista de alunos
        }

        // MÉTODOS:
        // Método para adicionar um aluno à turma
        public string AddAluno(Aluno aluno) // Recebe um objeto do tipo Aluno como parâmetro
        {
            if (Alunos.Count < LimiteAlunos) // Verifica se a turma não está cheia
            {
                Alunos.Add(aluno); // Adiciona o aluno à lista
                return $"+ [ {aluno.Matricula} - {aluno.Nome} ] - Aluno adicionado à turma {Codigo} com sucesso!"; // Retorna a mensagem de sucesso
            }
            else                   // Se a turma estiver cheia
            {
                return $"\n## ATENÇÃO! ##\n Limite de {LimiteAlunos} alunos excedido!! [ TURMA {Codigo} ]\n [ {aluno.Matricula} - {aluno.Nome} ] - Aluno não incluído! ";
            }
        }

        // Método para abrir a turma
        public bool AbrirTurma()
        {
            return true; // Lógica para abrir a turma
        }

        // Método para gerar a pauta da turma
        public string GerarPauta()
        {
            string pauta = $"\n";                                             // Inicializa com uma quebra de linha
            pauta += $"**[ PAUTA DA TURMA {Codigo} ]**\n";                    // Título com a identificação da turma
            pauta += $" Disciplina {Disciplina.Codigo}: {Disciplina.Nome}\n"; // Informações da disciplina
            pauta += $" Professor: {Professor.Nome}\n";                       // Nome do professor
            pauta += $"\n";                                                   // Quebra de linha
            pauta += $" Alunos matriculados:\n";                              // Título "Alunos matriculados"
            foreach (Aluno aluno in Alunos)     // Para cada aluno na lista de alunos
            {
                pauta += $"  - [ {aluno.Matricula} ] {aluno.Nome}\n"; // Adicionar o nome do aluno
            }
            return pauta;                       // Retorna a pauta
        }

        // ToString() - Método para retornar uma string com informações da turma
        public override string ToString()
        {
            return $"[ Cód. {Codigo} ], Disciplina: {Disciplina.Nome}, Professor: {Professor.Nome}, Limite de Alunos: {Alunos.Count}";
        }

        // Método para obter a lista de alunos que não foram adicionados devido ao limite excedido
        public List<Aluno> ObterAlunosNaoAdicionados(List<Aluno> alunosTentados)
        {
            List<Aluno> alunosNaoAdicionados = new List<Aluno>();

            foreach (Aluno aluno in alunosTentados)
            {
                if (AddAluno(aluno) == null)
                {
                    alunosNaoAdicionados.Add(aluno);
                }
            }

            return alunosNaoAdicionados;
        }
    }
}