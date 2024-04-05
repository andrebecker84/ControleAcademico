namespace ControleAcademico
{
    public class Professor
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Professor()
        {
            Matricula = 0;
            Nome = string.Empty;
        }

        public void LancarNotas()
        {
            Console.WriteLine("Lançando notas para os alunos...");
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}, Nome: {Nome}";
        }
    }
}