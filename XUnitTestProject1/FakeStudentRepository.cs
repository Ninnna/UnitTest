using System;
using System.Collections.Generic;
using System.Text;
using UnitTest;

namespace XUnitTestProject1
{
    public class FakeStudentRepository : IStudentRepository
    {
        public List<Student> GetAll()
        {
            return new List<Student> {
                new Student { Id  = 1, Name  = "Scott" },
                new Student { Id  = 1, Name  = "James" }
            };
        }
    }
}
