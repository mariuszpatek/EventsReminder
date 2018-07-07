using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EventsReminder.BusinessLogic.KeyPhrases
{
    public class KeyPhrasesAnalyzer : IKeyPhrasesAnalyzer
    {
        private readonly IConfiguration _configuration;

        public KeyPhrasesAnalyzer(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<string>> AnalyzeText(string language, string text)
        {
            var document = new KeyPhraseDocument
            {
                Id = Guid.NewGuid().ToString(),
                Language = language,
                Text = text
            };

            var conteiner = new KeyPhraseDocumentsConteiner();
            conteiner.documents.Add(document);
            var content = new StringContent(JsonConvert.SerializeObject(conteiner), Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _configuration["Data:KeyPhrasesAnalyzer:Key"]);
                var result = await client.PostAsync("https://westeurope.api.cognitive.microsoft.com/text/analytics/v2.0/keyPhrases", content);
                dynamic dynamicObject = JsonConvert.DeserializeObject(await result.Content.ReadAsStringAsync());
                var keyPhrases = JsonConvert.DeserializeObject<List<string>>(dynamicObject.documents[0].keyPhrases.ToString());              
                return keyPhrases;
            }
        }
    }
}
