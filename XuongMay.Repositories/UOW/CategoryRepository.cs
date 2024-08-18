using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using XuongMay.Contract.Repositories.Entity;
using XuongMay.Contract.Repositories.IUOW;
using XuongMay.Repositories.Context;

namespace XuongMay.Repositories.UOW
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly DatabaseContext _context;

        public CategoryRepository(DatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> CreateCategoryAsync(Category model)
        {
            await _context.Categories.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Category> UpdateCategoryAsync(Category model)
        {
            _context.Categories.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<Category> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return category;
        }
    }
}
