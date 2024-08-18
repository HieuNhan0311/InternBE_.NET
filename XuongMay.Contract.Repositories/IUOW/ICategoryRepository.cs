using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XuongMay.Contract.Repositories.Entity;
using XuongMay.Contract.Repositories.Interface;

namespace XuongMay.Contract.Repositories.IUOW
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        public Task<Category> GetCategoryByIdAsync(int id);
        public Task<Category> CreateCategoryAsync(Category model);
        Task<Category> UpdateCategoryAsync(Category model);
        Task<Category> DeleteCategoryAsync(int id);
    }

}
