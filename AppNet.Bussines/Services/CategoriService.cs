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
       

        public bool RemoveAsync(int id)
        {
            bool result = repository.RemoveAsync(id);
            return  result;
        }

        Task<Category> IRepository<Category>.AddAsync(Category entity)
        {
            return repository.AddAsync(entity);
        }

        Task<List<Category>> IRepository<Category>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Category> IRepository<Category>.GetByIdAsync(int id)
        {
            return repository.GetByIdAsync(id);
        }

        Task<ICollection<Category>> IRepository<Category>.GetListAsync(Expression<Func<Category, bool>> expression)
        {
            return repository.GetListAsync(expression);
        }

        Task<Category> IRepository<Category>.UpdateAsync(Category entity)
        {
            return repository.UpdateAsync(entity);
        }
    }
}
