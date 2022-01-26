using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4SystemDemo.Abstraction
{
    public interface IStudent
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        Student AddStudent(Student student);

        Student AddStudenttoClass(Student student, int classCode);

        void DeleteStudent(int id);

        Student EditStudent(Student student);
        int GetStudentCount();
    }
}
