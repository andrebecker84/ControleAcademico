using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcademico
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Disciplina()
        {
            Codigo = 0;
            Nome = string.Empty;
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Nome: {Nome}";
        }
    }
}