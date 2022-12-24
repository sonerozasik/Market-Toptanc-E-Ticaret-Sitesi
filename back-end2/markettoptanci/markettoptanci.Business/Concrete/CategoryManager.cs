using markettoptanci.Business.Abstract;
using markettoptanci.DataAccess.Abstract;
using markettoptanci.DataAccess.Concrete;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }
        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public Category DeleteCategory(int id)
        {
            return _categoryRepository.DeleteCategory(id);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            if (id > 0)
            {
                return _categoryRepository.GetCategoryById(id);
            }

            throw new Exception("Id can not be less than 1!");


        }

        public Category UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
