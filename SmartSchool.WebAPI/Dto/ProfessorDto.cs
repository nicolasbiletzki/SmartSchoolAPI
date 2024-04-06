using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Dto
{
    public class ProfessorDto
    {
        public int? Id { get; set; }
        public int Registro { get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataInicio { get; set; } = DateTime.Now;

    }
}
