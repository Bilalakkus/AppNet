﻿using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        bool Remove(int id);
        TEntity GetById(int id);
        List<TEntity> GetAll();
        ICollection<TEntity> GetList(Expression<Func<TEntity, bool>> expression=null);
    }
}
