using S4SystemDemo.Abstraction;
using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4SystemDemo.Process
{
    public class ClassData : IClass
    {
        public Class AddClass(Class course)
        {
            throw new NotImplementedException();
        }

        public Class AddStudenttoClass(Class course, int classCode)
        {
            throw new NotImplementedException();
        }

        public void DeleteClass(int id)
        {
            throw new NotImplementedException();
        }

        public Class EditClass(Class course)
        {
            throw new NotImplementedException();
        }

        public Class GetClass(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentCourse> GetAllClassesAssignedtoStudent()
        {
           var result = from c in MockData.MockData.classes
                               join sl in MockData.MockData.studentclasses on c.Code equals sl.Code
                               join st in MockData.MockData.students on sl.StudentID equals st.StudentID
                               select new StudentCourse
                               {
                                   ClassID = c.Code,
                                   Tittle = c.Title,
                                   StudentID = st.StudentID,
                                   StudentFullName = st.FirstName + " " + st.LastName
                               };

            return ((IEnumerable<StudentCourse>)result).ToList();
        }
    }
}
