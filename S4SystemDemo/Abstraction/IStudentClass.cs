using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using S4SystemDemo.Models;

namespace S4SystemDemo.Abstraction
{
    public interface IStudentClass
    {
        List<StudentClass> GetStudentClasses();
        StudentClass GetStudentClass(int id);
        StudentClass AddStudentClass(Student student);

        Student AssignStudenttoClass(Student student, string tittle);

        void DeleteStudentFromClass(int id);

        StudentClass EditStudentClass(Student student);

        int GetStudentClassCount();

        List<StudentCourse> GetStudent(int id);

    }
}
