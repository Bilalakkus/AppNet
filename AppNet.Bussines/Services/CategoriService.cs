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
       
        public Category GetCategory(string name)
        {
            //var result = repository.GetAllAsync();
            throw new NotImplementedException();
        }
        public Category Add(Category entity)
        {
            // validations
            return repository.Add(entity);
        }

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

       public  Task<Category> GetById(int id)
        {
            return repository.GetById(id);
        }

        public Task<ICollection<Category>> GetList(Expression<Func<Category, bool>> expression)
        {
            return repository.GetList(expression);
        }

        public Task<Category> Update(Category entity)
        {
            return repository.Update(entity);
        }

        public bool Remove(int id)
        {
            return repository.Remove(id);
        }
    }
}
