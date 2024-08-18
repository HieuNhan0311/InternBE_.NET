using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Contract.Repositories.Entity;
using XuongMay.Contract.Repositories.Interface;
using XuongMay.Contract.Repositories.IUOW;
using XuongMay.Contract.Services.Interface;
using XuongMay.ModelViews.CategoryModelViews;
using XuongMay.Repositories.UOW;

namespace XuongMay.Services.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public Task<Category> CreateCategoryAsync(Category model)
        {
            return _repository.CreateCategoryAsync(model);
        }

        public Task<Category> DeleteCategoryAsync(int id)
        {
            return _repository.DeleteCategoryAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _repository.GetAllCategoriesAsync();
        }
        

        public Task<Category> GetCategoryByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task<Category> UpdateCategoryAsync(Category model)
        {
            return _repository.UpdateCategoryAsync(model);
        }
    }

}
