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
        private readonly IRepository<Employee> EmployeeRepository;
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
                //dönüş değeri eklenecek
                throw;
            }
        }
        public List<Employee> GetAll()
        {
            using (var context = new AppNetDbContext())
            {
                var data = (from q in context.Employees
                            select new Employee
                            {
                                EmployeeId = q.EmployeeId,
                                Name = q.Name,
                                LastName = q.LastName,
                                CreateDate = q.CreateDate,
                                DateOfBirth = q.DateOfBirth,
                                Salary = q.Salary,
                                Tc = q.Tc,
                                WDate = q.WDate
                            }).ToList();
                return data;
            }
        }

        public Employee GetById(int id)
        {
            return EmployeeRepository.GetById(id);
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
            using (var context = new AppNetDbContext())
            {
                context.Employees.Remove(context.Employees.FirstOrDefault(d => d.EmployeeId == id));
                context.SaveChanges();
                return true;
            }
        }

        public Employee SearchLastName(string lastName)
        {
            return EmployeeRepository.GetAll().SingleOrDefault(e=>e.LastName==lastName);
        }

        public Employee SearchName(string name)
        {
            return EmployeeRepository.GetAll().SingleOrDefault(e => e.Name == name);
        }

        public Employee SearchTc(string tc)
        {
            return EmployeeRepository.GetAll().SingleOrDefault(e => e.Tc == tc);
        }

        public Employee Update(Employee entity)
        {
            try
            {
                //validationlar ve iş kuralları
                entity.Name.NullOrEmpty(nameof(entity.Name));
                using (var context = new AppNetDbContext())
                {
                    context.Employees.Update(entity);
                    context.SaveChanges();
                }
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
