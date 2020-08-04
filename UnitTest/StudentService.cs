using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public interface IStudentService
    {
        List<Student> GetAll();
    
    }
    public class StudentService : IStudentService
    {
        IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll()
        {
            var data = _repo.GetAll();

            ///.....
            ///

            return data;
        }
    }

    public interface IStudentRepository
    {
        List<Student> GetAll();
    }

    public class RealDatabaseStudentRepository : IStudentRepository
    {
        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
