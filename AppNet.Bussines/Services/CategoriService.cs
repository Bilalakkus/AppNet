using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System.Linq.Expressions;
namespace AppNet.Bussines.Concrete
{
    public class CategoriService : ICategoriService
    {
        private readonly IRepository<Category> repository;
        public CategoriService(IRepository<Category> repository)
        {
            this.repository = repository;
        }
        public Category Add(Category entity)
        {
           return repository.Add(entity);
        }
        public List<Category> GetAll()
        {
            return repository.GetAll();
        }
        public Category GetById(int id)
        {
            return repository.GetById(id);
        }
        public Category GetCategory(string name)
        {
            return repository.GetAll().SingleOrDefault(c=>c.CategoryName == name);
        }
        public ICollection<Category> GetList(Expression<Func<Category, bool>> expression = null)
        {
            return repository.GetList(expression);
        }
        public bool Remove(int id)
        {
            bool result=repository.Remove(id);
            return result;
        }
        public Category Update(Category entity)
        {
            return repository.Update(entity);
        }
    }
}
