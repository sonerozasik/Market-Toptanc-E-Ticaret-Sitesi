using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();

        Category GetCategoryById(int id);

        Category CreateCategory(Category category);

        Category UpdateCategory(Category category);

        Category DeleteCategory(int id);
    }
}
