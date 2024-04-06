using System.Text;

namespace ControleAcademico
{
    public class Turma
    {
        // PROPRIEDADES:
        public int Codigo { get; set; }            // Código da turma
        public Disciplina Disciplina { get; set; } // Relacionamento da classe Turma X Disciplina 1:1
        public Professor Professor { get; set; }   // Relacionamento da classe Turma X Professor 1:1
        public List<Aluno> Alunos { get; set; }    // Relacionamento da classe Turma X Aluno 1:N (2..10 alunos no caso de uma turma)
        public const int LimiteMaximoAlunos = 10;  // Limite máximo de alunos na turma
        public const int LimiteMinimoAlunos = 2;   // Limite mínimo de alunos na turma

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
        bool tituloMostrado = false;        // Variável para controlar se o título já foi mostrado
        public string AddAluno(Aluno aluno) // Recebe um objeto do tipo Aluno como parâmetro
        {
            string mensagem = ""; // Inicializa a mensagem como vazia

            if (Alunos.Count < LimiteMaximoAlunos) // Verifica se a turma não está cheia
            {
                int numeroAlunosAdicionados = Alunos.Count + 1; // Número incremental de alunos adicionados
                Alunos.Add(aluno); // Adiciona o aluno à lista

                // Verifica se o título ainda não foi mostrado
                if (!tituloMostrado)
                {
                    // Imprime o título
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($" Adicionando alunos à [Turma {Codigo}]... ");
                    Console.WriteLine("------------------------------------------------");
                    tituloMostrado = true; // Atualiza a flag para indicar que o título foi mostrado
                }

                // Adiciona a mensagem de sucesso
                mensagem += $" + {numeroAlunosAdicionados} [ Matrícula: {aluno.Matricula} ] {aluno.Nome}";

                // Verifica se o número de alunos atingiu o limite mínimo
                if (Alunos.Count == LimiteMinimoAlunos)
                {
                    // Adiciona a mensagem informando que a turma foi aberta
                    mensagem += $" -> OK! :) - Turma {Codigo} confirmada! Ainda faltam {LimiteMaximoAlunos - LimiteMinimoAlunos} alunos para fechar.";
                }
                else if (Alunos.Count < LimiteMinimoAlunos)
                {
                    // Adiciona a mensagem de atenção
                    mensagem += $" -> ALERTA - Turma ainda não atingiu mín. de {LimiteMinimoAlunos} alunos para abertura!\n";
                }
            }
            else // Se a turma estiver cheia
            {
                // Adiciona a mensagem de limite excedido
                mensagem += $"\n ** ATENÇÃO ** [ {aluno.Matricula} - {aluno.Nome} ] - Aluno não incluído. Limite máx. de {LimiteMaximoAlunos} alunos por turma atingido!";  // Informa o aluno que não foi incluído
            }

            return mensagem; // Retorna a mensagem resultante
        }

        // Método para abrir a turma
        public bool AbrirTurma()
        {
            if (Alunos.Count < LimiteMinimoAlunos)
            {
                Console.WriteLine($"A turma {Codigo} não pode ser aberta. O número de alunos é inferior ao limite mínimo de {LimiteMinimoAlunos}.");
                return false;
            }

            if (Alunos.Count > LimiteMaximoAlunos)
            {
                Console.WriteLine($"A turma {Codigo} não pode ser aberta. O número de alunos excede o limite máximo de {LimiteMaximoAlunos}.");
                return false;
            }

            Console.WriteLine($"A turma {Codigo} foi aberta com sucesso!");
            return true;
        }

        // Método para gerar a pauta da turma
        public string GerarPauta()
        {
            StringBuilder pauta = new StringBuilder(); // Utiliza StringBuilder para melhorar a performance de concatenação de strings
            pauta.AppendLine();
            pauta.AppendLine("------------------------------------------------");
            pauta.AppendLine($" Pauta da [Turma {Codigo}]"); // Título com a identificação da turma
            pauta.AppendLine("------------------------------------------------");
            pauta.AppendLine($" [ Disciplina {Disciplina.Codigo} - {Disciplina.Nome} ]"); // Informações da disciplina
            pauta.AppendLine($" [ Professor - {Professor.Nome} ]"); // Nome do professor
            pauta.AppendLine();
            pauta.AppendLine($" Alunos matriculados [Turma {Codigo}]"); // Título "Alunos matriculados"

            // Verifica se há alunos inscritos na turma
            if (Alunos.Count > 0)
            {
                foreach (Aluno aluno in Alunos) // Para cada aluno na lista de alunos
                {
                    pauta.AppendLine($"  - [ {aluno.Matricula} ] {aluno.Nome}"); // Adicionar o nome do aluno
                }
            }
            else
            {
                pauta.AppendLine("  - Nenhum aluno inscrito nesta turma."); // Informa que não há alunos inscritos
            }

            pauta.AppendLine("------------------------------------------------");
            return pauta.ToString();
        }

        // ToString() - Método para retornar uma string com informações da turma
        public override string ToString()
        {
            return $"\n[{Codigo}] Disciplina de {Disciplina.Nome} - Prof. {Professor.Nome} ({Alunos.Count} alunos) ]";
        }

        // Método para obter a lista de alunos que não foram adicionados devido ao limite excedido
        public List<Aluno> ObterAlunosNaoAdicionados(List<Aluno> alunosTentados)
        {
            List<Aluno> alunosNaoAdicionados = new List<Aluno>();
            foreach (Aluno aluno in alunosTentados)
            {
                if (Alunos.Count >= LimiteMaximoAlunos)
                {
                    Console.WriteLine($"Não foi possível adicionar o aluno {aluno.Nome} à turma {Codigo}. Limite máximo de alunos atingido.");
                }
                else
                {
                    Alunos.Add(aluno);
                }
            }
            return alunosNaoAdicionados;
        }
    }
}