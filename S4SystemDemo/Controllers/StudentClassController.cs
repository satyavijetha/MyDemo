using Microsoft.AspNetCore.Mvc;
using S4SystemDemo.Abstraction;
using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace S4SystemDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentClassController : ControllerBase
    {
        private IStudentClass _studentClass;
        public StudentClassController(IStudentClass studentClass)
        {
            _studentClass = studentClass;
        }
        // GET: api/<StudentClassController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentClassController>/5
        [HttpGet("{id}")]
        public IActionResult Getstudent(int id)
        {
            var student = _studentClass.GetStudent(id);
            if (student != null && student.Count > 0)
            {
                return Ok(student);
            }

            return NotFound($"Student with id: {id} was not found");
        }

        // POST api/<StudentClassController>
        [HttpPost("{tittle}")]
        public IActionResult Post([FromBody] Student student, string tittle)
        {
            int beforeUpdate = _studentClass.GetStudentClassCount();
            var count = _studentClass.AssignStudenttoClass(student, tittle);
            int afterUpdate = _studentClass.GetStudentClassCount();
            if (afterUpdate > beforeUpdate)
            {
                return Ok($"Successfully Assigned Student {student.FirstName}  {student.LastName} to Class {tittle}");
            }

            return NotFound($"Not able to assign the Student {student.FirstName}  {student.LastName} to Class {tittle}");
        }

        // PUT api/<StudentClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentClassController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var studentclass = _studentClass.GetStudentClass(id);
            if (studentclass != null)
            {
                _studentClass.DeleteStudentFromClass(id);
                return Ok($"Successfully Removed Student id {id}");
            }

            return NotFound($"Student with id: {id} was not found");
        }
    }
}
