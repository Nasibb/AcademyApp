using System;
using AcademyApp.DataContex.Interfaces;
using AcademyApp.Domain.Models;

namespace AcademyApp.DataContex.Repositories
{
    public class GroupRepository : IRepository<Group>
    {
        public bool Create(Group entity)
        {
            try
            {
                DbContex.Groups.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Group entity)
        {
            try
            {
                DbContex.Groups.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Group Get(Predicate<Group> filter)
        {
            return DbContex.Groups.Find(filter);

        }

        public List<Group> GetAll(Predicate<Group> filter)
        {
            return filter == null ? DbContex.Groups : DbContex.Groups.FindAll(filter);

        }

        public bool Update(Group entity)
        {
            try
            {
                var existGroup = Get(s => s.Id == entity.Id);
                existGroup = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

