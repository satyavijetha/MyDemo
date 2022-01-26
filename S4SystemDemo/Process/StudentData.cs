using S4SystemDemo.Abstraction;
using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4SystemDemo.Process
{
    public class StudentData : IStudent
    {
        public Student AddStudent(Student student)
        {
            int maxStudentID = MockData.MockData.students.Max(x => x.StudentID);
            Student studentObj = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                StudentID = maxStudentID + 1
            };

            MockData.MockData.students.Add(studentObj);

            return studentObj;
        }

        public Student AddStudenttoClass(Student student, int classCode)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            List<int> ids = (from s in MockData.MockData.students
                             where s.StudentID == id
                             select s.StudentID).ToList();
            foreach (int student in ids)
            {
                MockData.MockData.students.Remove(MockData.MockData.students.SingleOrDefault(x => x.StudentID == student));
            }
        }

        public Student EditStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            var student = MockData.MockData.students.LastOrDefault(x => x.StudentID == id);
            return student;
        }

        public List<Student> GetStudents()
        {
            return MockData.MockData.students;
        }

        public int GetStudentCount()
        {
            return MockData.MockData.students.Count;
        }
    }
}
