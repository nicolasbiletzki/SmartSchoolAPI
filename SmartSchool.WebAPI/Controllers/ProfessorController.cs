using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Models;
using SQLitePCL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;

        public ProfessorController(IRepository repo) 
        {
            _repo = repo;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _repo.GetProfessoresById(id);
            if (professor == null) return BadRequest("Professor não encontrado");
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges()) return Ok(professor);
            return BadRequest("Professor não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var professor1 = _repo.GetProfessoresById(id);
            if (professor1 == null) return BadRequest("Professor não encontrado");
            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var professor1 = _repo.GetProfessoresById(id);
            if (professor1 == null) return BadRequest("Professor não encontrado");
            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetProfessoresById(id);
            if (professor == null) return BadRequest("Professor não encontrado");
            _repo.Delete(professor);
            _repo.SaveChanges();
            return Ok("Professor excluído.");
        }

    }
}
