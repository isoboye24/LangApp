using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangApp.DAL.DTO
{
    public class WordGroupDTO
    {
        public List<WordGroupDetailDTO> WordGroups { get; set; }
        public List<PartOfSpeechDetailDTO> PartsOfSpeech { get; set; }
    }
}
