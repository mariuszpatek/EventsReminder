using EventsReminder.BusinessLogic.KeyPhrases;
using System.Collections.Generic;

namespace EventsReminder.BusinessLogic.KeyPhrases
{
    public class KeyPhraseDocumentsConteiner
    {
        public KeyPhraseDocumentsConteiner()
        {
            documents = new List<KeyPhraseDocument>();
        }
        public List<KeyPhraseDocument> documents { get; set; }
    }
}
