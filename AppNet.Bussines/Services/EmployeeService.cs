using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System.Linq.Expressions;

namespace AppNet.Bussines.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        public EmployeeService(IRepository<Employee> repository)
        {
            this._repository = repository;
        }

        public Employee Add(Employee employee)
        {
            _repository.Add(employee);
            return employee;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public bool Remove(int id)
        {
            try
            {
                _repository.Remove(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Task<Employee> Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
