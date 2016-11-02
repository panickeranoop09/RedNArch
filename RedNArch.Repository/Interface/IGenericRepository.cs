﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedNArch.Model;
using RedNArch.Model.Model;
using System.Linq.Expressions;

namespace RedNArch.Repository.Interface
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
