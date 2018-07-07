using EventsReminder.BusinessLogic.KeyPhrases;
using EventsReminder.DataAccess.Repositories;
using EventsReminder.Model.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsReminder.BusinessLogic
{
    public class CategoryService : ICategoryService
    {
        private readonly ILogger _logger;
        private readonly IKeyPhrasesAnalyzer _keyPhrasesAnalyzer;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ILoggerFactory loggerFactory, IKeyPhrasesAnalyzer keyPhrasesAnalyzer, ICategoryRepository categoryRepository)
        {
            _logger = loggerFactory.CreateLogger<CategoryService>();
            _keyPhrasesAnalyzer = keyPhrasesAnalyzer;
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<int>> GetCategoriesIds(string textForCategorizing)
        {
            var categoriesIdsToReturn = new List<int>();
            try
            {
                var keyPhrases = await _keyPhrasesAnalyzer.AnalyzeText("pl", textForCategorizing);
                var availableCategories = _categoryRepository.GetAllCategories();

                var categoriesWhichAlreadyExistInDatabase = availableCategories
                    .Where(ac => keyPhrases.Select(k => k.ToLower()).Contains(ac.Name.ToLower()))
                    .ToList();

                var categoriesToAdd = keyPhrases
                    .Except(categoriesWhichAlreadyExistInDatabase.Select(c => c.Name), StringComparer.OrdinalIgnoreCase)
                    .Select(k => new Category() { Name = k })
                    .ToList();

                var newlyAddedCategories = _categoryRepository.AddCategories(categoriesToAdd);

                categoriesIdsToReturn.AddRange(categoriesWhichAlreadyExistInDatabase.Select(c => c.CategoryId));
                categoriesIdsToReturn.AddRange(newlyAddedCategories);

                return categoriesIdsToReturn;
            }
            catch (System.Exception ex)
            {
                _logger.LogError($"Error occured during adding categories: {ex.ToString()}");
                return null;
            }
        }

    }
}
