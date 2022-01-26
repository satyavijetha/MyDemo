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
    public class StudentController : ControllerBase
    {
        private IStudent _studentData;
        public StudentController(IStudent studentData)
        {
            _studentData = studentData;
        }
        // GET: api/<StudentController>
        [HttpGet]
        // [Route("api/[controller]")]
        public IActionResult GetStudents()
        {
            return Ok(_studentData.GetStudents());
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult Getstudent(int id)
        {
            var student = _studentData.GetStudent(id);
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound($"Student with id: {id} was not found");
        }

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            int beforeUpdate = _studentData.GetStudentCount();
            Student studentObj = _studentData.AddStudent(student);
            int afterUpdate = _studentData.GetStudentCount();
            if (afterUpdate > beforeUpdate)
            {
                return Ok($"Student {studentObj.FirstName} {studentObj.LastName} ID: {studentObj.StudentID} added Successfully");
            }
            return NotFound($"Student {studentObj.FirstName} {studentObj.LastName} ID: {studentObj.StudentID} was not added");
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = _studentData.GetStudent(id);
            if (student != null)
            {
                _studentData.DeleteStudent(id);
                return Ok($"Successfully Removed Student id {id}");
            }

            return NotFound($"Student with id: {id} was not found");
        }
    }
}
