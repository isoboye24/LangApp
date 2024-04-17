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
        public List<PartOfSpeechDetailDTO> Categories { get; set; }
        public List<MonthDetailDTO> Months { get; set; }
    }
}
