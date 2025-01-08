﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica.Core.IRepositories
{
    public interface IRepositories<T> where T : class
    {
        IEnumerable<T> GetAll();

        T? GetById(int id);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);
    }
}