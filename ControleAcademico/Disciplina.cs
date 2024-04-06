namespace ControleAcademico
{
    public class Disciplina
    {
        // PROPRIEDADES:
        public int Codigo { get; set; }
        public string Nome { get; set; }

        // CONSTRUTORES:
        public Disciplina()
            {
                Codigo = 0;
                Nome = string.Empty;
            }

        public Disciplina(int codigo, string nome)
            {
                Codigo = codigo;
                Nome = nome;
            }

        public override string ToString()
            {
                return $"Código: {Codigo}, Nome: {Nome}";
            }
    }
}