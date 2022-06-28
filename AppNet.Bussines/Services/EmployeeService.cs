using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System.Linq.Expressions;

namespace AppNet.Bussines.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> repository;
        public EmployeeService(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public Employee Add(Employee employee)
        {
           
            repository.Add(employee);
            return employee;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public bool Remove(int id)
        {
             repository.Remove(id);
            return true;
        }

        public Task<Employee> Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
