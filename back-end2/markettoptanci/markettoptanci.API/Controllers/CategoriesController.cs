using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace markettoptanci.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoriesController()
        {
            _categoryService = new CategoryManager();
        }


        [HttpGet]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetAllCategories();
        }

        [HttpGet("{id}")]
        public Category GetCategoryById(int id)
        {
            return _categoryService.GetCategoryById(id);
        }

        [HttpPost]
        public Category CreateCategory([FromBody] Category category)
        {
            return _categoryService.CreateCategory(category);
        }

        [HttpPut]
        public Category UpdateCategory([FromBody] Category category)
        {
            return _categoryService.UpdateCategory(category);
        }

        [HttpDelete("{id}")]
        public Category DeleteCategory(int id)
        {
            return _categoryService.DeleteCategory(id);
        }
    }
}

