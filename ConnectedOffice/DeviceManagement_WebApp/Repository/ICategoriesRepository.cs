using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {

        Category GetMostRecentCategory();
        void GetMostRecentGetById(int categ);
        
        void RemoveCategory(Category category);
        void AddCategory(Category category);
        void RemoveRangeCategory(Category category);
        void EditCategory(Category category);
        void ViewCategory(Category category);
    }
}
