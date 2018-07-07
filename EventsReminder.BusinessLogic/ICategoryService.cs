using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsReminder.BusinessLogic
{
    public interface ICategoryService
    {
        Task<IEnumerable<int>> GetCategoriesIds(string textForCategorizing);
    }
}