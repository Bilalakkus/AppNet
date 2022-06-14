using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Abstract
{
    public interface IProductService:IRepository<Product>
    {
        Product SearchProductName(string name);
    }
}
