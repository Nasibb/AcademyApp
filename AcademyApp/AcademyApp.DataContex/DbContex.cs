using System;
using AcademyApp.Domain.Models;

namespace AcademyApp.DataContex
{
	public static class DbContex
	{
		public static List<Student> Students { get; set; }

		public static List<Group> Groups { get; set; }

		static DbContex()
		{
			Students = new ();
			Groups = new ();
		}
	}

}

