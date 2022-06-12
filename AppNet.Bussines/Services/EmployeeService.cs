using AppNet.Bussines.Abstract;
using AppNet.Bussines.Exceptions;
using AppNet.Bussines.Validation;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using AppNet.Infrastructer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppNet.Bussines.Concrete
{
    public class EmployeeService : IRepository<Employee>,IEmployeeService
    {
        //private readonly IRepository<Employee> repository;

        //public EmployeeService(IRepository<Employee> repository)
        //{
        //    this.repository = repository;
        //}
        public Employee Add(Employee entity)
        {

            try
            {
                //validationlar ve iş kuralları
                entity.Name.NullOrEmpty(nameof(entity.Name));

                using (var context = new AppNetDbContext())
                {
                    context.Employees.Add(entity);
                    context.SaveChanges();
                }
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetList(Expression<Func<Employee, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public List<Employee> LoadEmployee()
        {

            throw new NotImplementedException();



        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        //List<Employee> IRepository<Employee>.GetAll()
        //{
        //    //return repository.GetAll();
        //}
    }
}
