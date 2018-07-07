using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsReminder.BusinessLogic.KeyPhrases
{
    public interface IKeyPhrasesAnalyzer
    {
        Task<List<string>> AnalyzeText(string language, string text);
    }
}