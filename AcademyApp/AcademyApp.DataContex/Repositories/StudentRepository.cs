using System;
using AcademyApp.DataContex.Interfaces;
using AcademyApp.Domain.Models;

namespace AcademyApp.DataContex.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                DbContex.Students.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                DbContex.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Student Get(Predicate<Student> filter)
        {
            return DbContex.Students.Find(filter);
        }

        public List<Student> GetAll(Predicate<Student> filter=null)
        {
            return filter == null ? DbContex.Students : DbContex.Students.FindAll(filter);   
        }

        public bool Update(Student entity)
        {
            try
            {
                var existStudent = Get(s => s.Id == entity.Id);
                existStudent = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

