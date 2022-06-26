using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Category:BaseEntity
    {
        public int CategoryId { get; set; }
        private string _categoriName;

        public string CategoryName
        {
            get { return _categoriName; }
            set { _categoriName = value.ToUpper(); }
        }

        //public ICollection<Product> Products { get; set; }=new List<Product>();
    }
}
