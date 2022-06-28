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

        public Category Add(string name)
        {
            Category category = new Category()
            {
                CategoryName = name
            };
            repository.Add(category);
            return category;
        }

        public async Task<ICollection<Category>> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public async Task<bool> Remove(int id)
        {
            await repository.Remove(id);
            return true;
        }

        public Task<Category> Update(int CategoryID, string NewCategoryName)
        {
            //Category category = new Category()
            //{
            //    CategoryId = CategoryID,
            //    CategoryName = NewCategoryName,
            //};
            //repository.Update(category.CategoryId, category);
            //return category;
            throw new NotImplementedException();
        }
    }
}
