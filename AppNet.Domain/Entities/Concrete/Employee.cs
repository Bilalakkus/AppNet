using AppNet.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Domain.Entities.Concrete
{
    public class Employee : BaseEntity, IEntity
    {
        public int EmployeeId { get; set; }
        public string Tc { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime WDate { get; set; }
        public decimal Salary { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
