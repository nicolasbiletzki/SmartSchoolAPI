using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Nicolas",
                Telefone = "3212312"
            },

            new Aluno()
            {
                Id = 2,
                Nome = "Nicolas2",
                Telefone = "3212312"
            },

            new Aluno()
            {
                Id = 3,
                Nome = "Nicolas3",
                Telefone = "3212312"
            }
        };
        public  AlunoController() {}

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("Alunos: teste1, teste2, teste3");
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
