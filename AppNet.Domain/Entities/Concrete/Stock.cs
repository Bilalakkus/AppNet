using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Stock : BaseEntity
    {
        public int StockId { get; set; }
        public int Piece { get; set; }
        public Product Product { get; set; }
    }
}
