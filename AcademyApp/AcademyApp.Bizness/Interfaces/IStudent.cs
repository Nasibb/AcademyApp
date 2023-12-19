using System;
using AcademyApp.Domain.Models; 

namespace AcademyApp.Business.Interfaces
{
	public interface IStudent
	{
		List<Student> GetAll();

		List<Student> GetAll(string name);

        List<Student> GetAll(int age); //string age cagira bilmirik.

		Student Get(int id);

		Student Delete(int id);

		Student Update(int id, Student student);

		Student Create(Student student);
    }
}

