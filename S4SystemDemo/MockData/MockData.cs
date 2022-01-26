using S4SystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S4SystemDemo.MockData
{
    public class MockData
    {
        //Student mock data
        public static List<Student> students = new List<Student>()
        {
            new Student{StudentID=1,FirstName="Carson",LastName="Alexander"},
            new Student{StudentID=2,FirstName="Meredith",LastName="Alonso"},
            new Student{StudentID=3,FirstName="Arturo",LastName="Anand"},
            new Student{StudentID=4,FirstName="Gytis",LastName="Barzdukas"},
            new Student{StudentID=5,FirstName="Yan",LastName="Li"},
            new Student{StudentID=6,FirstName="Peggy",LastName="Justice"},
            new Student{StudentID=7,FirstName="Laura",LastName="Norman"},
            new Student{StudentID=8,FirstName="Nino",LastName="Olivetto"}
         };

        //Class mock data
        public static List<Class> classes = new List<Class>()
        {
           new Class{Code=1,Title="DOTNET"},
            new Class{Code=2,Title="Java"},
            new Class{Code=3,Title="JavaScript"},
            new Class{Code=4,Title="Angular"},
            new Class{Code=5,Title="SqlServer"},
            new Class{Code=6,Title="TypeScript"},
            new Class{Code=7,Title="MySql"}
        };

        //StudentClass mock data
        public static List<StudentClass> studentclasses = new List<StudentClass>()
        {
            new StudentClass { ID = 1, StudentID = 1, Code = 1 },
            new StudentClass { ID = 2, StudentID = 1, Code = 2 },
            new StudentClass { ID = 3, StudentID = 1, Code = 3 },
            new StudentClass { ID = 4, StudentID = 2, Code = 4 },
            new StudentClass { ID = 5, StudentID = 2, Code = 5 },
            new StudentClass { ID = 6, StudentID = 2, Code = 6 },
            new StudentClass { ID = 7, StudentID = 3, Code = 1 },
            new StudentClass { ID = 8, StudentID = 4, Code = 1 },
            new StudentClass { ID = 9, StudentID = 4, Code = 2 },
            new StudentClass { ID = 10, StudentID = 5, Code = 3 },
            new StudentClass { ID = 11, StudentID = 6, Code = 4 },
            new StudentClass { ID = 12, StudentID = 7, Code = 5 }
        };
    }
}
