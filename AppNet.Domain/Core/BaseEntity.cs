using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public abstract class BaseEntity:IEntity
    {
        public int AddingId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
