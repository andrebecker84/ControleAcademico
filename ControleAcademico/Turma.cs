using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcademico
{
    public class Turma
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Turma(int codigo, Disciplina disciplina)
        {
            Codigo = codigo;
            Disciplina = disciplina;
            Alunos = new List<Aluno>();
        }

        public Turma()
        {
            Codigo = 0;
            Disciplina = new Disciplina();
            Alunos = new List<Aluno>();
        }

        public string addAluno(Aluno aluno)
        {
            if (Alunos.Count < 50)
            {
                Alunos.Add(aluno);
                return "Aluno adicionado à turma.";
            }
            else
            {
                return "Turma cheia.";
            }
        }

        public bool abrirTurma()
        {
            // Lógica para verificar se a turma pode ser aberta
            return true;
        }

        public string gerarPauta()
        {
            string pauta = $"Código da turma: {Codigo}\n";
            pauta += $"Nome da disciplina: {Disciplina.Nome}\n";
            // Adicionar informações do professor
            pauta += "Lista de alunos inscritos:\n";
            foreach (Aluno aluno in Alunos)
            {
                pauta += $"- {aluno.Nome}\n";
            }
            return pauta;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Disciplina: {Disciplina.Nome}, Quantidade de Alunos: {Alunos.Count}";
        }
    }
}