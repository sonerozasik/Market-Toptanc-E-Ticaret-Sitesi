using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

        Category GetCategoryById(int id);

        Category CreateCategory(Category category);

        Category UpdateCategory(Category category);

        Category DeleteCategory(int id);
    }
}
