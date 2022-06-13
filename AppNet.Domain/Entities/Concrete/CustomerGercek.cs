using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public sealed class CustomerGercek:Customer
    {
        
        public string Tc { get; set; }
        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (value.Length > 2) _customerName = value.ToUpper();
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length >= 2) lastName = value.ToUpper();
            }
        }
        public ICollection<Order> orders { get; set; } = new List<Order>();
    }
}
