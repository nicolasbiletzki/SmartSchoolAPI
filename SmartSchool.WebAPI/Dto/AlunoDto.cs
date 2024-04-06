using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Dto
{
    public class AlunoDto
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; }
        public int Idade { get; set; }
        public DateTime DataIni { get; set; }

    }
}
