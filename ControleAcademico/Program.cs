using System;
using System.Collections.Generic;

namespace ControleAcademico
{
    public class Program
    {
        static void Main(string[] args)
        {
            Disciplina disciplina = new Disciplina(1, "Matemática");
            Professor professor = new Professor(101, "João Silva");
            Turma turma = new Turma(1, disciplina);

            Aluno aluno1 = new Aluno(1001, "Maria");
            Aluno aluno2 = new Aluno(1002, "Pedro");

            Console.WriteLine(turma.addAluno(aluno1)); // Saída: Aluno adicionado à turma.
            Console.WriteLine(turma.addAluno(aluno2)); // Saída: Aluno adicionado à turma.
            Console.WriteLine(turma.addAluno(new Aluno(1003, "Ana"))); // Saída: Turma cheia.

            Console.WriteLine(turma.gerarPauta());

            // Testando os métodos ToString() das classes
            Console.WriteLine(aluno1);
            Console.WriteLine(professor);
            Console.WriteLine(disciplina);
            Console.WriteLine(turma);
        }
    }
}