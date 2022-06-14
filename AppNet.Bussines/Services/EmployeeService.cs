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
        public Employee Add(Employee entity)
        {
            repository.Add(entity);
            return entity;
        }
        public List<Employee> GetAll()
        {
            return repository.GetAll();
        }
        public Employee GetById(int id)
        {
            return repository.GetById(id);
        }
        public ICollection<Employee> GetList(Expression<Func<Employee, bool>> expression = null)
        {
            return repository.GetList(expression);
        }
        public bool Remove(int id)
        {
            var result=repository.Remove(id);
            return result;
        }
        public Employee SearchLastName(string lastName)
        {
            return repository.GetAll().SingleOrDefault(n=>n.LastName==lastName);
        }
        public Employee SearchName(string name)
        {
            return repository.GetAll().SingleOrDefault(n => n.Name == name);
        }
        public Employee SearchTc(string tc)
        {
            return repository.GetAll().SingleOrDefault(n => n.Tc == tc);
        }
        public Employee Update(Employee entity)
        {
            return repository.Update(entity);
        }
    }
}
