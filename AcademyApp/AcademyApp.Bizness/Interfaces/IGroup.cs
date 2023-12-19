using System;
using AcademyApp.Domain.Models;

namespace AcademyApp.Business.Interfaces
{
	public interface IGroup
	{
		List<Group> GetAll();

        List<Group> GetAll(int size);

		Group Get(int id);

        Group Delete(int id);

        Group Get(string name);

        Group Create(Group group);

        Group Update(int id, Group group);
    }
}

