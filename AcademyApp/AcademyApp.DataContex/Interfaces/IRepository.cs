﻿using System;
using AcademyApp.Domain.Models.Common;

namespace AcademyApp.DataContex.Interfaces
{
	public interface IRepository<T>where T: BaseEntity
	{
		bool Create (T entity);

		bool Update(T entity);

		bool Delete(T entity);

		T Get(Predicate<T> filter);
		List<T> GettAll(Predicate<T> filter);
	}
}
