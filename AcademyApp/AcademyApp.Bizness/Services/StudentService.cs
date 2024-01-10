using System;
using System.Xml.Linq;
using AcademyApp.Business.Interfaces;
using AcademyApp.DataContex.Repositories;
using AcademyApp.Domain.Models;

namespace AcademyApp.Business.Services
{
    public class StudentService : IStudent
    {
        private readonly StudentRepository _studentRepository;
        private readonly GroupRepository _groupRepository;
        private static int Count = 1;

        public StudentService()
        {
            _studentRepository = new();
            _groupRepository = new();
        }
        public Student Create(Student student, string groupname)
        {
            var existGroup = _groupRepository
                .Get(g => g.Name.ToLower() == groupname.ToLower());
            if (existGroup is null) return null;
            student.Id = Count;
            student.Group = existGroup;
            bool result = _studentRepository.Create(student);
            if (!result) return null;
            Count++;
            return student;
            
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public List<Student> GetAll(string name)
        {
            return _studentRepository.
                GetAll(s=>s.Name.ToLower()==name.ToLower());
        }

        public List<Student> GetAll(int age)
        {
            return _studentRepository.GetAll(s => s.Age == age);
        }




        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

       

        public Student Update(int id, Student student, string groupname)
        {
            throw new NotImplementedException();
        }
    }
}

