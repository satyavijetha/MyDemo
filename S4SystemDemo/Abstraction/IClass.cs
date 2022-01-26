using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4SystemDemo.Abstraction
{
    public interface IClass
    {
        List<StudentCourse> GetAllClassesAssignedtoStudent();
        Class GetClass(int id);
        Class AddClass(Class course);

        Class AddStudenttoClass(Class course, int classCode);

        void DeleteClass(int id);

        Class EditClass(Class course);
    }
}
