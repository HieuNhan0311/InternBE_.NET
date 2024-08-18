using Microsoft.AspNetCore.Mvc;
using XuongMay.Contract.Repositories.Entity;
using XuongMay.Contract.Services.Interface;
using XuongMay.ModelViews.CategoryModelViews;
using System.Threading.Tasks;

namespace XuongMayBE.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var models = await _categoryService.GetAllCategoriesAsync();
            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var models = await _categoryService.GetCategoryByIdAsync(id);
            if (models == null)
                return NotFound();
            return Ok(models);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryModelViews categoryModelViews)
        {
            if (categoryModelViews == null)
            {
                return BadRequest("Invalid category data.");
            }
            var category = new Category
            {
                Name = categoryModelViews.Name,
                Description = categoryModelViews.Description
            };
            var newCategory = await _categoryService.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = newCategory.Id }, newCategory);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, CreateCategoryModelViews categoryModelViews)
        {
            var existingCategory = await _categoryService.GetCategoryByIdAsync(id);
            if (existingCategory == null)
                return NotFound();

            existingCategory.Name = categoryModelViews.Name;
            existingCategory.Description = categoryModelViews.Description;

            await _categoryService.UpdateCategoryAsync(existingCategory);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return NoContent();
        }
    }
}
/// cmt abc