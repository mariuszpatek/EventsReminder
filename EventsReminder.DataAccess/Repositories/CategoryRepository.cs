using EventsReminder.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace EventsReminder.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<int> AddCategories(List<Category> categories)
        {
            _context.Categories.AddRange(categories);
            _context.SaveChanges();

            var categoriesIds = categories
                .Select(c => c.CategoryId)
                .ToList();

            return categoriesIds;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
