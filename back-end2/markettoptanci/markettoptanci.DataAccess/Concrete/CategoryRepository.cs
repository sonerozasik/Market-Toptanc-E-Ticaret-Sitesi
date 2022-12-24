using markettoptanci.DataAccess.Abstract;
using markettoptanci.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markettoptanci.DataAccess.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        public Category CreateCategory(Category category)
        {
            using (var categoryDbContext = new UserDbContext())
            {
                categoryDbContext.Categories.Add(category);
                categoryDbContext.SaveChanges();
                return category;
            }
        }

        public Category DeleteCategory(int id)
        {
            using (var categoryDbContext = new UserDbContext())
            {
                var deleteCategory = GetCategoryById(id);
                categoryDbContext.Categories.Remove(deleteCategory);
                categoryDbContext.SaveChanges();
                return deleteCategory;
            }
        }

        public Category GetCategoryById(int id)
        {
            using (var categoryDbContext = new UserDbContext())
            {
                return categoryDbContext.Categories.Find(id);
            }
        }

        public List<Category> GetAllCategories()
        {
            using (var categoryDbContext = new UserDbContext())
            {
                return categoryDbContext.Categories.ToList();
            }
        }

        public Category UpdateCategory(Category category)
        {
            using (var categoryDbContext = new UserDbContext())
            {
                categoryDbContext.Categories.Update(category);
                categoryDbContext.SaveChanges();
                return category;
            }
        }
    }
}
