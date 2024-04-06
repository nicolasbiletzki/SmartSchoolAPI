namespace SmartSchool.WebAPI.Models
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(int id, int matricula, string nome, string sobrenome, string telefone, DateTime dataNasc) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Sobrenome = sobrenome;
            this.Matricula = matricula;
            this.DataNasc = dataNasc;
        }

        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string? Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;

        public IEnumerable<AlunoDisciplina>? AlunosDisciplinas { get; set; }
    }
}
