using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public sealed class CustomerTuzel:Customer, IEntity
    {
        public string Vergino { get; set; }
        public string SirketName { get; set; }
    }
}
