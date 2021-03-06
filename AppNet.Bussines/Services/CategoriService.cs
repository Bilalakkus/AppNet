using AppNet.Bussines.Abstract;
using AppNet.Domain.Entities.Abstract;
using AppNet.Domain.Entities.Concrete;
using System.Linq.Expressions;

namespace AppNet.Bussines.Concrete
{
    public class CategoriService : ICategoriService
    {
        private readonly IRepository<Category> _repository;
        public CategoriService(IRepository<Category> repository)
        {
            this._repository = repository;
        }

        public Category Add(string name)
        {
            Category category = new Category()
            {
                CategoryName = name
            };
            _repository.Add(category);
            return category;
        }

        public async Task<ICollection<Category>> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await _repository.Remove(id);
            return true;
        }

        public async Task<Category> Update(int CategoryID, string NewCategoryName)
        {
            Category category = new Category()
            {
                CategoryId = CategoryID,
                CategoryName = NewCategoryName,
            };
            _repository.Update(category);
            return category;
            //throw new NotImplementedException();
        }
    }
}
