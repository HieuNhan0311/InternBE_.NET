using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Contract.Repositories.Entity;

namespace XuongMay.Contract.Services.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        public Task<Category> GetCategoryByIdAsync(int id);
        public Task<Category> CreateCategoryAsync(Category model);
        Task<Category> UpdateCategoryAsync(Category model);
        Task<Category> DeleteCategoryAsync(int id);
    }

}
