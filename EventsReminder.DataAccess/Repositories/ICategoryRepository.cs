using System.Collections.Generic;
using EventsReminder.Model.Models;

namespace EventsReminder.DataAccess.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<int> AddCategories(List<Category> categories);
        IEnumerable<Category> GetAllCategories();
    }
}