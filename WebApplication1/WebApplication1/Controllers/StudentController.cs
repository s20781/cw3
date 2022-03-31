using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.DAL;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/students")]
    public class StudentController : ControllerBase
    {

        private readonly IDbservice _dbService;

        public StudentController(IDbservice dbservice)
        {
            _dbService = dbservice;
        }




        [HttpGet]
        public string GetStudent(string orderBy)
        {
            return $"Kowalski , Malewski , Andrzejewski sortowanie={orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            switch (id) {
                case 1: return Ok("Kowalski");
                case 2: return Ok("Malewski");
                case 3: return Ok("Andrzejewski");
            }
            return NotFound("Nie znaleziono studneta");

        }

        [HttpPost]
        public IActionResult CreateStudent(Student student )
        {
            student.IndexNumber = $"s{new Random().Next(1,20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)

        {

            String Index = student.IndexNumber;
            if(id == student.Id)
            {
                student.IndexNumber = Index;
                return Ok(student + "aktualizacja ukonczona");
            }
            return NotFound("Nie znaleziono studenta");
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id, Student student)
        {
            if(id == student.Id)
            {
                return Ok("student usuniety");
            }
            return NotFound("Nie znaleziono studenta");
        }
        

        
    }
}
