﻿using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IDatabaseService //: IRepository<DataBase>
    {
        DataBase Add(DataBase entity);
        Task<ICollection<DataBase>> GetList();
    }
}