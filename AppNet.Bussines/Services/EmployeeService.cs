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
            return repository.Add(entity);
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        //public List<Employee> GetAll()
        //{
        //    return repository.GetAll();
        //}

        public Task<Employee> GetById(int id)
        {
            return repository.GetById(id);
        }

        public Task<ICollection<Employee>> GetList(Expression<Func<Employee, bool>> expression = null)
        {
            return repository.GetList();
        }

        public Task<ICollection<Employee>> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
                return repository.Remove(id);;
        }

        public List<Employee> SearchAll()
        {
            throw new NotImplementedException();
        }

        //public List<Employee> SearchAll()
        //{
        //    return repository.GetAll();
        //}

        public Employee SearchLastName(string lastName)
        {
            //return repository.GetAllAsync().SingleOrDefaultAsync(n => n.LastName == lastName);
            throw new NotImplementedException();
        }

        public Employee SearchName(string name)
        {
            //return  repository.GetAllAsync().SingleOrDefault(n => n.Name == name);
            //return await repository.GetAll().Select(x => x.Name).FirstOrDefault();
            throw new NotImplementedException();
        }

        public Employee SearchTc(string tc)
        {
            //return repository.GetAllAsync().SingleOrDefault(n => n.Tc == tc);
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee entity)
        {
            return repository.Update(entity);
        }

       

        //ICollection<Employee> IEmployeeService.GetAll()
        //{
        //    return repository.GetAll();
        //}
    }
}
