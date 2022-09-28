using Autofac.Core;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class CategoriesRepository : GenericRepository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public Category GetMostRecentCategory()
        {
            return _context.Category.OrderByDescending(category => category.DateCreated).FirstOrDefault();
        }
        /**
        public void CreateCategory(Category category)
        {
            Add(category);
        }
        **/
        public void CreateCategory(Category category)
        {
            Add(category);
        }
        

        public void RemoveCategory(Category category)
        {
            Remove(category);
        }

        void ICategoriesRepository.AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoriesRepository.DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoriesRepository.EditCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoriesRepository.ViewCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
