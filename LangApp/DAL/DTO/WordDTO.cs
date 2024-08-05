using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class WordDTO
    {
        public List<WordDetailDTO> Words { get; set; }
        public List<WordDetailDTO> PhraseWords { get; set; }
        public List<WordDetailDTO> Sentences { get; set; }
        public List<WordDetailDTO> Nouns { get; set; }
        public List<WordDetailDTO> Adjectives { get; set; }
        public List<WordDetailDTO> Verbs { get; set; }
        public List<WordDetailDTO> Adverbs { get; set; }
        public List<WordDetailDTO> Conjunction { get; set; }
        public List<PartOfSpeechDetailDTO> PartsOfSpeech { get; set; }
        public List<WordCaseDetailDTO> WordCases { get; set; }
        public List<MonthDetailDTO> Months { get; set; }
        public List<WordGroupDetailDTO> WordGroups { get; set; }
    }
}
