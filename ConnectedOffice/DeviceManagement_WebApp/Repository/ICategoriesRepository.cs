using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {

        Category GetMostRecentCategory();
        void RemoveCategory(Category category);
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void EditCategory(Category category);
        void ViewCategory(Category category);
    }
}
