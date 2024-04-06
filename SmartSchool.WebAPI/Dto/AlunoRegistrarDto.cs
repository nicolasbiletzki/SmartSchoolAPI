using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Dto
{
    public class AlunoRegistrarDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string? Sobrenome { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataNasc { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;

    }
}
