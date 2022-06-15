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

        public Task<Employee> AddAsync(Employee entity)
        {
            return repository.AddAsync(entity);
        }

        public Task<List<Employee>> GetAllAsync()
        {
            return repository.GetAllAsync();
        }

        public Task<Employee> GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        public Task<ICollection<Employee>> GetListAsync(Expression<Func<Employee, bool>> expression = null)
        {
            return repository.GetListAsync(expression);
        }

        public bool RemoveAsync(int id)
        {
                return repository.RemoveAsync(id);;
        }

        public Employee SearchLastName(string lastName)
        {
            //return repository.GetAllAsync().SingleOrDefaultAsync(n => n.LastName == lastName);
            throw new NotImplementedException();
        }

        public Employee SearchName(string name)
        {
           //return  repository.GetAllAsync().SingleOrDefault(n => n.Name == name);
            throw new NotImplementedException();
        }

        public Employee SearchTc(string tc)
        {
            //return repository.GetAllAsync().SingleOrDefault(n => n.Tc == tc);
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(Employee entity)
        {
            return repository.UpdateAsync(entity);
        }
    }
}
