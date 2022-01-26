using S4SystemDemo.Abstraction;
using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S4SystemDemo.Process
{
    public class StudentClassData : IStudentClass
    {
        public StudentClass AddStudentClass(Student student)
        {
            throw new NotImplementedException();
        }

        public Student AssignStudenttoClass(Student student, string tittle)
        {
            // assign student to classs
            int maxStudentID = MockData.MockData.students.Max(x => x.StudentID);
            Student _student = new Student()
            {
                StudentID = maxStudentID + 1,
                FirstName = student.FirstName,
                LastName = student.LastName
            };


            var code = from s in MockData.MockData.classes
                       where s.Title.ToUpper() == tittle.ToUpper()
                       select s.Code;

            int maxClassID = MockData.MockData.studentclasses.Max(x => x.ID);
            StudentClass studentClass = new StudentClass()
            {
                Code = code.FirstOrDefault(),
                StudentID = _student.StudentID,
                ID = maxClassID + 1
            };

            MockData.MockData.students.Add(_student);
            MockData.MockData.studentclasses.Add(studentClass);


            return MockData.MockData.students.SingleOrDefault(x => x.StudentID == maxStudentID+1);
        }

        public void DeleteStudentFromClass(int id)
        {
            List<int> ids = (from sc in MockData.MockData.studentclasses
                             where sc.StudentID == id
                             select sc.ID).ToList();
            foreach (int classID in ids)
            {
                MockData.MockData.studentclasses.Remove(MockData.MockData.studentclasses.SingleOrDefault(x => x.ID == classID));
            }

        }

        public StudentClass EditStudentClass(Student student)
        {
            throw new NotImplementedException();
        }

        public StudentClass GetStudentClass(int id)
        {
            var studentClasses = MockData.MockData.studentclasses.LastOrDefault(x => x.StudentID == id);
            return studentClasses;
        }


        public List<StudentCourse> GetStudent(int id)
        {
            var result = from s in MockData.MockData.students
                         join sl in MockData.MockData.studentclasses on s.StudentID equals sl.StudentID
                         join c in MockData.MockData.classes on sl.Code equals c.Code
                         where s.StudentID == id
                         select new StudentCourse
                         {
                             StudentFullName = s.FirstName + " " + s.LastName,
                             StudentID = s.StudentID,
                             ClassID = sl.Code,
                             Tittle = c.Title
                         };

            return ((IEnumerable<StudentCourse>)result).ToList();
        }
        public List<StudentClass> GetStudentClasses()
        {
            throw new NotImplementedException();
        }

        public int GetStudentClassCount()
        {
            return MockData.MockData.studentclasses.Count;
        }
    }
}
